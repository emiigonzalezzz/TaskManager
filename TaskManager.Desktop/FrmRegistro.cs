using System.ComponentModel;
using Task.Entities;
using TaskManager.Desktop.Helpers;
namespace TaskManager.Desktop
{
    public partial class FrmRegistro : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Cuenta NuevaCuenta  { get; set; }

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            NuevaCuenta
                 = new Cuenta()
                 {
                     Owner = new Administrador()
                     {
                         Nombre = txtNombre.Text,
                         Email = txtEmail.Text,
                         Password = txtPassword.Text
                     },
                     TipoCuenta = TipoCuenta.Personal
                 };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool IsValidForm()
        {
            int errorCount = 0;
            if (!ValidatorHelper.IsValidRequieredTextBox(txtPassword, "Contraseña"))
                errorCount++;
            if (!ValidatorHelper.IsValidRequieredTextBox(txtEmail, "E-mail"))
                errorCount++;
            if (!ValidatorHelper.IsValidRequieredTextBox(txtNombre, "Nombre"))
                errorCount++;
            return errorCount == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
