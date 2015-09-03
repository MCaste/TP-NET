namespace UI.Desktop
{
    partial class AlumnoInscripcionesDesktop
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
            this.lblIDInscripcion = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblIDAlumno = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.txtIDInscripcion = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.txtIDAlumno = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDInscripcion
            // 
            this.lblIDInscripcion.AutoSize = true;
            this.lblIDInscripcion.Location = new System.Drawing.Point(42, 48);
            this.lblIDInscripcion.Name = "lblIDInscripcion";
            this.lblIDInscripcion.Size = new System.Drawing.Size(72, 13);
            this.lblIDInscripcion.TabIndex = 0;
            this.lblIDInscripcion.Text = "ID Inscripcion";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(42, 74);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 1;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblIDAlumno
            // 
            this.lblIDAlumno.AutoSize = true;
            this.lblIDAlumno.Location = new System.Drawing.Point(42, 100);
            this.lblIDAlumno.Name = "lblIDAlumno";
            this.lblIDAlumno.Size = new System.Drawing.Size(56, 13);
            this.lblIDAlumno.TabIndex = 2;
            this.lblIDAlumno.Text = "ID Alumno";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(42, 152);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 3;
            this.lblCondicion.Text = "Condición";
            // 
            // txtIDInscripcion
            // 
            this.txtIDInscripcion.Location = new System.Drawing.Point(120, 41);
            this.txtIDInscripcion.Name = "txtIDInscripcion";
            this.txtIDInscripcion.ReadOnly = true;
            this.txtIDInscripcion.Size = new System.Drawing.Size(100, 20);
            this.txtIDInscripcion.TabIndex = 4;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(42, 126);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Location = new System.Drawing.Point(120, 67);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(100, 20);
            this.txtIDCurso.TabIndex = 6;
            // 
            // txtIDAlumno
            // 
            this.txtIDAlumno.Location = new System.Drawing.Point(120, 93);
            this.txtIDAlumno.Name = "txtIDAlumno";
            this.txtIDAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtIDAlumno.TabIndex = 7;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(120, 119);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 8;
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(120, 145);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(100, 20);
            this.txtCondicion.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(80, 189);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AlumnoInscripcionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 241);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtIDAlumno);
            this.Controls.Add(this.txtIDCurso);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtIDInscripcion);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblIDAlumno);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblIDInscripcion);
            this.Name = "AlumnoInscripcionesDesktop";
            this.Text = "AlumnoInscripcionesDesktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDInscripcion;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblIDAlumno;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.TextBox txtIDInscripcion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.TextBox txtIDAlumno;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}