using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * It is a class that has easy-to-use functions for manipulations with table 
 * It was created for my convinience and also to decrease importance of GridViewForm and Table class
 * before TableManager they had too many unrelated and complex methods for changing table.
 * However, with time table manager grew larger and larger and now this class has a LOT of barely related methods
 * probably a God object, but tbh I don`t care at this point)
 */

namespace ExcelLite
{
    internal class TableManager
    {
        public Table Tab;

        //constructor
        public TableManager(Table t)
        {
            Tab = t;
            AdoptAllCells();
        }

        // public methods
        public void AddRow(int RowNumber,int cols)
        {
            Tab.AddNewRow(RowNumber,cols);
        }
        public void AddCol(int rows,int ColNumber)
        {
            Tab.AddNewCol(rows, ColNumber);
        }
        public bool DeleteRow(int row) 
        {
            //check
            foreach (Cell cell in Tab.Rows[row])
            {
                if (cell.ChildCells.Count > 0)
                {
                    return false;
                }
            }

            //delete
            Tab.Rows.Remove(row);

            //change keys
            for (int i = row; i <= Tab.Rows.Count; i++)
            {
                var value = Tab.Rows[i+1];
                Tab.Rows.Remove(i + 1);
                Tab.Rows.Add(i,value);
            }
            return true;
        }
        public bool DeleteCol(int col) 
        {
            //check
            foreach (var row in Tab.Rows)
            {
                if (row.Value[col].ChildCells.Count > 0)
                {
                    return false;
                }
            }

            //delete
            foreach (var row in Tab.Rows)
            {
                row.Value.RemoveAt(col);

                //rename cells if they exist, else expected exeption outofrange
                try
                {
                    for (int i = col; i < Tab.Rows[1].Count; i++)   //1 is random ELIGIBLE number
                    {
                        Tab.Rows[row.Key][i].Name = Converter.ConvertToLongString(i + 1) + row.Key;
                    }
                }
                //this exeption is ok, it just means that it`s not necessary to rename anything
                catch (ArgumentOutOfRangeException){}
            }
            return true;
        }
        public Cell GetCell(string CellName)
        {
            Cell? result = NameCellSearch(CellName);
            if (result == null)
            {
                //return default value
                return Tab.Rows[1][0];
            }
            return result;
        }
        public Cell GetCell(int row, int col)
        {
            Cell? result = OptimisedCellSearch(col, row);
            if (result == null)
            {
                //return default value
                return Tab.Rows[1][0];
            }
            return result;
        }
        public void AdoptCell(Cell child)
        {
            //foreach parent approve adoption
            foreach (var row in Tab.Rows)
            {
                foreach (Cell parent in row.Value)
                {
                    if (child.Formula.Contains(parent.Name)) 
                    { 
                        if (!ApproveAdoption(parent,child))
                        {
                            MessageBox.Show("Десь у формулі має місце рекурсія, приберіть її будь ласка");
                            return;
                        }

                    }
                }
            }

            //foreach parent adopt
            foreach (var row in Tab.Rows)
            {
                foreach (Cell parent in row.Value)
                {
                    if (child.Formula.Contains(parent.Name)) { parent.ChildCells.Add(child); }
                }
            }
        }

        //private methods
        public void CalculateEverything()
        {
            foreach(var row in Tab.Rows)
            {
                foreach (Cell cell in row.Value)
                {
                    cell.EvaluateFormula();
                }
            }
        }
        private Cell? OptimisedCellSearch(int col, int row)
        {
            Cell Result;
            try
            {
                Result = Tab.Rows[row][col];
            }
            catch
            {
                return null;
            }
            return Result;
        }
        private Cell? NameCellSearch(string cellName)
        {
            Cell Result;
            for (int i = 1; i <= Tab.Rows.Count; i++)
            {
                var ResultCell = from Cell cell in Tab.Rows[i] where cell.Name == cellName select cell;
                if (ResultCell.Count() != 0)
                {
                    Result = ResultCell.First();
                    return Result;
                }
            }
            return null;
        }
        private void AdoptAllCells()
        {
            foreach (var row in Tab.Rows)
            {
                foreach (Cell c in row.Value)
                {
                    if (c.Formula != null && c.Formula != "")
                    {
                        AdoptCell(c);
                    }
                }
            }
        }
        private bool ApproveAdoption(Cell Parent, Cell Child)
        {
            //same cells
            if (Child.Name == Parent.Name)
            {
                return false;
            }

            //childless cell
            if (Child.ChildCells.Count == 0)
            {
                return true;
            }
            foreach (Cell GrandChild in Child.ChildCells)
            {
                if (!ApproveAdoption(Parent, GrandChild))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
