
namespace Proyecto_DoñaZoila
{
    partial class FrmVisualizarMateriales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizarMateriales));
            this.panelVisualizarMateriales = new System.Windows.Forms.Panel();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelVisualizarMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVisualizarMateriales
            // 
            this.panelVisualizarMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.panelVisualizarMateriales.Controls.Add(this.dgvMateriales);
            this.panelVisualizarMateriales.Controls.Add(this.btnRetornar);
            this.panelVisualizarMateriales.Controls.Add(this.label1);
            this.panelVisualizarMateriales.Controls.Add(this.panel2);
            this.panelVisualizarMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisualizarMateriales.Location = new System.Drawing.Point(0, 0);
            this.panelVisualizarMateriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVisualizarMateriales.Name = "panelVisualizarMateriales";
            this.panelVisualizarMateriales.Size = new System.Drawing.Size(1099, 625);
            this.panelVisualizarMateriales.TabIndex = 5;
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.AllowUserToResizeColumns = false;
            this.dgvMateriales.AllowUserToResizeRows = false;
            this.dgvMateriales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMateriales.ColumnHeadersHeight = 35;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMateriales.EnableHeadersVisualStyles = false;
            this.dgvMateriales.GridColor = System.Drawing.Color.White;
            this.dgvMateriales.Location = new System.Drawing.Point(61, 154);
            this.dgvMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMateriales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMateriales.RowTemplate.Height = 24;
            this.dgvMateriales.Size = new System.Drawing.Size(925, 391);
            this.dgvMateriales.TabIndex = 71;
            this.dgvMateriales.DoubleClick += new System.EventHandler(this.dgvMateriales_DoubleClick);
            // 
            // btnRetornar
            // 
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnRetornar.Image = ((System.Drawing.Image)(resources.GetObject("btnRetornar.Image")));
            this.btnRetornar.Location = new System.Drawing.Point(997, 549);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(101, 76);
            this.btnRetornar.TabIndex = 8;
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Materiales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.panel2.Location = new System.Drawing.Point(4, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 1);
            this.panel2.TabIndex = 4;
            // 
            // FrmVisualizarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 625);
            this.Controls.Add(this.panelVisualizarMateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVisualizarMateriales";
            this.Text = "FrmMateriales";
            this.Load += new System.EventHandler(this.FrmMateriales_Load);
            this.panelVisualizarMateriales.ResumeLayout(false);
            this.panelVisualizarMateriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVisualizarMateriales;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}