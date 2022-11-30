using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLite
{
    internal class FileWriter
    {
        public static Table Tab;
        public static string? Path 
        {
            get
            {
                return path;
            }
            set
            {
                try
                {
                    path = value;
                    FileStream fs = new FileStream(Path,FileMode.Create);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    path = null;
                    MessageBox.Show(ex.Message);
                }
            } 
        }
        static string? path;
        public static void WriteToFile()
        {
            try
            {
                string text = TranslateFromTable();
                File.WriteAllText(Path, text);
                MessageBox.Show("Збережено успішно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static string TranslateFromTable()
        {
            string TextToFile = "";
            foreach (KeyValuePair<int, List<Cell>> RowPair in Tab.Rows)
            {
                List<Cell> Row = RowPair.Value;
                foreach (Cell cell in Row)
                {
                    TextToFile += cell.Formula + "@";
                }
                TextToFile += "\n";
            }
            return TextToFile;
        }
    }
}
