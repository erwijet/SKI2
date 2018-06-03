using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyntaxHighlighter;

namespace SKI_2._0
{
    public partial class frm_main : Form
    {
        Compiler c { get; set; }

        public frm_main()
        {
            InitializeComponent();
            UpdateSettings();
        }

        private void UpdateSettings()
        {
            srtb_interface.Settings.EnableIntegers = true;
            srtb_interface.Settings.EnableStrings = true;
            srtb_interface.Settings.EnableComments = true;

            srtb_interface.Settings.IntegerColor = Color.Red;
            srtb_interface.Settings.StringColor = Color.YellowGreen;
            srtb_interface.Settings.CommentColor = Color.Gray;
            srtb_interface.Settings.KeywordColor = Color.Blue;

            srtb_interface.Settings.Comment = "$";

            Stack<string> k = new Stack<string>();

            k.Push("entr");
            k.Push("bacs");
            k.Push("inject");
            k.Push("runapp");
            k.Push("sleep");
            k.Push("esc");

            srtb_interface.Settings.Keywords.AddRange(k);
            srtb_interface.CompileKeywords();
        }

        private void btn_build_Click(object sender, EventArgs e)
        {
            c = new Compiler(srtb_interface.Lines);
            c.Compile(CB_RUNONBUILD.Checked);
        }
    }
}


/*
 
     
     PROJECT.ski

    include 

    [%%NORMALFILE]
     
     
    [%%ENDNORMALFILE]
    [%%VBSFILE]

    [%%ENDVBSFILE]
     
     
     
     */
