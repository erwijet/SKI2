using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using SyntaxHighlighter;

namespace SKI_2._0
{
    class Compiler
    {
        private int LineCount = 0;
        public string[] lines;
        List<string> buffer { get; set; }

        public Compiler(IEnumerable<string> TEXTDATA)
        {
            LineCount = TEXTDATA.Count();
            this.buffer = new List<string>();
            lines = TEXTDATA.ToArray<string>();
        }

        private void CheckFunction(string data, string keyword, string commandParam, bool APPEND, string EndData)
        {
            if (data.Length >= keyword.Length)
                if (data.Substring(0, keyword.Length) == keyword)
                {
                    if (!APPEND)
                        this.buffer.Add(commandParam);
                    else
                        this.buffer.Add(commandParam + data.Substring(keyword.Length) + EndData);
                }

        }

        public void Compile(bool DoRun)
        {
            buffer.Add(@"'MADE WITH SKI SCRIPTING 2.0 github.com/erwijet/ski2");
            buffer.Add("Set WshShell = WScript.CreateObject(\"WScript.Shell\")");

            for (int i = 0; i < this.LineCount; i++)
            {
                string t = this.lines[i];

                if (t.Length > 0)
                {
                    this.CheckFunction(t, "$", "'", true, "");
                    this.CheckFunction(t, "entr", "WshShell.SendKeys \"{ENTER}\"", false, "");
                    this.CheckFunction(t, "bacs", "WshShell.SendKeys \"{BACKSPACE}\"", false, "");
                    this.CheckFunction(t, "inject", "WshShell.SendKeys", true, "");
                    this.CheckFunction(t, "runapp", "WshShell.Run", true, "");
                    this.CheckFunction(t, "esc", "WshShell.SendKeys \"{ESCAPE}\"", false, "");
                    this.CheckFunction(t, "sleep", "WScript.Sleep", true, "");
                }
            }

            using (StreamWriter s = new StreamWriter("inject.vbs"))
            {
                foreach (string ThisString in this.buffer)
                {
                    s.WriteLine(ThisString);
                }
            }
            this.buffer.Clear();

            if (DoRun)
                Process.Start("inject.vbs");
        }
    }
}
