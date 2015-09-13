namespace UI.Desktop
{
    partial class Persona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persona));
            this.tscPersona = new System.Windows.Forms.ToolStripContainer();
            this.tlPersona = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsPersona = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.IDPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscPersona.ContentPanel.SuspendLayout();
            this.tscPersona.TopToolStripPanel.SuspendLayout();
            this.tscPersona.SuspendLayout();
            this.tlPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.tsPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscPersona
            // 
            // 
            // tscPersona.ContentPanel
            // 
            this.tscPersona.ContentPanel.Controls.Add(this.tlPersona);
            this.tscPersona.ContentPanel.Size = new System.Drawing.Size(545, 246);
            this.tscPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscPersona.Location = new System.Drawing.Point(0, 0);
            this.tscPersona.Name = "tscPersona";
            this.tscPersona.Size = new System.Drawing.Size(545, 271);
            this.tscPersona.TabIndex = 0;
            this.tscPersona.Text = "toolStripContainer1";
            // 
            // tscPersona.TopToolStripPanel
            // 
            this.tscPersona.TopToolStripPanel.Controls.Add(this.tsPersona);
            // 
            // tlPersona
            // 
            this.tlPersona.ColumnCount = 2;
            this.tlPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersona.Controls.Add(this.dgvPersona, 0, 0);
            this.tlPersona.Controls.Add(this.btnActualizar, 0, 1);
            this.tlPersona.Controls.Add(this.btnSalir, 1, 1);
            this.tlPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersona.Location = new System.Drawing.Point(0, 0);
            this.tlPersona.Name = "tlPersona";
            this.tlPersona.RowCount = 2;
            this.tlPersona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPersona.Size = new System.Drawing.Size(545, 246);
            this.tlPersona.TabIndex = 0;
            // 
            // dgvPersona
            // 
            this.dgvPersona.AllowUserToAddRows = false;
            this.dgvPersona.AllowUserToDeleteRows = false;
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPersona,
            this.apellido,
            this.nombre,
            this.direccion,
            this.email,
            this.telefono,
            this.fechNac,
            this.legajo,
            this.tipoPersona,
            this.IDPlan});
            this.tlPersona.SetColumnSpan(this.dgvPersona, 2);
            this.dgvPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersona.Location = new System.Drawing.Point(3, 3);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.ReadOnly = true;
            this.dgvPersona.Size = new System.Drawing.Size(539, 211);
            this.dgvPersona.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(386, 220);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(467, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // tsPersona
            // 
            this.tsPersona.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPersona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsPersona.Location = new System.Drawing.Point(3, 0);
            this.tsPersona.Name = "tsPersona";
            this.tsPersona.Size = new System.Drawing.Size(81, 25);
            this.tsPersona.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // IDPersona
            // 
            this.IDPersona.DataPropertyName = "IDPersona";
            this.IDPersona.HeaderText = "ID Persona";
            this.IDPersona.Name = "IDPersona";
            this.IDPersona.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechNac
            // 
            this.fechNac.DataPropertyName = "fechaNacimiento";
            this.fechNac.HeaderText = "Fecha de nacimiento";
            this.fechNac.Name = "fechNac";
            this.fechNac.ReadOnly = true;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // tipoPersona
            // 
            this.tipoPersona.DataPropertyName = "tipoPersona";
            this.tipoPersona.HeaderText = "Tipo Persona";
            this.tipoPersona.Name = "tipoPersona";
            this.tipoPersona.ReadOnly = true;
            // 
            // IDPlan
            // 
            this.IDPlan.DataPropertyName = "IDPlan";
            this.IDPlan.HeaderText = "ID Plan";
            this.IDPlan.Name = "IDPlan";
            this.IDPlan.ReadOnly = true;
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 271);
            this.Controls.Add(this.tscPersona);
            this.Name = "Persona";
            this.Text = "Persona";
            this.tscPersona.ContentPanel.ResumeLayout(false);
            this.tscPersona.TopToolStripPanel.ResumeLayout(false);
            this.tscPersona.TopToolStripPanel.PerformLayout();
            this.tscPersona.ResumeLayout(false);
            this.tscPersona.PerformLayout();
            this.tlPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.tsPersona.ResumeLayout(false);
            this.tsPersona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscPersona;
        private System.Windows.Forms.TableLayoutPanel tlPersona;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlan;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsPersona;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}