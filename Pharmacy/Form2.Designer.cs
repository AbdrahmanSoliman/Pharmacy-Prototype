namespace Pharmacy
{
    partial class Form2
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
            this.medRemoval = new System.Windows.Forms.TextBox();
            this.nameOfMed = new System.Windows.Forms.TextBox();
            this.qntOfMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.removeMed = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.med = new System.Windows.Forms.TextBox();
            this.qnt = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pri = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Button();
            this.thestock = new System.Windows.Forms.Button();
            this.upgradeP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.upbutton = new System.Windows.Forms.Button();
            this.upgradeN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.Cart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medRemoval
            // 
            this.medRemoval.Location = new System.Drawing.Point(452, 293);
            this.medRemoval.Name = "medRemoval";
            this.medRemoval.Size = new System.Drawing.Size(100, 20);
            this.medRemoval.TabIndex = 0;
            // 
            // nameOfMed
            // 
            this.nameOfMed.Location = new System.Drawing.Point(452, 351);
            this.nameOfMed.Name = "nameOfMed";
            this.nameOfMed.Size = new System.Drawing.Size(100, 20);
            this.nameOfMed.TabIndex = 1;
            // 
            // qntOfMed
            // 
            this.qntOfMed.Location = new System.Drawing.Point(452, 382);
            this.qntOfMed.Name = "qntOfMed";
            this.qntOfMed.Size = new System.Drawing.Size(100, 20);
            this.qntOfMed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUANTITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADD A NEW MEDICINE : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "EXPIRED MEDICINE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "NAME";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(605, 379);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Submit";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // removeMed
            // 
            this.removeMed.Location = new System.Drawing.Point(605, 290);
            this.removeMed.Name = "removeMed";
            this.removeMed.Size = new System.Drawing.Size(75, 23);
            this.removeMed.TabIndex = 9;
            this.removeMed.Text = "Remove";
            this.removeMed.UseVisualStyleBackColor = true;
            this.removeMed.Click += new System.EventHandler(this.removeMed_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TYPES OF MEDICINES";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(477, 222);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 11;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // med
            // 
            this.med.Location = new System.Drawing.Point(410, 39);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(100, 20);
            this.med.TabIndex = 12;
            // 
            // qnt
            // 
            this.qnt.Location = new System.Drawing.Point(410, 79);
            this.qnt.Name = "qnt";
            this.qnt.Size = new System.Drawing.Size(100, 20);
            this.qnt.TabIndex = 13;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(678, 61);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 14;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Medicine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 39);
            this.label9.TabIndex = 18;
            this.label9.Text = "Order : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-6, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(823, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // pri
            // 
            this.pri.Location = new System.Drawing.Point(452, 418);
            this.pri.Name = "pri";
            this.pri.Size = new System.Drawing.Size(100, 20);
            this.pri.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "PRICE";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(0, 269);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(56, 182);
            this.balance.TabIndex = 22;
            this.balance.Text = "Balance";
            this.balance.UseVisualStyleBackColor = true;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // thestock
            // 
            this.thestock.Location = new System.Drawing.Point(743, 272);
            this.thestock.Name = "thestock";
            this.thestock.Size = new System.Drawing.Size(56, 182);
            this.thestock.TabIndex = 23;
            this.thestock.Text = "Stock";
            this.thestock.UseVisualStyleBackColor = true;
            this.thestock.Click += new System.EventHandler(this.thestock_Click);
            // 
            // upgradeP
            // 
            this.upgradeP.Location = new System.Drawing.Point(452, 524);
            this.upgradeP.Name = "upgradeP";
            this.upgradeP.Size = new System.Drawing.Size(100, 20);
            this.upgradeP.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 527);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "NEW PRICE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "UPDGRADE MEDICINE PRICE : ";
            // 
            // upbutton
            // 
            this.upbutton.Location = new System.Drawing.Point(605, 507);
            this.upbutton.Name = "upbutton";
            this.upbutton.Size = new System.Drawing.Size(75, 23);
            this.upbutton.TabIndex = 27;
            this.upbutton.Text = "Upgrade";
            this.upbutton.UseVisualStyleBackColor = true;
            this.upbutton.Click += new System.EventHandler(this.upbutton_Click);
            // 
            // upgradeN
            // 
            this.upgradeN.Location = new System.Drawing.Point(452, 489);
            this.upgradeN.Name = "upgradeN";
            this.upgradeN.Size = new System.Drawing.Size(100, 20);
            this.upgradeN.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "NAME";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(0, 537);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(54, 63);
            this.LogOut.TabIndex = 30;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(560, 61);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(52, 23);
            this.Cart.TabIndex = 31;
            this.Cart.Text = "Cart";
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.upgradeN);
            this.Controls.Add(this.upbutton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.upgradeP);
            this.Controls.Add(this.thestock);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pri);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.qnt);
            this.Controls.Add(this.med);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.removeMed);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qntOfMed);
            this.Controls.Add(this.nameOfMed);
            this.Controls.Add(this.medRemoval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unique Pharma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox medRemoval;
        private System.Windows.Forms.TextBox nameOfMed;
        private System.Windows.Forms.TextBox qntOfMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button removeMed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox med;
        private System.Windows.Forms.TextBox qnt;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.Button thestock;
        private System.Windows.Forms.TextBox upgradeP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button upbutton;
        private System.Windows.Forms.TextBox upgradeN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Cart;
    }
}