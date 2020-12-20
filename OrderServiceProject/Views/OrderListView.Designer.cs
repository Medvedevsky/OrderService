namespace OrderServiceProject.Views
{
    partial class OrderListView
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
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.NameUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUserColumn,
            this.IdColumn,
            this.NameProductColumn,
            this.PriceColumn});
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 28);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 24;
            this.orderDataGridView.Size = new System.Drawing.Size(800, 422);
            this.orderDataGridView.TabIndex = 6;
            this.orderDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.orderDataGridView_CellFormatting);
            // 
            // NameUserColumn
            // 
            this.NameUserColumn.DataPropertyName = "Name";
            this.NameUserColumn.HeaderText = "Имя покупателя";
            this.NameUserColumn.MinimumWidth = 6;
            this.NameUserColumn.Name = "NameUserColumn";
            this.NameUserColumn.ReadOnly = true;
            this.NameUserColumn.Width = 125;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 125;
            // 
            // NameProductColumn
            // 
            this.NameProductColumn.HeaderText = "Имя заказа";
            this.NameProductColumn.MinimumWidth = 6;
            this.NameProductColumn.Name = "NameProductColumn";
            this.NameProductColumn.ReadOnly = true;
            this.NameProductColumn.Width = 125;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "OldPrice";
            this.PriceColumn.HeaderText = "Цена заказа";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 125;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.optionsToolStripMenuItem.Text = "Опции";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.toolsToolStripMenuItem.Text = "Инструменты";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.deleteToolStripMenuItem.Text = "Отменить заказ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.updateToolStripMenuItem.Text = "Обновить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "OrderListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderListView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderListView_FormClosed);
            this.Load += new System.EventHandler(this.OrderListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
    }
}