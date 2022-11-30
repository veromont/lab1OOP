using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLite
{
    internal class FileReader
    {
        public static Table? Tab 
        {
            get
            {
                if (_Tab == null) { return null; }
                else { return _Tab; }
            }
            set { _Tab = value; } 
        }
        private static Table? _Tab;
        public static string Path 
        {
            get
            {
                //default value
                if (path == null)
                {
                    return "C:\\Users\\Dima\\source\\Components\\lab1oop\\example.txt";
                }
                else
                {
                    return path;
                }
            } 
            set
            {
                if (ChangePath(value)) { path = value; }
                else { MessageBox.Show("Некоректно введений шлях до файлу, ми використали:\n" + Path); }
            }
        }
        private static string? path = null;

        private static string? content;

        //methods
        private static bool ChangePath(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                fs.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static void ReadContents()
        {
            FileStream fs = new FileStream(Path, FileMode.Open);
            using (var reader = new StreamReader(fs))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    content += line + '\n';
                }
            }
            fs.Close();
        }
        public static bool DecipherContents()
        {
            if (content == null) { return false; }

            var rows = content.Split('\n');
            if (rows.Length == 0) { return false; }

            _Tab = new Table(rows);
            
            //clear read information
            content = null;
            return true;
        }
    }
}
