namespace TaskManager.Desktop
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            toolStrip1 = new ToolStrip();
            btnCerrarAplicacion = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCerrarAplicacion });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(842, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCerrarAplicacion
            // 
            btnCerrarAplicacion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCerrarAplicacion.Image = (Image)resources.GetObject("btnCerrarAplicacion.Image");
            btnCerrarAplicacion.ImageTransparentColor = Color.Magenta;
            btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            btnCerrarAplicacion.Size = new Size(29, 24);
            btnCerrarAplicacion.Text = "Cerrar aplicacion";
            btnCerrarAplicacion.Click += btnCerrarAplicacion_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 454);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCerrarAplicacion;
    }
}