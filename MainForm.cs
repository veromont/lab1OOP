namespace ExcelLite
{
    public partial class MainForm : Form
    {
        //colors
        Color Blue = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(175)))));
        Color Default = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        public MainForm()
        {
            InitializeComponent();
        }

        #region onclick
        //TODO:difference between create and open
        private void NewFileLabel_Click(object sender, EventArgs e)
        {
            GridViewForm gridTable = new GridViewForm();
            gridTable.ShowDialog();
        }

        private void OpenFileLabel_Click(object sender, EventArgs e)
        {
            OpenForm pathForm = new OpenForm();
            pathForm.ShowDialog();
        }

        private void WhoLabel_Click(object sender, EventArgs e)
        {
            WhoForm whoForm = new WhoForm();
            whoForm.ShowDialog();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region on hover
        private void NewFileLabel_Hover(object sender, EventArgs e)
        {
            NewFileLabel.Text = ">Нова таблиця<";
            NewFileLabel.ForeColor = Blue;
        }
        private void NewFileLabel_Leave(object sender, EventArgs e)
        {
            NewFileLabel.Text = "  Нова таблиця";
            NewFileLabel.ForeColor = Default;
        }
        private void OpenFileLabel_Hover(object sender, EventArgs e)
        {
            OpenFileLabel.Text = ">Відкрити таблицю<";
            OpenFileLabel.ForeColor = Blue;
        }
        private void OpenFileLabel_Leave(object sender, EventArgs e)
        {
            OpenFileLabel.Text = " Відкрити таблицю";
            OpenFileLabel.ForeColor = Default;
        }
        private void WhoLabel_Hover(object sender, EventArgs e)
        {
            WhoLabel.Text = ">Про програму<";
            WhoLabel.ForeColor = Blue;
        }
        private void WhoLabel_Leave(object sender, EventArgs e)
        {
            WhoLabel.Text = " Про програму";
            WhoLabel.ForeColor = Default;
        }
        private void ExitLabel_Hover(object sender, EventArgs e)
        {
            ExitLabel.Text = ">Вихід<";
            ExitLabel.ForeColor = Blue;
        }
        private void ExitLabel_Leave(object sender, EventArgs e)
        {
            ExitLabel.Text = " Вихід";
            ExitLabel.ForeColor= Default;
        }
        #endregion
    }
}