
namespace Proyecto_DoñaZoila
{
    partial class FrmRealizacionProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRealizacionProducto));
            this.panelOrdenes = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvRealizacionProductos = new System.Windows.Forms.DataGridView();
            this.nudCantMaterial = new System.Windows.Forms.NumericUpDown();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantProducto = new System.Windows.Forms.NumericUpDown();
            this.CodMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panelOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizacionProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOrdenes
            // 
            this.panelOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.panelOrdenes.Controls.Add(this.label9);
            this.panelOrdenes.Controls.Add(this.nudCantProducto);
            this.panelOrdenes.Controls.Add(this.label4);
            this.panelOrdenes.Controls.Add(this.btnFinalizar);
            this.panelOrdenes.Controls.Add(this.dgvRealizacionProductos);
            this.panelOrdenes.Controls.Add(this.nudCantMaterial);
            this.panelOrdenes.Controls.Add(this.txtNombreMaterial);
            this.panelOrdenes.Controls.Add(this.label5);
            this.panelOrdenes.Controls.Add(this.btnMaterial);
            this.panelOrdenes.Controls.Add(this.btnProducto);
            this.panelOrdenes.Controls.Add(this.btnEliminar);
            this.panelOrdenes.Controls.Add(this.btnAgregar);
            this.panelOrdenes.Controls.Add(this.txtCodigoMaterial);
            this.panelOrdenes.Controls.Add(this.txtNombreProducto);
            this.panelOrdenes.Controls.Add(this.txtCodigoProducto);
            this.panelOrdenes.Controls.Add(this.label6);
            this.panelOrdenes.Controls.Add(this.label3);
            this.panelOrdenes.Controls.Add(this.btnRetornar);
            this.panelOrdenes.Controls.Add(this.label2);
            this.panelOrdenes.Controls.Add(this.label1);
            this.panelOrdenes.Controls.Add(this.panel2);
            this.panelOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrdenes.Location = new System.Drawing.Point(0, 0);
            this.panelOrdenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOrdenes.Name = "panelOrdenes";
            this.panelOrdenes.Size = new System.Drawing.Size(1099, 625);
            this.panelOrdenes.TabIndex = 2;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Tan;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(949, 308);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(117, 39);
            this.btnFinalizar.TabIndex = 72;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dgvRealizacionProductos
            // 
            this.dgvRealizacionProductos.AllowUserToAddRows = false;
            this.dgvRealizacionProductos.AllowUserToDeleteRows = false;
            this.dgvRealizacionProductos.AllowUserToResizeColumns = false;
            this.dgvRealizacionProductos.AllowUserToResizeRows = false;
            this.dgvRealizacionProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRealizacionProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRealizacionProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRealizacionProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRealizacionProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRealizacionProductos.ColumnHeadersHeight = 35;
            this.dgvRealizacionProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRealizacionProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMaterial,
            this.NombreMaterial,
            this.Unidades});
            this.dgvRealizacionProductos.EnableHeadersVisualStyles = false;
            this.dgvRealizacionProductos.GridColor = System.Drawing.Color.White;
            this.dgvRealizacionProductos.Location = new System.Drawing.Point(21, 366);
            this.dgvRealizacionProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRealizacionProductos.Name = "dgvRealizacionProductos";
            this.dgvRealizacionProductos.ReadOnly = true;
            this.dgvRealizacionProductos.RowHeadersVisible = false;
            this.dgvRealizacionProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRealizacionProductos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRealizacionProductos.RowTemplate.Height = 24;
            this.dgvRealizacionProductos.Size = new System.Drawing.Size(1045, 208);
            this.dgvRealizacionProductos.TabIndex = 71;
            // 
            // nudCantMaterial
            // 
            this.nudCantMaterial.Location = new System.Drawing.Point(808, 211);
            this.nudCantMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantMaterial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantMaterial.Name = "nudCantMaterial";
            this.nudCantMaterial.Size = new System.Drawing.Size(207, 22);
            this.nudCantMaterial.TabIndex = 43;
            this.nudCantMaterial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Enabled = false;
            this.txtNombreMaterial.Location = new System.Drawing.Point(808, 158);
            this.txtNombreMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(205, 22);
            this.txtNombreMaterial.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nombre Material:";
            // 
            // btnMaterial
            // 
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterial.Image")));
            this.btnMaterial.Location = new System.Drawing.Point(1018, 130);
            this.btnMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(48, 25);
            this.btnMaterial.TabIndex = 40;
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.Location = new System.Drawing.Point(466, 130);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(48, 25);
            this.btnProducto.TabIndex = 39;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tan;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(491, 308);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 39);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Tan;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 308);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 39);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.Enabled = false;
            this.txtCodigoMaterial.Location = new System.Drawing.Point(808, 109);
            this.txtCodigoMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(205, 22);
            this.txtCodigoMaterial.TabIndex = 20;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(247, 160);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(205, 22);
            this.txtNombreProducto.TabIndex = 18;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Location = new System.Drawing.Point(247, 107);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(205, 22);
            this.txtCodigoProducto.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codigo Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre Producto:";
            // 
            // btnRetornar
            // 
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.btnRetornar.Image = ((System.Drawing.Image)(resources.GetObject("btnRetornar.Image")));
            this.btnRetornar.Location = new System.Drawing.Point(999, 566);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(99, 59);
            this.btnRetornar.TabIndex = 8;
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Realización Productos";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Cantidad productos:";
            // 
            // nudCantProducto
            // 
            this.nudCantProducto.Location = new System.Drawing.Point(247, 211);
            this.nudCantProducto.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantProducto.Name = "nudCantProducto";
            this.nudCantProducto.Size = new System.Drawing.Size(207, 22);
            this.nudCantProducto.TabIndex = 74;
            this.nudCantProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CodMaterial
            // 
            this.CodMaterial.HeaderText = "Codigo Material";
            this.CodMaterial.MinimumWidth = 6;
            this.CodMaterial.Name = "CodMaterial";
            this.CodMaterial.ReadOnly = true;
            this.CodMaterial.Width = 125;
            // 
            // NombreMaterial
            // 
            this.NombreMaterial.HeaderText = "Nombre Material";
            this.NombreMaterial.MinimumWidth = 6;
            this.NombreMaterial.Name = "NombreMaterial";
            this.NombreMaterial.ReadOnly = true;
            this.NombreMaterial.Width = 125;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades utilizadas";
            this.Unidades.MinimumWidth = 6;
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            this.Unidades.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(569, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 22);
            this.label9.TabIndex = 75;
            this.label9.Text = "Cantidad materiales:";
            // 
            // FrmRealizacionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 625);
            this.Controls.Add(this.panelOrdenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRealizacionProducto";
            this.Text = "FrmRealizacionProducto";
            this.panelOrdenes.ResumeLayout(false);
            this.panelOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizacionProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrdenes;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvRealizacionProductos;
        private System.Windows.Forms.NumericUpDown nudCantMaterial;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudCantProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.Label label9;
    }
}