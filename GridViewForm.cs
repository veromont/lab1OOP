using ExcelLite.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExcelLite
{
    public partial class GridViewForm : Form
    {
        TableManager Table;
        Cell CurrentCell;
        public GridViewForm()
        {
            InitializeComponent();

            //new table
            if (FileReader.Tab == null)
            {
                MessageBox.Show("Створено нову таблицю");
                
                NewGridForm();
                
                Table = new TableManager(NewTable(GridView));
                ColCountLabel.Text = "Кількість стовпчиків: " + GridView.ColumnCount;
                RowCountLabel.Text = "Кількість рядків: " + GridView.RowCount;
            }

            //open table
            else
            {
                Table T = FileReader.Tab;

                //initialize gridview from reader.table
                GridViewByTable(T);
                
                //initialize table from reader.table
                Table = new TableManager(T);
                
                UpdateAntlrStorage();
                Table.CalculateEverything();
                DisplayTable();                
            }
            CurrentCell = Table.GetCell("A1");
        }


        #region initialization methods
        void NewGridForm()
        {
            //added by hand
            const int AddedColumns = 0;

            //how many to initialize
            int RowCount = 10;
            int ColumnCount = 10;

            //adding
            for (int i = AddedColumns; i < ColumnCount; i++)
            {
                string ColumnName = Converter.ConvertToLongString(i + 1);
                GridView.Columns.Add(ColumnName, ColumnName);
            }
            for (int i = 0; i < RowCount; i++)
            {
                GridView.Rows.Add();
                GridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            GridView.Rows[RowCount].HeaderCell.Value = (RowCount + 1).ToString();
        }
        Table NewTable(DataGridView GridView)
        {
            Table Result = new Table();
            for (int i = 1; i <= GridView.Rows.Count; i++)
            {
                Result.AddNewRow(i, GridView.Columns.Count);
            }
            return Result;
        }
        void GridViewByTable(Table Tab)
        {
            //how many to initialize
            int rows = Tab.Rows.Count;
            int cols = Tab.Rows[1].Count;

            for (int i = 1; i < cols; i++)
            {
                string colname = Converter.ConvertToLongString(i);
                GridView.Columns.Add(colname, colname);
            }
            for (int i = 1; i < rows; i++)
            {
                GridView.Rows.Add();
                GridView.Rows[i - 1].HeaderCell.Value = (i).ToString();
            }
            GridView.Rows[GridView.Rows.Count - 1].HeaderCell.Value = (GridView.Rows.Count).ToString();
        }
        #endregion

        #region other methods
        private void ChangeColors()
        {
            for (int i = 0; i < GridView.Rows.Count; i++)
            {
                foreach (DataGridViewCell cell in GridView.Rows[i].Cells)
                {
                    //
                    int row = cell.RowIndex + 1;
                    int col = cell.ColumnIndex;

                    //
                    Cell tempcell = Table.GetCell(row, col);

                    //
                    if (!tempcell.Calculable) { if (tempcell.Formula != "" && tempcell.Formula != null) { cell.Style.BackColor = Color.LightCyan; } }
                    else 
                    { 
                        if (tempcell.Value >= 0)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.Pink;
                        }
                    }


                    //
                }
            }
        }
        private void DisplayTable()
        {
            //
            for (int i = 0; i < GridView.Rows.Count; i++)
            {
                foreach (DataGridViewCell cell in GridView.Rows[i].Cells)
                {
                    //
                    int row = cell.RowIndex + 1;
                    int col = cell.ColumnIndex;

                    //
                    Cell tempcell = Table.GetCell(row, col);

                    //
                    tempcell.EvaluateFormula();

                    //
                    if (tempcell.Calculable) {  cell.Value = tempcell.Value; }
                    else { cell.Value = tempcell.Formula; }
                }
            }

            //
            if (ColorCheckbox.Checked)
            {
                ChangeColors();
            }

            //
            ColCountLabel.Text = "Кількість стовпчиків: " + GridView.ColumnCount;
            RowCountLabel.Text = "Кількість рядків: " + GridView.RowCount;
        }
        private void UpdateAntlrStorage()
        {
            //update storage
            TableStorage.Table = Table;
        }
        private void RefreshGridView()
        {
            //delete gridview
            GridView.Rows.Clear();
            GridView.Columns.Clear();

            //display new gridform
            GridViewByTable(Table.Tab);

            //display new table
            DisplayTable();
        }
        
        void AddRow()
        {
            //add new row
            GridView.Rows.Add();
            int lastRowIndex = GridView.Rows.Count - 1;
            int lastRowCount = GridView.Rows.Count;
            Table.AddRow(lastRowCount,GridView.Columns.Count);

            //change headers look
            GridView.Rows[lastRowIndex - 1].HeaderCell.Value = (lastRowCount - 1).ToString();
            GridView.Rows[lastRowIndex].HeaderCell.Value = (lastRowCount).ToString();
        }
        void AddCol()
        {
            int colcount = GridView.Columns.Count + 1;
            string ColumnName = Converter.ConvertToLongString(colcount);
            if (ColumnName == "") { return; }

            //i don`t know why but it`s neccessary
            colcount++;

            //Add a col to GridView and table
            GridView.Columns.Add(ColumnName,ColumnName);
            Table.AddCol(GridView.RowCount, colcount);
        }
        void DelRow()
        {
            int row = GridView.CurrentCell.RowIndex + 1;
            if(!Table.DeleteRow(row))
            {
                MessageBox.Show("Неможливо видалити стовпчик, деякі рядки мають посилання на клітинки з нього");
            }

            RefreshGridView();
        }
        void DelCol()
        {
            int column = GridView.CurrentCell.ColumnIndex;
            if (!Table.DeleteCol(column))
            {
                MessageBox.Show("Неможливо видалити стовпчик, деякі рядки мають посилання на клітинки з нього");
            }

            RefreshGridView();
        }
        #endregion

        #region on click
        private void AddRowButton_Click(object sender, EventArgs e)
        {
            AddRow();
            DisplayTable();
        }
        private void AddColButton_Click(object sender, EventArgs e)
        {
            AddCol();
            DisplayTable();
        }
        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (!Confirmator.Confirm("Видалити рядок")) { return; }
            DelRow();
        }
        private void DeleteColButton_Click(object sender, EventArgs e)
        {
            if (!Confirmator.Confirm("Видалити стовпчик")) { return; }
            DelCol();
        }
        
        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = GridView.CurrentCell.RowIndex + 1;
                int col = GridView.CurrentCell.ColumnIndex;
                CurrentCell = Table.GetCell(row, col);
                CurrentCellLabel.Text = "Поточна комірка: " + CurrentCell.Name;
                FormulaTextBox.Text = CurrentCell.Formula;  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(!Confirmator.Confirm("Зберегти зміни у тому ж файлі"))
            {
                SaveFileForm saveFileForm = new SaveFileForm(Table.Tab);
                saveFileForm.ShowDialog();
            }
            else
            {
                FileWriter.Path = FileReader.Path;
                FileWriter.Tab = Table.Tab;
                FileWriter.WriteToFile();
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //set cell formula
            string formula = FormulaTextBox.Text;
            CurrentCell.SetFormula(formula);

            //adopt current cell
            Table.AdoptCell(CurrentCell);

            //calculate new cell value if calculable
            CurrentCell.EvaluateFormula();

            //display new table
            DisplayTable();

            //update antlr table storage
            UpdateAntlrStorage();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (Confirmator.Confirm("Зберегти зміни перед виходом")) { SaveButton_Click(sender,e); return; }
            TableStorage.Table = null;
            FileReader.Tab = null;
            Close();
        }
        private void ColorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGridView();
        }
        #endregion
    }
}
