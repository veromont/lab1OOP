namespace ExcelLite
{
    partial class GridViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridViewForm));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.AddColButton = new System.Windows.Forms.Button();
            this.FormulaTextBox = new System.Windows.Forms.TextBox();
            this.FormulaLabel = new System.Windows.Forms.Label();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.DeleteColButton = new System.Windows.Forms.Button();
            this.CurrentCellLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.PictureBox();
            this.RowCountLabel = new System.Windows.Forms.Label();
            this.ColCountLabel = new System.Windows.Forms.Label();
            this.ColorCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.Gray;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 76);
            this.GridView.Name = "GridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.RowHeadersWidth = 60;
            this.GridView.RowTemplate.Height = 25;
            this.GridView.Size = new System.Drawing.Size(844, 362);
            this.GridView.TabIndex = 0;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRowButton.Location = new System.Drawing.Point(971, 12);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(23, 23);
            this.AddRowButton.TabIndex = 1;
            this.AddRowButton.Text = "+";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // AddColButton
            // 
            this.AddColButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddColButton.Location = new System.Drawing.Point(971, 37);
            this.AddColButton.Name = "AddColButton";
            this.AddColButton.Size = new System.Drawing.Size(22, 23);
            this.AddColButton.TabIndex = 2;
            this.AddColButton.Text = "+";
            this.AddColButton.UseVisualStyleBackColor = true;
            this.AddColButton.Click += new System.EventHandler(this.AddColButton_Click);
            // 
            // FormulaTextBox
            // 
            this.FormulaTextBox.Location = new System.Drawing.Point(166, 23);
            this.FormulaTextBox.Name = "FormulaTextBox";
            this.FormulaTextBox.Size = new System.Drawing.Size(133, 23);
            this.FormulaTextBox.TabIndex = 3;
            // 
            // FormulaLabel
            // 
            this.FormulaLabel.AutoSize = true;
            this.FormulaLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormulaLabel.Location = new System.Drawing.Point(12, 24);
            this.FormulaLabel.Name = "FormulaLabel";
            this.FormulaLabel.Size = new System.Drawing.Size(148, 20);
            this.FormulaLabel.TabIndex = 5;
            this.FormulaLabel.Text = "Формула комірки:";
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRowButton.Location = new System.Drawing.Point(861, 116);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(132, 23);
            this.DeleteRowButton.TabIndex = 6;
            this.DeleteRowButton.Text = "Видалити рядок";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // DeleteColButton
            // 
            this.DeleteColButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteColButton.Location = new System.Drawing.Point(861, 145);
            this.DeleteColButton.Name = "DeleteColButton";
            this.DeleteColButton.Size = new System.Drawing.Size(132, 23);
            this.DeleteColButton.TabIndex = 7;
            this.DeleteColButton.Text = "Видалити стовпчик";
            this.DeleteColButton.UseVisualStyleBackColor = true;
            this.DeleteColButton.Click += new System.EventHandler(this.DeleteColButton_Click);
            // 
            // CurrentCellLabel
            // 
            this.CurrentCellLabel.AutoSize = true;
            this.CurrentCellLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentCellLabel.Location = new System.Drawing.Point(453, 25);
            this.CurrentCellLabel.Name = "CurrentCellLabel";
            this.CurrentCellLabel.Size = new System.Drawing.Size(202, 23);
            this.CurrentCellLabel.TabIndex = 8;
            this.CurrentCellLabel.Text = "Поточна комірка: A1";
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(862, 174);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Зберегти";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(862, 203);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.Image = ((System.Drawing.Image)(resources.GetObject("SubmitButton.Image")));
            this.SubmitButton.Location = new System.Drawing.Point(314, 19);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(32, 28);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.TabStop = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RowCountLabel
            // 
            this.RowCountLabel.AutoSize = true;
            this.RowCountLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RowCountLabel.Location = new System.Drawing.Point(772, 16);
            this.RowCountLabel.Name = "RowCountLabel";
            this.RowCountLabel.Size = new System.Drawing.Size(49, 19);
            this.RowCountLabel.TabIndex = 13;
            this.RowCountLabel.Text = "label1";
            // 
            // ColCountLabel
            // 
            this.ColCountLabel.AutoSize = true;
            this.ColCountLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColCountLabel.Location = new System.Drawing.Point(769, 41);
            this.ColCountLabel.Name = "ColCountLabel";
            this.ColCountLabel.Size = new System.Drawing.Size(52, 19);
            this.ColCountLabel.TabIndex = 14;
            this.ColCountLabel.Text = "label2";
            // 
            // ColorCheckbox
            // 
            this.ColorCheckbox.AutoSize = true;
            this.ColorCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorCheckbox.Location = new System.Drawing.Point(862, 76);
            this.ColorCheckbox.Name = "ColorCheckbox";
            this.ColorCheckbox.Size = new System.Drawing.Size(140, 19);
            this.ColorCheckbox.TabIndex = 15;
            this.ColorCheckbox.Text = "Кольоровий режим";
            this.ColorCheckbox.UseVisualStyleBackColor = true;
            this.ColorCheckbox.CheckedChanged += new System.EventHandler(this.ColorCheckbox_CheckedChanged);
            // 
            // GridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.ColorCheckbox);
            this.Controls.Add(this.ColCountLabel);
            this.Controls.Add(this.RowCountLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CurrentCellLabel);
            this.Controls.Add(this.DeleteColButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.FormulaLabel);
            this.Controls.Add(this.FormulaTextBox);
            this.Controls.Add(this.AddColButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.GridView);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "GridViewForm";
            this.Text = "GridViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridView;
        private Button AddRowButton;
        private Button AddColButton;
        private TextBox FormulaTextBox;
        private Label FormulaLabel;
        private Button DeleteRowButton;
        private Button DeleteColButton;
        private Label CurrentCellLabel;
        private Button SaveButton;
        private Button ExitButton;
        private PictureBox SubmitButton;
        private Label RowCountLabel;
        private Label ColCountLabel;
        private CheckBox ColorCheckbox;
    }
}