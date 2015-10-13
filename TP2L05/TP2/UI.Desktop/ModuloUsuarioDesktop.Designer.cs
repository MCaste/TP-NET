namespace UI.Desktop
{
    partial class ModuloUsuarioDesktop
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDModulo = new System.Windows.Forms.Label();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIDModulo = new System.Windows.Forms.TextBox();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.modulosusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.modulosusuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblIDModulo
            // 
            this.lblIDModulo.AutoSize = true;
            this.lblIDModulo.Location = new System.Drawing.Point(13, 46);
            this.lblIDModulo.Name = "lblIDModulo";
            this.lblIDModulo.Size = new System.Drawing.Size(56, 13);
            this.lblIDModulo.TabIndex = 1;
            this.lblIDModulo.Text = "ID Modulo";
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(12, 72);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(57, 13);
            this.lblIDUsuario.TabIndex = 2;
            this.lblIDUsuario.Text = "ID Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 18);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtIDModulo
            // 
            this.txtIDModulo.Location = new System.Drawing.Point(84, 43);
            this.txtIDModulo.Name = "txtIDModulo";
            this.txtIDModulo.Size = new System.Drawing.Size(147, 20);
            this.txtIDModulo.TabIndex = 2;
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(84, 69);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(147, 20);
            this.txtIDUsuario.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(66, 105);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(169, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ModuloUsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(261, 151);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.txtIDModulo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.lblIDModulo);
            this.Controls.Add(this.lblID);
            this.Name = "ModuloUsuarioDesktop";
            this.Text = "Modulo - Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.modulosusuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDModulo;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDModulo;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource modulosusuariosBindingSource;
    }
}