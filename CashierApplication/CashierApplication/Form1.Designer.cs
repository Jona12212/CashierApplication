namespace ItemNamespace
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_totalAmount = new System.Windows.Forms.TextBox();
            this.tb_paymentReceived = new System.Windows.Forms.TextBox();
            this.tb_change = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.Location = new System.Drawing.Point(331, 221);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(100, 25);
            this.bt_submit.TabIndex = 1;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discount(%): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Amount: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Payment Received:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Change:";
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(16, 52);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(245, 20);
            this.tb_item.TabIndex = 9;
            // 
            // tb_discount
            // 
            this.tb_discount.Location = new System.Drawing.Point(301, 52);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(154, 20);
            this.tb_discount.TabIndex = 10;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(66, 91);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(195, 20);
            this.tb_price.TabIndex = 11;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(357, 93);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(98, 20);
            this.tb_quantity.TabIndex = 12;
            // 
            // tb_totalAmount
            // 
            this.tb_totalAmount.Location = new System.Drawing.Point(157, 171);
            this.tb_totalAmount.Name = "tb_totalAmount";
            this.tb_totalAmount.ReadOnly = true;
            this.tb_totalAmount.Size = new System.Drawing.Size(116, 20);
            this.tb_totalAmount.TabIndex = 13;
            // 
            // tb_paymentReceived
            // 
            this.tb_paymentReceived.Location = new System.Drawing.Point(166, 223);
            this.tb_paymentReceived.Name = "tb_paymentReceived";
            this.tb_paymentReceived.Size = new System.Drawing.Size(146, 20);
            this.tb_paymentReceived.TabIndex = 14;
            // 
            // tb_change
            // 
            this.tb_change.Location = new System.Drawing.Point(148, 275);
            this.tb_change.Name = "tb_change";
            this.tb_change.ReadOnly = true;
            this.tb_change.Size = new System.Drawing.Size(113, 20);
            this.tb_change.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.tb_change);
            this.Controls.Add(this.tb_paymentReceived);
            this.Controls.Add(this.tb_totalAmount);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_discount);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "frmPurchaseDiscountedItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_totalAmount;
        private System.Windows.Forms.TextBox tb_paymentReceived;
        private System.Windows.Forms.TextBox tb_change;
    }
}

