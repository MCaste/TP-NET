namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblHorasSemanales = new System.Windows.Forms.Label();
            this.lblHorasTotales = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.txtHorasTotales = new System.Windows.Forms.TextBox();
            this.txtHorasSemanales = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Location = new System.Drawing.Point(13, 70);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(42, 13);
            this.lblIDPlan.TabIndex = 2;
            this.lblIDPlan.Text = "ID Plan";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(189, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblHorasSemanales
            // 
            this.lblHorasSemanales.AutoSize = true;
            this.lblHorasSemanales.Location = new System.Drawing.Point(281, 10);
            this.lblHorasSemanales.Name = "lblHorasSemanales";
            this.lblHorasSemanales.Size = new System.Drawing.Size(90, 13);
            this.lblHorasSemanales.TabIndex = 4;
            this.lblHorasSemanales.Text = "Horas Semanales";
            // 
            // lblHorasTotales
            // 
            this.lblHorasTotales.AutoSize = true;
            this.lblHorasTotales.Location = new System.Drawing.Point(281, 41);
            this.lblHorasTotales.Name = "lblHorasTotales";
            this.lblHorasTotales.Size = new System.Drawing.Size(73, 13);
            this.lblHorasTotales.TabIndex = 5;
            this.lblHorasTotales.Text = "Horas Totales";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(85, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.Location = new System.Drawing.Point(86, 67);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.Size = new System.Drawing.Size(189, 20);
            this.txtIDPlan.TabIndex = 3;
            // 
            // txtHorasTotales
            // 
            this.txtHorasTotales.Location = new System.Drawing.Point(380, 36);
            this.txtHorasTotales.Name = "txtHorasTotales";
            this.txtHorasTotales.Size = new System.Drawing.Size(189, 20);
            this.txtHorasTotales.TabIndex = 5;
            // 
            // txtHorasSemanales
            // 
            this.txtHorasSemanales.Location = new System.Drawing.Point(380, 10);
            this.txtHorasSemanales.Name = "txtHorasSemanales";
            this.txtHorasSemanales.Size = new System.Drawing.Size(189, 20);
            this.txtHorasSemanales.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(199, 108);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 138);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtHorasSemanales);
            this.Controls.Add(this.txtHorasTotales);
            this.Controls.Add(this.txtIDPlan);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblHorasTotales);
            this.Controls.Add(this.lblHorasSemanales);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDPlan);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblID);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblHorasSemanales;
        private System.Windows.Forms.Label lblHorasTotales;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIDPlan;
        private System.Windows.Forms.TextBox txtHorasTotales;
        private System.Windows.Forms.TextBox txtHorasSemanales;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}