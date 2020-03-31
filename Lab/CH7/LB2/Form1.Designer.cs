namespace LB2
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtEstDelivery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(36, 144);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(268, 19);
            this.lblResult.TabIndex = 15;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(198, 102);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(103, 19);
            this.btnValidate.TabIndex = 14;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtEstDelivery
            // 
            this.txtEstDelivery.Location = new System.Drawing.Point(198, 79);
            this.txtEstDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstDelivery.Name = "txtEstDelivery";
            this.txtEstDelivery.Size = new System.Drawing.Size(104, 20);
            this.txtEstDelivery.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estimated Delivery Days [1, 30]:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(198, 56);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(104, 20);
            this.txtQuantity.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity [ 1, 12 ]:";
            // 
            // txtItemNum
            // 
            this.txtItemNum.Location = new System.Drawing.Point(198, 33);
            this.txtItemNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemNum.Name = "txtItemNum";
            this.txtItemNum.Size = new System.Drawing.Size(104, 20);
            this.txtItemNum.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Number [ 100, 999 ]:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 168);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtEstDelivery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtEstDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemNum;
        private System.Windows.Forms.Label label1;
    }
}

