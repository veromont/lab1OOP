using ExcelLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExcelLite
{
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
            Pathtxtbox.Text = "C:\\Users\\Dima\\source\\Components\\lab1oop";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //get path
            string path = Pathtxtbox.Text + @"\" + Nametxtbox.Text.ToString() + ".txt";

            //read file
            FileReader.Path = path;
            FileReader.ReadContents();
            FileReader.DecipherContents();

            //open table
            GridViewForm gridTable = new GridViewForm();
            gridTable.ShowDialog();
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
