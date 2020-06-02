namespace login_register_forms
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
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.girisYapButon = new System.Windows.Forms.Button();
            this.kaydolLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(6, 23);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(247, 20);
            this.kullaniciAdiTxt.TabIndex = 1;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(4, 69);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(247, 20);
            this.sifreTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // girisYapButon
            // 
            this.girisYapButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisYapButon.Location = new System.Drawing.Point(4, 95);
            this.girisYapButon.Name = "girisYapButon";
            this.girisYapButon.Size = new System.Drawing.Size(247, 67);
            this.girisYapButon.TabIndex = 4;
            this.girisYapButon.Text = "Giriş Yap";
            this.girisYapButon.UseVisualStyleBackColor = true;
            this.girisYapButon.Click += new System.EventHandler(this.girisYapButon_Click);
            // 
            // kaydolLink
            // 
            this.kaydolLink.AutoSize = true;
            this.kaydolLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydolLink.Location = new System.Drawing.Point(12, 165);
            this.kaydolLink.Name = "kaydolLink";
            this.kaydolLink.Size = new System.Drawing.Size(240, 16);
            this.kaydolLink.TabIndex = 5;
            this.kaydolLink.TabStop = true;
            this.kaydolLink.Text = "Hesabın mı yok ? Hemen Kaydol !";
            this.kaydolLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kaydolLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 203);
            this.Controls.Add(this.kaydolLink);
            this.Controls.Add(this.girisYapButon);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisYapButon;
        private System.Windows.Forms.LinkLabel kaydolLink;
    }
}

