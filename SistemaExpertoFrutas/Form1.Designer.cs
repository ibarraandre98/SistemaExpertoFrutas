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
            this.cbAcido = new System.Windows.Forms.ComboBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.cbColores = new System.Windows.Forms.ComboBox();
            this.cbPiedra = new System.Windows.Forms.ComboBox();
            this.cbTallo = new System.Windows.Forms.ComboBox();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.labelFruta = new System.Windows.Forms.Label();
            this.panelFruta.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFruta
            // 
            this.panelFruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelFruta.Controls.Add(this.labelFruta);
            this.panelFruta.Controls.Add(this.pbImagen);
            this.panelFruta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFruta.Location = new System.Drawing.Point(0, 0);
            this.panelFruta.Name = "panelFruta";
            this.panelFruta.Size = new System.Drawing.Size(800, 374);
            this.panelFruta.TabIndex = 4;
            // 
            // cbAcido
            // 
            this.cbAcido.BackColor = System.Drawing.Color.White;
            this.cbAcido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAcido.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbAcido.FormattingEnabled = true;
            this.cbAcido.Items.AddRange(new object[] {
            "ACIDO",
            "si",
            "no"});
            this.cbAcido.Location = new System.Drawing.Point(359, 140);
            this.cbAcido.Name = "cbAcido";
            this.cbAcido.Size = new System.Drawing.Size(176, 26);
            this.cbAcido.TabIndex = 3;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.Lime;
            this.panelOpciones.Controls.Add(this.btnAdivinar);
            this.panelOpciones.Controls.Add(this.cbForma);
            this.panelOpciones.Controls.Add(this.cbColores);
            this.panelOpciones.Controls.Add(this.cbPiedra);
            this.panelOpciones.Controls.Add(this.cbAcido);
            this.panelOpciones.Controls.Add(this.cbTallo);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 374);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(800, 219);
            this.panelOpciones.TabIndex = 5;
            // 
            // cbForma
            // 
            this.cbForma.BackColor = System.Drawing.Color.White;
            this.cbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbForma.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbForma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "FORMAS",
            "creciente",
            "esfera",
            "esfera conica",
            "esfera aplanada"});
            this.cbForma.Location = new System.Drawing.Point(359, 12);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(176, 26);
            this.cbForma.TabIndex = 6;
            // 
            // cbColores
            // 
            this.cbColores.BackColor = System.Drawing.Color.White;
            this.cbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbColores.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbColores.FormattingEnabled = true;
            this.cbColores.Items.AddRange(new object[] {
            "COLORES",
            "amarillo",
            "verde",
            "rojo",
            "morado",
            "naranja",
            "durazno"});
            this.cbColores.Location = new System.Drawing.Point(359, 44);
            this.cbColores.Name = "cbColores";
            this.cbColores.Size = new System.Drawing.Size(176, 26);
            this.cbColores.TabIndex = 5;
            // 
            // cbPiedra
            // 
            this.cbPiedra.BackColor = System.Drawing.Color.White;
            this.cbPiedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiedra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPiedra.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPiedra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbPiedra.FormattingEnabled = true;
            this.cbPiedra.Items.AddRange(new object[] {
            "PIEDRA",
            "si",
            "no"});
            this.cbPiedra.Location = new System.Drawing.Point(359, 76);
            this.cbPiedra.Name = "cbPiedra";
            this.cbPiedra.Size = new System.Drawing.Size(176, 26);
            this.cbPiedra.TabIndex = 4;
            // 
            // cbTallo
            // 
            this.cbTallo.BackColor = System.Drawing.Color.White;
            this.cbTallo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTallo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTallo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTallo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbTallo.FormattingEnabled = true;
            this.cbTallo.Items.AddRange(new object[] {
            "TALLO",
            "si",
            "no"});
            this.cbTallo.Location = new System.Drawing.Point(359, 108);
            this.cbTallo.Name = "cbTallo";
            this.cbTallo.Size = new System.Drawing.Size(176, 26);
            this.cbTallo.TabIndex = 3;
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.Location = new System.Drawing.Point(413, 183);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(75, 23);
            this.btnAdivinar.TabIndex = 7;
            this.btnAdivinar.Text = "Adivinar";
            this.btnAdivinar.UseVisualStyleBackColor = true;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(303, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(300, 300);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // labelFruta
            // 
            this.labelFruta.AutoSize = true;
            this.labelFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFruta.Location = new System.Drawing.Point(414, 327);
            this.labelFruta.Name = "labelFruta";
            this.labelFruta.Size = new System.Drawing.Size(74, 25);
            this.labelFruta.TabIndex = 3;
            this.labelFruta.Text = "Fruta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelFruta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelFruta.ResumeLayout(false);
            this.panelFruta.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
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
    }
}

