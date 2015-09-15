namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.txtIDComision = new System.Windows.Forms.TextBox();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.lblIDComision = new System.Windows.Forms.Label();
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.txtAnioCalendario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(12, 32);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(18, 13);
            this.lblIDCurso.TabIndex = 0;
            this.lblIDCurso.Text = "ID";
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(12, 62);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 1;
            this.lblCupo.Text = "Cupo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(100, 55);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(150, 20);
            this.txtCupo.TabIndex = 3;
            // 
            // txtIDComision
            // 
            this.txtIDComision.Location = new System.Drawing.Point(348, 25);
            this.txtIDComision.Name = "txtIDComision";
            this.txtIDComision.Size = new System.Drawing.Size(162, 20);
            this.txtIDComision.TabIndex = 4;
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(348, 58);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.Size = new System.Drawing.Size(162, 20);
            this.txtIDMateria.TabIndex = 5;
            // 
            // lblIDComision
            // 
            this.lblIDComision.AutoSize = true;
            this.lblIDComision.Location = new System.Drawing.Point(267, 32);
            this.lblIDComision.Name = "lblIDComision";
            this.lblIDComision.Size = new System.Drawing.Size(63, 13);
            this.lblIDComision.TabIndex = 6;
            this.lblIDComision.Text = "ID Comision";
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(267, 58);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(56, 13);
            this.lblIDMateria.TabIndex = 7;
            this.lblIDMateria.Text = "ID Materia";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(12, 88);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(79, 13);
            this.lblAnioCalendario.TabIndex = 8;
            this.lblAnioCalendario.Text = "Año Calendario";
            // 
            // txtAnioCalendario
            // 
            this.txtAnioCalendario.Location = new System.Drawing.Point(100, 85);
            this.txtAnioCalendario.Name = "txtAnioCalendario";
            this.txtAnioCalendario.Size = new System.Drawing.Size(150, 20);
            this.txtAnioCalendario.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(270, 88);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(351, 88);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 128);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtAnioCalendario);
            this.Controls.Add(this.lblAnioCalendario);
            this.Controls.Add(this.lblIDMateria);
            this.Controls.Add(this.lblIDComision);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.txtIDComision);
            this.Controls.Add(this.txtCupo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCupo);
            this.Controls.Add(this.lblIDCurso);
            this.Name = "CursoDesktop";
            this.Text = "Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TextBox txtIDComision;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.Label lblIDComision;
        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.TextBox txtAnioCalendario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;


    }
}