using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Desktop.Helpers
{
    internal class ValidatorHelper
    {
        internal static bool IsValidRequieredTextBox(TextBox textBox, string campoValidado)
        {
            if(string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"El campo de {campoValidado} es obligatorio.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
