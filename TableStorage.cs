using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//(This class is created solely for providing access to the table for antlr calculator. You see, it cannot access)
//(GridView table manager directly, so every time gridviews table changes, it copies those changes here.)

namespace ExcelLite
{
    internal class TableStorage
    {
        public static TableManager? Table = null;
    }
}
