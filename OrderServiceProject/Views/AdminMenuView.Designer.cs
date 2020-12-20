namespace OrderServiceProject.Views
{
    partial class AdminMenuView
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
            this.productButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(12, 59);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(136, 53);
            this.productButton.TabIndex = 0;
            this.productButton.Text = "Список товаров";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(154, 60);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(136, 52);
            this.userButton.TabIndex = 1;
            this.userButton.Text = "Список пользователей";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(296, 59);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(136, 52);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Список заказов";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // AdminMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 161);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.productButton);
            this.Name = "AdminMenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenuView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenuView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button orderButton;
    }
}