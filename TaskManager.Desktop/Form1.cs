using Task.Entities;
using TaskManager.Desktop.Helpers;

namespace TaskManager.Desktop
{
    public partial class Form1 : Form
    {
        private List<Cuenta> _cuentasCreadas;
        public Form1()
        {
            InitializeComponent();
            _cuentasCreadas = new List<Cuenta>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;
            bool credencialesValidas = false;
            Cuenta miCuenta = null;
            foreach (var cuenta in _cuentasCreadas)
            {
                if(cuenta.Owner.Email == txtEmail.Text)
                {
                    if (cuenta.Owner.Password == txtPassword.Text)
                    {
                        credencialesValidas = true;
                        miCuenta = cuenta;
                    }
                }
            }
            if (credencialesValidas)
            {
                FrmMain frmMain = new FrmMain(miCuenta);
                frmMain.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            var result = frmRegistro.ShowDialog();
            if(frmRegistro.NuevaCuenta != null)
            {
                txtEmail.Text = frmRegistro.NuevaCuenta.Owner.Email;
                _cuentasCreadas.Add(frmRegistro.NuevaCuenta);
            }
        }
        private bool IsValidForm()
        {
            int errorCount = 0;
            if (!ValidatorHelper.IsValidRequieredTextBox(txtPassword, "Contraseña"))
                errorCount++;
            if (!ValidatorHelper.IsValidRequieredTextBox(txtEmail, "E-mail"))
                errorCount++;

                return errorCount == 0;
            }
        }


    }

