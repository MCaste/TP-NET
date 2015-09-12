namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblIDDictado = new System.Windows.Forms.Label();
            this.lblIDDocente = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 20);
            this.textBox4.TabIndex = 3;
            // 
            // lblIDDictado
            // 
            this.lblIDDictado.AutoSize = true;
            this.lblIDDictado.Location = new System.Drawing.Point(8, 9);
            this.lblIDDictado.Name = "lblIDDictado";
            this.lblIDDictado.Size = new System.Drawing.Size(61, 13);
            this.lblIDDictado.TabIndex = 4;
            this.lblIDDictado.Text = "ID Dictado:";
            // 
            // lblIDDocente
            // 
            this.lblIDDocente.AutoSize = true;
            this.lblIDDocente.Location = new System.Drawing.Point(8, 35);
            this.lblIDDocente.Name = "lblIDDocente";
            this.lblIDDocente.Size = new System.Drawing.Size(65, 13);
            this.lblIDDocente.TabIndex = 5;
            this.lblIDDocente.Text = "ID Docente:";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(8, 65);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(51, 13);
            this.lblIDCurso.TabIndex = 6;
            this.lblIDCurso.Text = "ID Curso:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(8, 91);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(129, 110);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 148);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblIDDocente);
            this.Controls.Add(this.lblIDDictado);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "DocenteCursoDesktop";
            this.Text = "Docente - Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblIDDictado;
        private System.Windows.Forms.Label lblIDDocente;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}