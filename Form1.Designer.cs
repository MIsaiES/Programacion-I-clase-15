namespace Programacion_I_clase_15
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.Cargar = new System.Windows.Forms.Button();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Raza = new System.Windows.Forms.Label();
            this.label_Poder = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Raza = new System.Windows.Forms.TextBox();
            this.numericUpDown_Poder = new System.Windows.Forms.NumericUpDown();
            this.Insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Poder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(124, 212);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(566, 179);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(360, 131);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(75, 23);
            this.Cargar.TabIndex = 2;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(124, 54);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(16, 13);
            this.label_Id.TabIndex = 3;
            this.label_Id.Text = "Id";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(124, 87);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 4;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Raza
            // 
            this.label_Raza.AutoSize = true;
            this.label_Raza.Location = new System.Drawing.Point(127, 119);
            this.label_Raza.Name = "label_Raza";
            this.label_Raza.Size = new System.Drawing.Size(32, 13);
            this.label_Raza.TabIndex = 5;
            this.label_Raza.Text = "Raza";
            // 
            // label_Poder
            // 
            this.label_Poder.AutoSize = true;
            this.label_Poder.Location = new System.Drawing.Point(127, 153);
            this.label_Poder.Name = "label_Poder";
            this.label_Poder.Size = new System.Drawing.Size(35, 13);
            this.label_Poder.TabIndex = 6;
            this.label_Poder.Text = "Poder";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(188, 54);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 20);
            this.textBox_Id.TabIndex = 7;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(188, 84);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 8;
            // 
            // textBox_Raza
            // 
            this.textBox_Raza.Location = new System.Drawing.Point(188, 111);
            this.textBox_Raza.Name = "textBox_Raza";
            this.textBox_Raza.Size = new System.Drawing.Size(100, 20);
            this.textBox_Raza.TabIndex = 9;
            // 
            // numericUpDown_Poder
            // 
            this.numericUpDown_Poder.Location = new System.Drawing.Point(188, 153);
            this.numericUpDown_Poder.Name = "numericUpDown_Poder";
            this.numericUpDown_Poder.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Poder.TabIndex = 10;
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(203, 25);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(75, 23);
            this.Insertar.TabIndex = 11;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.numericUpDown_Poder);
            this.Controls.Add(this.textBox_Raza);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Poder);
            this.Controls.Add(this.label_Raza);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Poder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Raza;
        private System.Windows.Forms.Label label_Poder;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Raza;
        private System.Windows.Forms.NumericUpDown numericUpDown_Poder;
        private System.Windows.Forms.Button Insertar;
    }
}

