namespace UIDirectorioDePerros
{
    partial class VentanaPrincipal
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDuenio = new System.Windows.Forms.Button();
            this.btnAgregarPerro = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(137, 72);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(591, 294);
            this.panelPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al Directorio de Perros\r\n";
            // 
            // btnAgregarDuenio
            // 
            this.btnAgregarDuenio.Location = new System.Drawing.Point(18, 100);
            this.btnAgregarDuenio.Name = "btnAgregarDuenio";
            this.btnAgregarDuenio.Size = new System.Drawing.Size(93, 44);
            this.btnAgregarDuenio.TabIndex = 2;
            this.btnAgregarDuenio.Text = "Agregar Duenio";
            this.btnAgregarDuenio.UseVisualStyleBackColor = true;
            this.btnAgregarDuenio.Click += new System.EventHandler(this.btnAgregarDuenio_Click);
            // 
            // btnAgregarPerro
            // 
            this.btnAgregarPerro.Location = new System.Drawing.Point(18, 166);
            this.btnAgregarPerro.Name = "btnAgregarPerro";
            this.btnAgregarPerro.Size = new System.Drawing.Size(93, 50);
            this.btnAgregarPerro.TabIndex = 3;
            this.btnAgregarPerro.Text = "Agregar Perro";
            this.btnAgregarPerro.UseVisualStyleBackColor = true;
            this.btnAgregarPerro.Click += new System.EventHandler(this.btnAgregarPerro_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(18, 235);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(93, 53);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver Perros y Duenios";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 376);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAgregarPerro);
            this.Controls.Add(this.btnAgregarDuenio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentanaPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarDuenio;
        private System.Windows.Forms.Button btnAgregarPerro;
        private System.Windows.Forms.Button btnVer;
    }
}

