using ExcelLite.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLite
{
    internal class Confirmator
    {
        public static bool Confirm(string action)
        {
            ConfirmationForm conform = new ConfirmationForm(action);
            conform.ShowDialog();
            while (true)
            {
                if (Application.OpenForms.OfType<ConfirmationForm>().Count() == 0);
                {
                    break;
                }
            }
            return ConfirmationForm.result;
        }
    }
}
