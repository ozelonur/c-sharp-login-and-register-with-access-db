namespace login_register_forms
{
    partial class Register
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
            this.adTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kAdiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tcTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kayitOlButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(16, 32);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(307, 20);
            this.adTxt.TabIndex = 1;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(16, 78);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(307, 20);
            this.soyadTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // kAdiTxt
            // 
            this.kAdiTxt.Location = new System.Drawing.Point(16, 124);
            this.kAdiTxt.Name = "kAdiTxt";
            this.kAdiTxt.Size = new System.Drawing.Size(307, 20);
            this.kAdiTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(16, 170);
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(307, 20);
            this.tcTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "T.C. Kimlik No";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(16, 216);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(307, 20);
            this.sifreTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Şifre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kayitOlButon
            // 
            this.kayitOlButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitOlButon.Location = new System.Drawing.Point(16, 242);
            this.kayitOlButon.Name = "kayitOlButon";
            this.kayitOlButon.Size = new System.Drawing.Size(307, 105);
            this.kayitOlButon.TabIndex = 10;
            this.kayitOlButon.Text = "Kayıt Ol";
            this.kayitOlButon.UseVisualStyleBackColor = true;
            this.kayitOlButon.Click += new System.EventHandler(this.kayitOlButon_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 377);
            this.Controls.Add(this.kayitOlButon);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kAdiTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kAdiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kayitOlButon;
    }
}