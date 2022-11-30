using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelLite.Forms
{
    public partial class ConfirmationForm : Form
    {
        public static bool result;

        public ConfirmationForm(string action)
        {
            InitializeComponent();
            result = false;
            MessageLabel.Text = "Підтвердити дію:\n" + action + "?";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            result = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            result= false;
            Close();
        }
    }
}
