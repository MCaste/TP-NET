namespace UI.Desktop
{
    partial class DocenteCurso
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tsDocenteCurso = new System.Windows.Forms.ToolStrip();
            this.tlDocenteCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocenteCurso = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tlDocenteCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlDocenteCurso);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(622, 359);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(622, 384);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsDocenteCurso);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // tsDocenteCurso
            // 
            this.tsDocenteCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDocenteCurso.Location = new System.Drawing.Point(3, 0);
            this.tsDocenteCurso.Name = "tsDocenteCurso";
            this.tsDocenteCurso.Size = new System.Drawing.Size(111, 25);
            this.tsDocenteCurso.TabIndex = 0;
            // 
            // tlDocenteCurso
            // 
            this.tlDocenteCurso.ColumnCount = 2;
            this.tlDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlDocenteCurso.Controls.Add(this.dgvDocenteCurso, 0, 0);
            this.tlDocenteCurso.Controls.Add(this.btnActualizar, 0, 1);
            this.tlDocenteCurso.Controls.Add(this.btnSalir, 1, 1);
            this.tlDocenteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocenteCurso.Location = new System.Drawing.Point(0, 0);
            this.tlDocenteCurso.Name = "tlDocenteCurso";
            this.tlDocenteCurso.RowCount = 2;
            this.tlDocenteCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocenteCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocenteCurso.Size = new System.Drawing.Size(622, 359);
            this.tlDocenteCurso.TabIndex = 0;
            // 
            // dgvDocenteCurso
            // 
            this.dgvDocenteCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlDocenteCurso.SetColumnSpan(this.dgvDocenteCurso, 2);
            this.dgvDocenteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocenteCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvDocenteCurso.Name = "dgvDocenteCurso";
            this.dgvDocenteCurso.Size = new System.Drawing.Size(616, 324);
            this.dgvDocenteCurso.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(463, 333);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(544, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // DocenteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 384);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "DocenteCurso";
            this.Text = "DocenteCurso";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlDocenteCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlDocenteCurso;
        private System.Windows.Forms.DataGridView dgvDocenteCurso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsDocenteCurso;

    }
}