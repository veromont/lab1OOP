using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLite
{
    partial class Table
    {
        public Dictionary<int, List<Cell>> Rows;
        
        //constructors
        public Table()
        {
            Rows = new Dictionary<int, List<Cell>>();
        }
        public Table(string[] rows)
        {
            Rows = new Dictionary<int, List<Cell>>();
            int rowCount = 1;
            foreach (string row in rows)
            {
                if (row == ""){  }
                else
                {
                    //split row into cells,last col is an odd one
                    var FormulasList = Converter.SplitRow(row);
                    int cols = FormulasList.Count - 1;

                    //error no cols in row
                    if (cols == 0) { Rows = new Dictionary<int, List<Cell>>(); return; }

                    //add this row
                    AddNewRow(rowCount, cols);

                    //initialize evry cell
                    for (int i = 0; i < cols; i++)
                    {
                        if (!(FormulasList[i] == ""))
                        {
                            Rows[rowCount][i].SetFormula(FormulasList[i]);
                        }
                    }
                    rowCount++;
                }
            }
        }

        //initialize new cells
        public void AddNewRow(int nOfAddedRow,int cols)
        {
            List<Cell> NewRow = new List<Cell>();
            for (int i = 1; i <= cols; i++)
            {
                Cell c = new Cell (nOfAddedRow,i);
                NewRow.Add(c);
            }
            Rows.Add(nOfAddedRow, NewRow);
        }
        public void AddNewCol(int rows,int currentColumn)
        {
            for (int i = 1; i <= rows; i++)
            {
                Cell NewCell = new Cell(i, currentColumn);
                Rows[i].Add(NewCell);
            }
        }
    }
}
