namespace Lb1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkCS = new System.Windows.Forms.CheckBox();
            this.lblErrorToppings = new System.Windows.Forms.Label();
            this.chkLime = new System.Windows.Forms.CheckBox();
            this.chkPeach = new System.Windows.Forms.CheckBox();
            this.chkMango = new System.Windows.Forms.CheckBox();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblOrderBox = new System.Windows.Forms.Label();
            this.lblErrorMixins = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What name do you want on the order?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 239);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 19);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add item to order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(414, 240);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 4;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Location = new System.Drawing.Point(12, 51);
            this.lblErrorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 13);
            this.lblErrorName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do you want a sundae?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Do you want a soda?";
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(14, 102);
            this.chkSundae.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(44, 17);
            this.chkSundae.TabIndex = 8;
            this.chkSundae.Text = "Yes";
            this.chkSundae.UseVisualStyleBackColor = true;
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Location = new System.Drawing.Point(170, 102);
            this.chkSoda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(44, 17);
            this.chkSoda.TabIndex = 9;
            this.chkSoda.Text = "Yes";
            this.chkSoda.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sundae Toppings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Drink Mixins";
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Location = new System.Drawing.Point(14, 156);
            this.chkSprinkles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(69, 17);
            this.chkSprinkles.TabIndex = 12;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(14, 178);
            this.chkNuts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(48, 17);
            this.chkNuts.TabIndex = 13;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkCS
            // 
            this.chkCS.AutoSize = true;
            this.chkCS.Location = new System.Drawing.Point(14, 200);
            this.chkCS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCS.Name = "chkCS";
            this.chkCS.Size = new System.Drawing.Size(104, 17);
            this.chkCS.TabIndex = 14;
            this.chkCS.Text = "Chocolate Syrup";
            this.chkCS.UseVisualStyleBackColor = true;
            // 
            // lblErrorToppings
            // 
            this.lblErrorToppings.AutoSize = true;
            this.lblErrorToppings.Location = new System.Drawing.Point(14, 223);
            this.lblErrorToppings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorToppings.Name = "lblErrorToppings";
            this.lblErrorToppings.Size = new System.Drawing.Size(0, 13);
            this.lblErrorToppings.TabIndex = 15;
            // 
            // chkLime
            // 
            this.chkLime.AutoSize = true;
            this.chkLime.Location = new System.Drawing.Point(170, 156);
            this.chkLime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLime.Name = "chkLime";
            this.chkLime.Size = new System.Drawing.Size(80, 17);
            this.chkLime.TabIndex = 16;
            this.chkLime.Text = "Lime Flavor";
            this.chkLime.UseVisualStyleBackColor = true;
            // 
            // chkPeach
            // 
            this.chkPeach.AutoSize = true;
            this.chkPeach.Location = new System.Drawing.Point(170, 178);
            this.chkPeach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPeach.Name = "chkPeach";
            this.chkPeach.Size = new System.Drawing.Size(89, 17);
            this.chkPeach.TabIndex = 17;
            this.chkPeach.Text = "Peach Flavor";
            this.chkPeach.UseVisualStyleBackColor = true;
            // 
            // chkMango
            // 
            this.chkMango.AutoSize = true;
            this.chkMango.Location = new System.Drawing.Point(170, 200);
            this.chkMango.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMango.Name = "chkMango";
            this.chkMango.Size = new System.Drawing.Size(91, 17);
            this.chkMango.TabIndex = 18;
            this.chkMango.Text = "Mango Flavor";
            this.chkMango.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblOrderBox);
            this.grpBox.Location = new System.Drawing.Point(317, 29);
            this.grpBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBox.Name = "grpBox";
            this.grpBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBox.Size = new System.Drawing.Size(200, 188);
            this.grpBox.TabIndex = 19;
            this.grpBox.TabStop = false;
            // 
            // lblOrderBox
            // 
            this.lblOrderBox.AutoSize = true;
            this.lblOrderBox.Location = new System.Drawing.Point(5, 11);
            this.lblOrderBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderBox.Name = "lblOrderBox";
            this.lblOrderBox.Size = new System.Drawing.Size(0, 13);
            this.lblOrderBox.TabIndex = 0;
            // 
            // lblErrorMixins
            // 
            this.lblErrorMixins.AutoSize = true;
            this.lblErrorMixins.Location = new System.Drawing.Point(170, 222);
            this.lblErrorMixins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMixins.Name = "lblErrorMixins";
            this.lblErrorMixins.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMixins.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 271);
            this.Controls.Add(this.lblErrorMixins);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.chkMango);
            this.Controls.Add(this.chkPeach);
            this.Controls.Add(this.chkLime);
            this.Controls.Add(this.lblErrorToppings);
            this.Controls.Add(this.chkCS);
            this.Controls.Add(this.chkNuts);
            this.Controls.Add(this.chkSprinkles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkSoda);
            this.Controls.Add(this.chkSundae);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Food Order";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkCS;
        private System.Windows.Forms.Label lblErrorToppings;
        private System.Windows.Forms.CheckBox chkLime;
        private System.Windows.Forms.CheckBox chkPeach;
        private System.Windows.Forms.CheckBox chkMango;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lblOrderBox;
        private System.Windows.Forms.Label lblErrorMixins;
    }
}

