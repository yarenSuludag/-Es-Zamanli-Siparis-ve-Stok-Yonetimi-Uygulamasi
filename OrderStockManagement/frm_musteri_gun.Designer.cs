namespace OrderStockManagement
{
    partial class frm_musteri_gun
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerBudgetTextBox = new System.Windows.Forms.TextBox();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bütçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşteri Türü:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(157, 56);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(199, 22);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // customerBudgetTextBox
            // 
            this.customerBudgetTextBox.Location = new System.Drawing.Point(157, 108);
            this.customerBudgetTextBox.Name = "customerBudgetTextBox";
            this.customerBudgetTextBox.Size = new System.Drawing.Size(199, 22);
            this.customerBudgetTextBox.TabIndex = 4;
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Premium",
            "Standard"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(157, 154);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(199, 24);
            this.customerTypeComboBox.TabIndex = 5;
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(157, 198);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(199, 37);
            this.updateCustomerButton.TabIndex = 6;
            this.updateCustomerButton.Text = "Müşteri Güncelle";
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // frm_musteri_gun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 285);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.customerTypeComboBox);
            this.Controls.Add(this.customerBudgetTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_musteri_gun";
            this.Text = "Müşteri Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerBudgetTextBox;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Button updateCustomerButton;
    }
}
