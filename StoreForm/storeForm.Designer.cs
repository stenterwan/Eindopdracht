namespace StoreForm
{
    partial class storeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.ListBox();
            this.products = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products";
            // 
            // inventory
            // 
            this.inventory.FormattingEnabled = true;
            this.inventory.Location = new System.Drawing.Point(32, 40);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(225, 134);
            this.inventory.TabIndex = 2;
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(333, 40);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(217, 134);
            this.products.TabIndex = 3;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(333, 208);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 5;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(475, 208);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(333, 192);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 7;
            // 
            // storeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 261);
            this.Controls.Add(this.error);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.products);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "storeForm";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.storeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox inventory;
        private System.Windows.Forms.ListBox products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label error;
    }
}