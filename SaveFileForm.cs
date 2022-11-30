using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelLite
{
    partial class SaveFileForm : Form
    {
        Table tab;
        public SaveFileForm(Table t)
        {
            InitializeComponent();
            Pathtxtbox.Text = "C:\\Users\\Dima\\source\\Components\\lab1oop";
            tab = t;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string path = Pathtxtbox.Text + @"\" + Nametxtbox.Text + ".txt";
            FileWriter.Path = path;
            FileWriter.Tab = tab;
            FileWriter.WriteToFile();
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
