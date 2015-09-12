namespace UI.Desktop
{
    partial class Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curso));
            this.tcCurso = new System.Windows.Forms.ToolStripContainer();
            this.tsCurso = new System.Windows.Forms.ToolStrip();
            this.tlCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCurso.ContentPanel.SuspendLayout();
            this.tcCurso.TopToolStripPanel.SuspendLayout();
            this.tcCurso.SuspendLayout();
            this.tsCurso.SuspendLayout();
            this.tlCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCurso
            // 
            // 
            // tcCurso.ContentPanel
            // 
            this.tcCurso.ContentPanel.Controls.Add(this.tlCurso);
            this.tcCurso.ContentPanel.Size = new System.Drawing.Size(616, 342);
            this.tcCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCurso.Location = new System.Drawing.Point(0, 0);
            this.tcCurso.Name = "tcCurso";
            this.tcCurso.Size = new System.Drawing.Size(616, 367);
            this.tcCurso.TabIndex = 0;
            this.tcCurso.Text = "toolStripContainer1";
            // 
            // tcCurso.tspCurso
            // 
            this.tcCurso.TopToolStripPanel.Controls.Add(this.tsCurso);
            // 
            // tsCurso
            // 
            this.tsCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCurso.Location = new System.Drawing.Point(3, 0);
            this.tsCurso.Name = "tsCurso";
            this.tsCurso.Size = new System.Drawing.Size(81, 25);
            this.tsCurso.TabIndex = 0;
            // 
            // tlCurso
            // 
            this.tlCurso.ColumnCount = 2;
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCurso.Controls.Add(this.dgvCurso, 0, 0);
            this.tlCurso.Controls.Add(this.btnSalir, 1, 1);
            this.tlCurso.Controls.Add(this.btnActualizar, 0, 1);
            this.tlCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCurso.Location = new System.Drawing.Point(0, 0);
            this.tlCurso.Name = "tlCurso";
            this.tlCurso.RowCount = 2;
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCurso.Size = new System.Drawing.Size(616, 342);
            this.tlCurso.TabIndex = 0;
            // 
            // dgvCurso
            // 
            this.dgvCurso.AllowUserToAddRows = false;
            this.dgvCurso.AllowUserToDeleteRows = false;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCurso,
            this.cupo,
            this.idComision,
            this.idMateria,
            this.anioCalendario});
            this.tlCurso.SetColumnSpan(this.dgvCurso, 2);
            this.dgvCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.Size = new System.Drawing.Size(610, 307);
            this.dgvCurso.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(457, 316);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(538, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            // idCurso
            // 
            this.idCurso.DataPropertyName = "ID Curso";
            this.idCurso.HeaderText = "ID Curso";
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "Cupo";
            this.cupo.HeaderText = "Cupo";
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // idComision
            // 
            this.idComision.DataPropertyName = "ID Comision";
            this.idComision.HeaderText = "ID Comision";
            this.idComision.Name = "idComision";
            this.idComision.ReadOnly = true;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "ID Materia";
            this.idMateria.HeaderText = "ID Materia";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            // 
            // anioCalendario
            // 
            this.anioCalendario.DataPropertyName = "Anio Calendario";
            this.anioCalendario.HeaderText = "Año Calendario";
            this.anioCalendario.Name = "anioCalendario";
            this.anioCalendario.ReadOnly = true;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 367);
            this.Controls.Add(this.tcCurso);
            this.Name = "Curso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
            this.tcCurso.ContentPanel.ResumeLayout(false);
            this.tcCurso.TopToolStripPanel.ResumeLayout(false);
            this.tcCurso.TopToolStripPanel.PerformLayout();
            this.tcCurso.ResumeLayout(false);
            this.tcCurso.PerformLayout();
            this.tsCurso.ResumeLayout(false);
            this.tsCurso.PerformLayout();
            this.tlCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCurso;
        private System.Windows.Forms.TableLayoutPanel tlCurso;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCurso;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioCalendario;
    }
}