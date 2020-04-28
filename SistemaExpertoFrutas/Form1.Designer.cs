namespace SistemaExpertoFrutas
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
            this.panelFruta = new System.Windows.Forms.Panel();
            this.labelFruta = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.cbAcido = new System.Windows.Forms.ComboBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.cbColores = new System.Windows.Forms.ComboBox();
            this.cbPiedra = new System.Windows.Forms.ComboBox();
            this.cbTallo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFruta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFruta
            // 
            this.panelFruta.BackColor = System.Drawing.Color.White;
            this.panelFruta.Controls.Add(this.panel2);
            this.panelFruta.Controls.Add(this.labelFruta);
            this.panelFruta.Controls.Add(this.pbImagen);
            this.panelFruta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFruta.Location = new System.Drawing.Point(0, 0);
            this.panelFruta.Name = "panelFruta";
            this.panelFruta.Size = new System.Drawing.Size(388, 452);
            this.panelFruta.TabIndex = 4;
            // 
            // labelFruta
            // 
            this.labelFruta.AutoSize = true;
            this.labelFruta.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFruta.Location = new System.Drawing.Point(152, 398);
            this.labelFruta.Name = "labelFruta";
            this.labelFruta.Size = new System.Drawing.Size(77, 29);
            this.labelFruta.TabIndex = 3;
            this.labelFruta.Text = "Fruta:";
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(23, 60);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(350, 335);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // cbAcido
            // 
            this.cbAcido.BackColor = System.Drawing.Color.White;
            this.cbAcido.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbAcido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAcido.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cbAcido.FormattingEnabled = true;
            this.cbAcido.Items.AddRange(new object[] {
            "ACIDO",
            "si",
            "no"});
            this.cbAcido.Location = new System.Drawing.Point(92, 159);
            this.cbAcido.Name = "cbAcido";
            this.cbAcido.Size = new System.Drawing.Size(205, 26);
            this.cbAcido.TabIndex = 3;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.White;
            this.panelOpciones.Controls.Add(this.btnAdivinar);
            this.panelOpciones.Controls.Add(this.cbForma);
            this.panelOpciones.Controls.Add(this.cbColores);
            this.panelOpciones.Controls.Add(this.cbPiedra);
            this.panelOpciones.Controls.Add(this.cbAcido);
            this.panelOpciones.Controls.Add(this.cbTallo);
            this.panelOpciones.Controls.Add(this.button2);
            this.panelOpciones.Controls.Add(this.button3);
            this.panelOpciones.Controls.Add(this.button4);
            this.panelOpciones.Controls.Add(this.button5);
            this.panelOpciones.Controls.Add(this.button1);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 452);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(388, 261);
            this.panelOpciones.TabIndex = 5;
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(8)))));
            this.btnAdivinar.FlatAppearance.BorderSize = 0;
            this.btnAdivinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinar.ForeColor = System.Drawing.Color.White;
            this.btnAdivinar.Location = new System.Drawing.Point(92, 200);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(205, 37);
            this.btnAdivinar.TabIndex = 7;
            this.btnAdivinar.Text = "Adivinar";
            this.btnAdivinar.UseVisualStyleBackColor = false;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // cbForma
            // 
            this.cbForma.BackColor = System.Drawing.Color.White;
            this.cbForma.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbForma.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbForma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "FORMAS",
            "creciente",
            "esfera",
            "esfera conica",
            "esfera aplanada"});
            this.cbForma.Location = new System.Drawing.Point(92, 11);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(205, 26);
            this.cbForma.TabIndex = 6;
            // 
            // cbColores
            // 
            this.cbColores.BackColor = System.Drawing.Color.White;
            this.cbColores.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColores.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cbColores.FormattingEnabled = true;
            this.cbColores.Items.AddRange(new object[] {
            "COLORES",
            "amarillo",
            "verde",
            "rojo",
            "morado",
            "naranja"});
            this.cbColores.Location = new System.Drawing.Point(92, 48);
            this.cbColores.Name = "cbColores";
            this.cbColores.Size = new System.Drawing.Size(205, 26);
            this.cbColores.TabIndex = 5;
            // 
            // cbPiedra
            // 
            this.cbPiedra.BackColor = System.Drawing.Color.White;
            this.cbPiedra.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbPiedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPiedra.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPiedra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cbPiedra.FormattingEnabled = true;
            this.cbPiedra.Items.AddRange(new object[] {
            "PIEDRA",
            "si",
            "no"});
            this.cbPiedra.Location = new System.Drawing.Point(92, 85);
            this.cbPiedra.Name = "cbPiedra";
            this.cbPiedra.Size = new System.Drawing.Size(205, 26);
            this.cbPiedra.TabIndex = 4;
            // 
            // cbTallo
            // 
            this.cbTallo.BackColor = System.Drawing.Color.White;
            this.cbTallo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTallo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTallo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTallo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTallo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cbTallo.FormattingEnabled = true;
            this.cbTallo.Items.AddRange(new object[] {
            "TALLO",
            "si",
            "no"});
            this.cbTallo.Location = new System.Drawing.Point(92, 122);
            this.cbTallo.Name = "cbTallo";
            this.cbTallo.Size = new System.Drawing.Size(205, 26);
            this.cbTallo.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 2);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(8)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 52);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sistema Experto Frutas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(91, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 29);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(91, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 29);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(91, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 29);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(91, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 29);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(91, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 29);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelFruta);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Experto Frutas";
            this.panelFruta.ResumeLayout(false);
            this.panelFruta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFruta;
        private System.Windows.Forms.ComboBox cbAcido;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.ComboBox cbForma;
        private System.Windows.Forms.ComboBox cbColores;
        private System.Windows.Forms.ComboBox cbPiedra;
        private System.Windows.Forms.ComboBox cbTallo;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Label labelFruta;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}

