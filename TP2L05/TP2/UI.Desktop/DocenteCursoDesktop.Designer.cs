﻿namespace UI.Desktop
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
            this.txtIDDictado = new System.Windows.Forms.TextBox();
            this.txtIDDocente = new System.Windows.Forms.TextBox();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.txtTipoCargo = new System.Windows.Forms.TextBox();
            this.lblIDDictado = new System.Windows.Forms.Label();
            this.lblIDDocente = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblTipoCargo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDDictado
            // 
            this.txtIDDictado.Location = new System.Drawing.Point(90, 6);
            this.txtIDDictado.Name = "txtIDDictado";
            this.txtIDDictado.Size = new System.Drawing.Size(172, 20);
            this.txtIDDictado.TabIndex = 0;
            // 
            // txtIDDocente
            // 
            this.txtIDDocente.Location = new System.Drawing.Point(90, 32);
            this.txtIDDocente.Name = "txtIDDocente";
            this.txtIDDocente.Size = new System.Drawing.Size(172, 20);
            this.txtIDDocente.TabIndex = 1;
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Location = new System.Drawing.Point(90, 58);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(172, 20);
            this.txtIDCurso.TabIndex = 2;
            // 
            // txtTipoCargo
            // 
            this.txtTipoCargo.Location = new System.Drawing.Point(90, 84);
            this.txtTipoCargo.Name = "txtTipoCargo";
            this.txtTipoCargo.Size = new System.Drawing.Size(172, 20);
            this.txtTipoCargo.TabIndex = 3;
            // 
            // lblIDDictado
            // 
            this.lblIDDictado.AutoSize = true;
            this.lblIDDictado.Location = new System.Drawing.Point(8, 9);
            this.lblIDDictado.Name = "lblIDDictado";
            this.lblIDDictado.Size = new System.Drawing.Size(58, 13);
            this.lblIDDictado.TabIndex = 4;
            this.lblIDDictado.Text = "ID Dictado";
            // 
            // lblIDDocente
            // 
            this.lblIDDocente.AutoSize = true;
            this.lblIDDocente.Location = new System.Drawing.Point(8, 35);
            this.lblIDDocente.Name = "lblIDDocente";
            this.lblIDDocente.Size = new System.Drawing.Size(62, 13);
            this.lblIDDocente.TabIndex = 5;
            this.lblIDDocente.Text = "ID Docente";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(8, 61);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 6;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblTipoCargo
            // 
            this.lblTipoCargo.AutoSize = true;
            this.lblTipoCargo.Location = new System.Drawing.Point(8, 87);
            this.lblTipoCargo.Name = "lblTipoCargo";
            this.lblTipoCargo.Size = new System.Drawing.Size(59, 13);
            this.lblTipoCargo.TabIndex = 7;
            this.lblTipoCargo.Text = "Tipo Cargo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(129, 110);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 148);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTipoCargo);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblIDDocente);
            this.Controls.Add(this.lblIDDictado);
            this.Controls.Add(this.txtTipoCargo);
            this.Controls.Add(this.txtIDCurso);
            this.Controls.Add(this.txtIDDocente);
            this.Controls.Add(this.txtIDDictado);
            this.Name = "DocenteCursoDesktop";
            this.Text = "Docente - Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDDictado;
        private System.Windows.Forms.TextBox txtIDDocente;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.TextBox txtTipoCargo;
        private System.Windows.Forms.Label lblIDDictado;
        private System.Windows.Forms.Label lblIDDocente;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblTipoCargo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}