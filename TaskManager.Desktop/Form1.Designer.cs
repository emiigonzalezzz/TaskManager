namespace TaskManager.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblEmail = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnEntrar = new Button();
            linkRegistro = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(80, 215);
            button1.Name = "button1";
            button1.Size = new Size(155, 26);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(52, 50);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail(*):";
            lblEmail.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 116);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña(*):";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(80, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(343, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(80, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(343, 27);
            txtEmail.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(268, 215);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(155, 26);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(434, 306);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(113, 20);
            linkRegistro.TabIndex = 4;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "Crear mi cuenta";
            linkRegistro.LinkClicked += linkRegistro_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 357);
            Controls.Add(linkRegistro);
            Controls.Add(btnEntrar);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(lblEmail);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Label lblEmail;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnEntrar;
        private LinkLabel linkRegistro;
    }
}
