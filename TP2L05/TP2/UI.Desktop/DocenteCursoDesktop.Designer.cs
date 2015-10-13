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
            this.components = new System.ComponentModel.Container();
            this.txtIDDictado = new System.Windows.Forms.TextBox();
            this.txtTipoCargo = new System.Windows.Forms.TextBox();
            this.lblIDDictado = new System.Windows.Forms.Label();
            this.lblIDDocente = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblTipoCargo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbIdCurso = new System.Windows.Forms.ComboBox();
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.tp2netDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.cursosTableAdapter();
            this.cbIdDocente = new System.Windows.Forms.ComboBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.personasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2netDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDDictado
            // 
            this.txtIDDictado.Location = new System.Drawing.Point(90, 6);
            this.txtIDDictado.Name = "txtIDDictado";
            this.txtIDDictado.ReadOnly = true;
            this.txtIDDictado.Size = new System.Drawing.Size(172, 20);
            this.txtIDDictado.TabIndex = 1;
            // 
            // txtTipoCargo
            // 
            this.txtTipoCargo.Location = new System.Drawing.Point(90, 84);
            this.txtTipoCargo.Name = "txtTipoCargo";
            this.txtTipoCargo.Size = new System.Drawing.Size(172, 20);
            this.txtTipoCargo.TabIndex = 4;
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
            this.btnAceptar.Location = new System.Drawing.Point(106, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbIdCurso
            // 
            this.cbIdCurso.DataSource = this.cursosBindingSource;
            this.cbIdCurso.DisplayMember = "id_curso";
            this.cbIdCurso.FormattingEnabled = true;
            this.cbIdCurso.Location = new System.Drawing.Point(90, 58);
            this.cbIdCurso.Name = "cbIdCurso";
            this.cbIdCurso.Size = new System.Drawing.Size(172, 21);
            this.cbIdCurso.TabIndex = 8;
            this.cbIdCurso.ValueMember = "id_curso";
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tp2netDataSetBindingSource
            // 
            this.tp2netDataSetBindingSource.DataSource = this.tp2_netDataSet;
            this.tp2netDataSetBindingSource.Position = 0;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.tp2netDataSetBindingSource;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // cbIdDocente
            // 
            this.cbIdDocente.DataSource = this.personasBindingSource;
            this.cbIdDocente.DisplayMember = "id_persona";
            this.cbIdDocente.FormattingEnabled = true;
            this.cbIdDocente.Location = new System.Drawing.Point(90, 32);
            this.cbIdDocente.Name = "cbIdDocente";
            this.cbIdDocente.Size = new System.Drawing.Size(172, 21);
            this.cbIdDocente.TabIndex = 9;
            this.cbIdDocente.ValueMember = "id_persona";
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.tp2netDataSetBindingSource;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 163);
            this.Controls.Add(this.cbIdDocente);
            this.Controls.Add(this.cbIdCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTipoCargo);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblIDDocente);
            this.Controls.Add(this.lblIDDictado);
            this.Controls.Add(this.txtTipoCargo);
            this.Controls.Add(this.txtIDDictado);
            this.Name = "DocenteCursoDesktop";
            this.Text = "Docente - Curso";
            this.Load += new System.EventHandler(this.DocenteCursoDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2netDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDDictado;
        private System.Windows.Forms.TextBox txtTipoCargo;
        private System.Windows.Forms.Label lblIDDictado;
        private System.Windows.Forms.Label lblIDDocente;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblTipoCargo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbIdCurso;
        private System.Windows.Forms.BindingSource tp2netDataSetBindingSource;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private tp2_netDataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.ComboBox cbIdDocente;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private tp2_netDataSetTableAdapters.personasTableAdapter personasTableAdapter;

    }
}