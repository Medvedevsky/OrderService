namespace OrderServiceProject.Views
{
    partial class ClientMenuView
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
            this.orderButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(154, 62);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(136, 52);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Список моих заказов";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(12, 61);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(136, 53);
            this.productButton.TabIndex = 3;
            this.productButton.Text = "Сделать заказ";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // ClientMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 148);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.productButton);
            this.Name = "ClientMenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMenuView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMenuView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button productButton;
    }
}