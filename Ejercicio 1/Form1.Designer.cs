namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVer = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbVer = new System.Windows.Forms.ListBox();
            this.btnIEmpleados = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Enabled = false;
            this.btnVer.Location = new System.Drawing.Point(775, 14);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(193, 48);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Ver lista";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbVer
            // 
            this.lbVer.FormattingEnabled = true;
            this.lbVer.ItemHeight = 15;
            this.lbVer.Location = new System.Drawing.Point(16, 14);
            this.lbVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(724, 484);
            this.lbVer.TabIndex = 1;
            // 
            // btnIEmpleados
            // 
            this.btnIEmpleados.Location = new System.Drawing.Point(773, 83);
            this.btnIEmpleados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIEmpleados.Name = "btnIEmpleados";
            this.btnIEmpleados.Size = new System.Drawing.Size(193, 48);
            this.btnIEmpleados.TabIndex = 2;
            this.btnIEmpleados.Text = "Importar empleados";
            this.btnIEmpleados.UseVisualStyleBackColor = true;
            this.btnIEmpleados.Click += new System.EventHandler(this.btnIEmpleados_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(773, 153);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(193, 48);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Importar empleados";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnIEmpleados);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.btnVer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Empresa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbVer;
        private System.Windows.Forms.Button btnIEmpleados;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button button1;
    }
}

