namespace ExcelLite
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewFileLabel = new System.Windows.Forms.Label();
            this.OpenFileLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.WhoLabel = new System.Windows.Forms.Label();
            this.ProgamNameLabel = new System.Windows.Forms.Label();
            this.ProgramNameExplLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewFileLabel
            // 
            this.NewFileLabel.AutoSize = true;
            this.NewFileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewFileLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NewFileLabel.Location = new System.Drawing.Point(103, 115);
            this.NewFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NewFileLabel.Name = "NewFileLabel";
            this.NewFileLabel.Size = new System.Drawing.Size(146, 33);
            this.NewFileLabel.TabIndex = 0;
            this.NewFileLabel.Text = "  Нова таблиця";
            this.NewFileLabel.Click += new System.EventHandler(this.NewFileLabel_Click);
            this.NewFileLabel.MouseLeave += new System.EventHandler(this.NewFileLabel_Leave);
            this.NewFileLabel.MouseHover += new System.EventHandler(this.NewFileLabel_Hover);
            // 
            // OpenFileLabel
            // 
            this.OpenFileLabel.AutoSize = true;
            this.OpenFileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.OpenFileLabel.Location = new System.Drawing.Point(89, 157);
            this.OpenFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OpenFileLabel.Name = "OpenFileLabel";
            this.OpenFileLabel.Size = new System.Drawing.Size(182, 33);
            this.OpenFileLabel.TabIndex = 1;
            this.OpenFileLabel.Text = " Відкрити таблицю";
            this.OpenFileLabel.Click += new System.EventHandler(this.OpenFileLabel_Click);
            this.OpenFileLabel.MouseLeave += new System.EventHandler(this.OpenFileLabel_Leave);
            this.OpenFileLabel.MouseHover += new System.EventHandler(this.OpenFileLabel_Hover);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ExitLabel.Location = new System.Drawing.Point(139, 251);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(70, 33);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = " Вихід";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_Leave);
            this.ExitLabel.MouseHover += new System.EventHandler(this.ExitLabel_Hover);
            // 
            // WhoLabel
            // 
            this.WhoLabel.AutoSize = true;
            this.WhoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhoLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WhoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.WhoLabel.Location = new System.Drawing.Point(109, 206);
            this.WhoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WhoLabel.Name = "WhoLabel";
            this.WhoLabel.Size = new System.Drawing.Size(141, 33);
            this.WhoLabel.TabIndex = 3;
            this.WhoLabel.Text = " Про програму";
            this.WhoLabel.Click += new System.EventHandler(this.WhoLabel_Click);
            this.WhoLabel.MouseLeave += new System.EventHandler(this.WhoLabel_Leave);
            this.WhoLabel.MouseHover += new System.EventHandler(this.WhoLabel_Hover);
            // 
            // ProgamNameLabel
            // 
            this.ProgamNameLabel.AutoSize = true;
            this.ProgamNameLabel.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ProgamNameLabel.Location = new System.Drawing.Point(15, 23);
            this.ProgamNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProgamNameLabel.Name = "ProgamNameLabel";
            this.ProgamNameLabel.Size = new System.Drawing.Size(95, 44);
            this.ProgamNameLabel.TabIndex = 4;
            this.ProgamNameLabel.Text = "ETA ";
            // 
            // ProgramNameExplLabel
            // 
            this.ProgramNameExplLabel.AutoSize = true;
            this.ProgramNameExplLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramNameExplLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ProgramNameExplLabel.Location = new System.Drawing.Point(15, 67);
            this.ProgramNameExplLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProgramNameExplLabel.Name = "ProgramNameExplLabel";
            this.ProgramNameExplLabel.Size = new System.Drawing.Size(268, 19);
            this.ProgramNameExplLabel.TabIndex = 5;
            this.ProgramNameExplLabel.Text = "(electronic table analizator)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(346, 367);
            this.Controls.Add(this.ProgramNameExplLabel);
            this.Controls.Add(this.ProgamNameLabel);
            this.Controls.Add(this.WhoLabel);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.OpenFileLabel);
            this.Controls.Add(this.NewFileLabel);
            this.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NewFileLabel;
        private Label OpenFileLabel;
        private Label ExitLabel;
        private Label WhoLabel;
        private Label ProgamNameLabel;
        private Label ProgramNameExplLabel;
    }
}