namespace SKI_2._0
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.srtb_interface = new SyntaxHighlighter.SyntaxRichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_build = new System.Windows.Forms.Button();
            this.CB_RUNONBUILD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // srtb_interface
            // 
            this.srtb_interface.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srtb_interface.Location = new System.Drawing.Point(12, 12);
            this.srtb_interface.Name = "srtb_interface";
            this.srtb_interface.Size = new System.Drawing.Size(701, 384);
            this.srtb_interface.TabIndex = 0;
            this.srtb_interface.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(719, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save Project";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(719, 39);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(109, 23);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Open Project";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // btn_build
            // 
            this.btn_build.Location = new System.Drawing.Point(719, 80);
            this.btn_build.Name = "btn_build";
            this.btn_build.Size = new System.Drawing.Size(109, 23);
            this.btn_build.TabIndex = 3;
            this.btn_build.Text = "Build";
            this.btn_build.UseVisualStyleBackColor = true;
            this.btn_build.Click += new System.EventHandler(this.btn_build_Click);
            // 
            // CB_RUNONBUILD
            // 
            this.CB_RUNONBUILD.AutoSize = true;
            this.CB_RUNONBUILD.Checked = true;
            this.CB_RUNONBUILD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_RUNONBUILD.Location = new System.Drawing.Point(719, 109);
            this.CB_RUNONBUILD.Name = "CB_RUNONBUILD";
            this.CB_RUNONBUILD.Size = new System.Drawing.Size(86, 17);
            this.CB_RUNONBUILD.TabIndex = 4;
            this.CB_RUNONBUILD.Text = "Run on build";
            this.CB_RUNONBUILD.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 407);
            this.Controls.Add(this.CB_RUNONBUILD);
            this.Controls.Add(this.btn_build);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.srtb_interface);
            this.Name = "frm_main";
            this.Text = "SKI 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SyntaxHighlighter.SyntaxRichTextBox srtb_interface;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_build;
        private System.Windows.Forms.CheckBox CB_RUNONBUILD;
    }
}

