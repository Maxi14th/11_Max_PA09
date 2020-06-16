namespace _11_Max_PA09
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
            this.btnconvert = new System.Windows.Forms.Button();
            this.rdbjapaneseyen = new System.Windows.Forms.RadioButton();
            this.rdbusdollar = new System.Windows.Forms.RadioButton();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtconvertedamount = new System.Windows.Forms.TextBox();
            this.lblselectcurrency = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(578, 199);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(75, 23);
            this.btnconvert.TabIndex = 0;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // rdbjapaneseyen
            // 
            this.rdbjapaneseyen.AutoSize = true;
            this.rdbjapaneseyen.Location = new System.Drawing.Point(383, 205);
            this.rdbjapaneseyen.Name = "rdbjapaneseyen";
            this.rdbjapaneseyen.Size = new System.Drawing.Size(93, 17);
            this.rdbjapaneseyen.TabIndex = 2;
            this.rdbjapaneseyen.TabStop = true;
            this.rdbjapaneseyen.Text = "Japanese Yen";
            this.rdbjapaneseyen.UseVisualStyleBackColor = true;
            // 
            // rdbusdollar
            // 
            this.rdbusdollar.AutoSize = true;
            this.rdbusdollar.Location = new System.Drawing.Point(383, 243);
            this.rdbusdollar.Name = "rdbusdollar";
            this.rdbusdollar.Size = new System.Drawing.Size(70, 17);
            this.rdbusdollar.TabIndex = 3;
            this.rdbusdollar.TabStop = true;
            this.rdbusdollar.Text = "US Dollar";
            this.rdbusdollar.UseVisualStyleBackColor = true;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(383, 116);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 4;
            // 
            // txtconvertedamount
            // 
            this.txtconvertedamount.Location = new System.Drawing.Point(383, 309);
            this.txtconvertedamount.Name = "txtconvertedamount";
            this.txtconvertedamount.Size = new System.Drawing.Size(100, 20);
            this.txtconvertedamount.TabIndex = 5;
            // 
            // lblselectcurrency
            // 
            this.lblselectcurrency.AutoSize = true;
            this.lblselectcurrency.Location = new System.Drawing.Point(185, 208);
            this.lblselectcurrency.Name = "lblselectcurrency";
            this.lblselectcurrency.Size = new System.Drawing.Size(82, 13);
            this.lblselectcurrency.TabIndex = 6;
            this.lblselectcurrency.Text = "Select Currency";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(188, 116);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(43, 13);
            this.lblamount.TabIndex = 7;
            this.lblamount.Text = "Amount";
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Location = new System.Drawing.Point(188, 315);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(34, 13);
            this.lblvalue.TabIndex = 8;
            this.lblvalue.Text = "Value";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(578, 243);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblvalue);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblselectcurrency);
            this.Controls.Add(this.txtconvertedamount);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.rdbusdollar);
            this.Controls.Add(this.rdbjapaneseyen);
            this.Controls.Add(this.btnconvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.RadioButton rdbjapaneseyen;
        private System.Windows.Forms.RadioButton rdbusdollar;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtconvertedamount;
        private System.Windows.Forms.Label lblselectcurrency;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.Button btnclear;
    }
}

