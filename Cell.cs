using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLite
{
    internal class Cell
    {
        public string Name { get; set; }
        public double Value { get; private set; }
        public string Formula { get; private set; }
        public bool Calculable;
        public List<Cell> ChildCells;

        //private functions (check-functions mostly)
        private bool FormulaIsCalculable(string formula)
        {
            //formula exists
            if (formula == null || formula.Length == 0)
            {
                return false;
            }

            //ensures that formula starts with = and has some information in it
            if (!(formula[0] == '='))
            {
                return false;
            }

            //removes =
            formula = formula.Substring(1);
            if (formula == null || formula.Length == 0)
            {
                return false;
            }

            return true;
        }

        //public interactions
        public Cell(int r,int c)
        {
            Name = Converter.ConvertToLongString(c) + r.ToString();
            Value = 0;
            Formula = "";
            ChildCells = new List<Cell>();
        }
        public void SetFormula(string formula)
        {
            //for reading from file
            if (formula == ""|| formula == null) { return; }

            //check if formula, else not calculable value
            if (!FormulaIsCalculable(formula))
            {
                formula = formula.Replace("@", "(a)");
                Formula = formula;
                return;

            }

            //removes ' '
            formula = formula.Replace(" ", "");

            //setting itself
            Formula = formula;
        }
        public void EvaluateFormula()
        {
            //evaluate
            if (!FormulaIsCalculable(Formula)){ Calculable = false; Value = 0; return; }
            Calculable = true;
            string formula = Formula.Substring(1);

            //continue even after not eligible formula value
            try
            {
                Value = Calculator.Calculator.Evaluate(formula);
            }
            catch
            {
                MessageBox.Show("Ми не змогли обчислити вираз:\n" + formula);
                Formula = "";
            }
            
            //update child cells
            foreach (Cell cell in ChildCells) { cell.EvaluateFormula(); }
        }
    }
}
