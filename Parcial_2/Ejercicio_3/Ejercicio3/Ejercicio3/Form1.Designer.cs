
namespace Ejercicio3
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.dtgAlumnos = new System.Windows.Forms.DataGridView();
            this.btnApilar = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnVerTope = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(138, 58);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(48, 22);
            this.txtEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(91, 61);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 17);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(138, 86);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(89, 22);
            this.txtPromedio.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(71, 89);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(68, 17);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio";
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnos.Location = new System.Drawing.Point(58, 173);
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.RowHeadersWidth = 51;
            this.dtgAlumnos.RowTemplate.Height = 24;
            this.dtgAlumnos.Size = new System.Drawing.Size(769, 236);
            this.dtgAlumnos.TabIndex = 6;
            // 
            // btnApilar
            // 
            this.btnApilar.Location = new System.Drawing.Point(502, 33);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(143, 47);
            this.btnApilar.TabIndex = 7;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(684, 33);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(143, 47);
            this.btnDesapilar.TabIndex = 8;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnVerTope
            // 
            this.btnVerTope.Location = new System.Drawing.Point(881, 33);
            this.btnVerTope.Name = "btnVerTope";
            this.btnVerTope.Size = new System.Drawing.Size(143, 47);
            this.btnVerTope.TabIndex = 9;
            this.btnVerTope.Text = "Ver tope";
            this.btnVerTope.UseVisualStyleBackColor = true;
            this.btnVerTope.Click += new System.EventHandler(this.btnVerTope_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(1071, 33);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(143, 47);
            this.btnVaciar.TabIndex = 10;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 450);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnVerTope);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.dtgAlumnos);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridView dtgAlumnos;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnVerTope;
        private System.Windows.Forms.Button btnVaciar;
    }
}

