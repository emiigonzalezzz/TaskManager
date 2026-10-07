namespace TaskManager.Desktop
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirmar = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            lblEmail = new Label();
            button1 = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(331, 253);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(155, 26);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(143, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(343, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(343, 27);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 154);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 8;
            label2.Text = "Contraseña(*):";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(115, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail(*):";
            // 
            // button1
            // 
            button1.Location = new Point(143, 253);
            button1.Name = "button1";
            button1.Size = new Size(155, 26);
            button1.TabIndex = 9;
            button1.Text = "S&alir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(143, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(343, 27);
            txtNombre.TabIndex = 10;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(115, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(150, 20);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Ingrese su nombre(*):";
            lblNombre.Click += label1_Click;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 334);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(lblEmail);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label2;
        private Label lblEmail;
        private Button button1;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}