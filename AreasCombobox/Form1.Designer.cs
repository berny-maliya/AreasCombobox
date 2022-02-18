namespace AreasCombobox
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
            this.label1 = new System.Windows.Forms.Label();
            this.figurasCheckbox = new System.Windows.Forms.ComboBox();
            this.aceptarBoton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.TextBox();
            this.calcularBoton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.limpiarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Figura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // figurasCheckbox
            // 
            this.figurasCheckbox.FormattingEnabled = true;
            this.figurasCheckbox.Items.AddRange(new object[] {
            "Triangulo",
            "Rectangulo",
            "Circulo"});
            this.figurasCheckbox.Location = new System.Drawing.Point(116, 39);
            this.figurasCheckbox.Name = "figurasCheckbox";
            this.figurasCheckbox.Size = new System.Drawing.Size(121, 21);
            this.figurasCheckbox.TabIndex = 1;
            this.figurasCheckbox.SelectedIndexChanged += new System.EventHandler(this.figurasCheckbox_SelectedIndexChanged);
            // 
            // aceptarBoton
            // 
            this.aceptarBoton.Location = new System.Drawing.Point(284, 39);
            this.aceptarBoton.Name = "aceptarBoton";
            this.aceptarBoton.Size = new System.Drawing.Size(75, 23);
            this.aceptarBoton.TabIndex = 2;
            this.aceptarBoton.Text = "Aceptar";
            this.aceptarBoton.UseVisualStyleBackColor = true;
            this.aceptarBoton.Click += new System.EventHandler(this.aceptarBoton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // b
            // 
            this.b.Enabled = false;
            this.b.Location = new System.Drawing.Point(116, 134);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altura";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // h
            // 
            this.h.Enabled = false;
            this.h.Location = new System.Drawing.Point(296, 130);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(100, 20);
            this.h.TabIndex = 6;
            this.h.TextChanged += new System.EventHandler(this.h_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radio";
            // 
            // r
            // 
            this.r.Enabled = false;
            this.r.Location = new System.Drawing.Point(116, 191);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(100, 20);
            this.r.TabIndex = 8;
            // 
            // calcularBoton
            // 
            this.calcularBoton.Location = new System.Drawing.Point(296, 191);
            this.calcularBoton.Name = "calcularBoton";
            this.calcularBoton.Size = new System.Drawing.Size(75, 23);
            this.calcularBoton.TabIndex = 9;
            this.calcularBoton.Text = "Calcular";
            this.calcularBoton.UseVisualStyleBackColor = true;
            this.calcularBoton.Click += new System.EventHandler(this.calcularBoton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(116, 246);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 11;
            // 
            // limpiarBoton
            // 
            this.limpiarBoton.Location = new System.Drawing.Point(296, 242);
            this.limpiarBoton.Name = "limpiarBoton";
            this.limpiarBoton.Size = new System.Drawing.Size(75, 23);
            this.limpiarBoton.TabIndex = 12;
            this.limpiarBoton.Text = "Limpiar";
            this.limpiarBoton.UseVisualStyleBackColor = true;
            this.limpiarBoton.Click += new System.EventHandler(this.limpiarBoton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limpiarBoton);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcularBoton);
            this.Controls.Add(this.r);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.h);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aceptarBoton);
            this.Controls.Add(this.figurasCheckbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Area";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox figurasCheckbox;
        private System.Windows.Forms.Button aceptarBoton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.Button calcularBoton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button limpiarBoton;
    }
}

