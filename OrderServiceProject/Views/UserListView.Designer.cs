namespace OrderServiceProject.Views
{
    partial class UserListView
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
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeletedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.LoginColumn,
            this.PasswordColumn,
            this.AgeColumn,
            this.RoleColumn,
            this.IsDeletedColumn});
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.Location = new System.Drawing.Point(0, 28);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(901, 422);
            this.userDataGridView.TabIndex = 6;
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
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteUserToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.toolsToolStripMenuItem.Text = "Инструменты";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.deleteUserToolStripMenuItem.Text = "Удалить пользователя";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.updateToolStripMenuItem.Text = "Обновить";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
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
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Имя пользователя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // LoginColumn
            // 
            this.LoginColumn.DataPropertyName = "Login";
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.MinimumWidth = 6;
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.ReadOnly = true;
            this.LoginColumn.Width = 125;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "Password";
            this.PasswordColumn.HeaderText = "Пароль";
            this.PasswordColumn.MinimumWidth = 6;
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.ReadOnly = true;
            this.PasswordColumn.Width = 125;
            // 
            // AgeColumn
            // 
            this.AgeColumn.DataPropertyName = "Age";
            this.AgeColumn.HeaderText = "Дата рождения";
            this.AgeColumn.MinimumWidth = 6;
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            this.AgeColumn.Width = 125;
            // 
            // RoleColumn
            // 
            this.RoleColumn.DataPropertyName = "Role";
            this.RoleColumn.HeaderText = "Роль на сайте";
            this.RoleColumn.MinimumWidth = 6;
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            this.RoleColumn.Width = 125;
            // 
            // IsDeletedColumn
            // 
            this.IsDeletedColumn.DataPropertyName = "IsDeleted";
            this.IsDeletedColumn.HeaderText = "IsDeleted";
            this.IsDeletedColumn.MinimumWidth = 6;
            this.IsDeletedColumn.Name = "IsDeletedColumn";
            this.IsDeletedColumn.ReadOnly = true;
            this.IsDeletedColumn.Visible = false;
            this.IsDeletedColumn.Width = 125;
            // 
            // UserListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserListView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserListView_FormClosed);
            this.Load += new System.EventHandler(this.UserListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeletedColumn;
    }
}