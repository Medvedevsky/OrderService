namespace OrderServiceProject.Views
{
    partial class ProductListView
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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableGroupsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doOrderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.toolsToolStripMenuItem.Text = "Инструменты";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.updateToolStripMenuItem.Text = "Обновить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // tableGroupsButton
            // 
            this.tableGroupsButton.Name = "tableGroupsButton";
            this.tableGroupsButton.Size = new System.Drawing.Size(199, 24);
            this.tableGroupsButton.Text = "Список заказов клиентов";
            this.tableGroupsButton.Click += new System.EventHandler(this.tableGroupsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.tableGroupsButton,
            this.doOrderButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doOrderButton
            // 
            this.doOrderButton.Name = "doOrderButton";
            this.doOrderButton.Size = new System.Drawing.Size(119, 24);
            this.doOrderButton.Text = "Сделать заказ";
            this.doOrderButton.Click += new System.EventHandler(this.doOrderButton_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameProductColumn,
            this.PriceColumn});
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataGridView.Location = new System.Drawing.Point(0, 28);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(800, 422);
            this.productDataGridView.TabIndex = 4;
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
            this.NameProductColumn.DataPropertyName = "NameProduct";
            this.NameProductColumn.HeaderText = "Название товара";
            this.NameProductColumn.MinimumWidth = 6;
            this.NameProductColumn.Name = "NameProductColumn";
            this.NameProductColumn.ReadOnly = true;
            this.NameProductColumn.Width = 125;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 125;
            // 
            // ProductListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ProductListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductListView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductListView_FormClosed);
            this.Load += new System.EventHandler(this.ProductListView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableGroupsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.ToolStripMenuItem doOrderButton;
    }
}