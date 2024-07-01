namespace Odev2
{
    partial class CarpismaDenetimi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoktaDortgen = new System.Windows.Forms.CheckBox();
            this.NoktaCember = new System.Windows.Forms.CheckBox();
            this.DikdortgenDikdortgen = new System.Windows.Forms.CheckBox();
            this.DikdortgenCember = new System.Windows.Forms.CheckBox();
            this.CemberCember = new System.Windows.Forms.CheckBox();
            this.NoktaKure = new System.Windows.Forms.CheckBox();
            this.NoktaDikdortgen = new System.Windows.Forms.CheckBox();
            this.NoktaSilindir = new System.Windows.Forms.CheckBox();
            this.DikdortgenPrizmasıDikdortgenPrizması = new System.Windows.Forms.CheckBox();
            this.KureDikdortgenPrizması = new System.Windows.Forms.CheckBox();
            this.YuzeySilindir = new System.Windows.Forms.CheckBox();
            this.YüzeyDikdortgen = new System.Windows.Forms.CheckBox();
            this.YüzeyKure = new System.Windows.Forms.CheckBox();
            this.KureSilindir = new System.Windows.Forms.CheckBox();
            this.KureKure = new System.Windows.Forms.CheckBox();
            this.SilindirSilindir = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxBilgi = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoktaDortgen
            // 
            this.NoktaDortgen.AutoSize = true;
            this.NoktaDortgen.Location = new System.Drawing.Point(504, 49);
            this.NoktaDortgen.Name = "NoktaDortgen";
            this.NoktaDortgen.Size = new System.Drawing.Size(123, 20);
            this.NoktaDortgen.TabIndex = 0;
            this.NoktaDortgen.Text = "Nokta - Dörtgen";
            this.NoktaDortgen.UseVisualStyleBackColor = true;
            this.NoktaDortgen.CheckedChanged += new System.EventHandler(this.NoktaDortgen_CheckedChanged);
            // 
            // NoktaCember
            // 
            this.NoktaCember.AutoSize = true;
            this.NoktaCember.Location = new System.Drawing.Point(503, 75);
            this.NoktaCember.Name = "NoktaCember";
            this.NoktaCember.Size = new System.Drawing.Size(120, 20);
            this.NoktaCember.TabIndex = 1;
            this.NoktaCember.Text = "Nokta- Çember";
            this.NoktaCember.UseVisualStyleBackColor = true;
            this.NoktaCember.CheckedChanged += new System.EventHandler(this.NoktaCember_CheckedChanged);
            // 
            // DikdortgenDikdortgen
            // 
            this.DikdortgenDikdortgen.AutoSize = true;
            this.DikdortgenDikdortgen.Location = new System.Drawing.Point(503, 101);
            this.DikdortgenDikdortgen.Name = "DikdortgenDikdortgen";
            this.DikdortgenDikdortgen.Size = new System.Drawing.Size(171, 20);
            this.DikdortgenDikdortgen.TabIndex = 2;
            this.DikdortgenDikdortgen.Text = "Dikdörtgen - Dikdörtgen";
            this.DikdortgenDikdortgen.UseVisualStyleBackColor = true;
            this.DikdortgenDikdortgen.CheckedChanged += new System.EventHandler(this.DikdortgenDikdortgen_CheckedChanged);
            // 
            // DikdortgenCember
            // 
            this.DikdortgenCember.AutoSize = true;
            this.DikdortgenCember.Location = new System.Drawing.Point(503, 127);
            this.DikdortgenCember.Name = "DikdortgenCember";
            this.DikdortgenCember.Size = new System.Drawing.Size(153, 20);
            this.DikdortgenCember.TabIndex = 3;
            this.DikdortgenCember.Text = "Dikdörtgen - Çember";
            this.DikdortgenCember.UseVisualStyleBackColor = true;
            this.DikdortgenCember.CheckedChanged += new System.EventHandler(this.DikdortgenCember_CheckedChanged);
            // 
            // CemberCember
            // 
            this.CemberCember.AutoSize = true;
            this.CemberCember.Location = new System.Drawing.Point(503, 153);
            this.CemberCember.Name = "CemberCember";
            this.CemberCember.Size = new System.Drawing.Size(141, 20);
            this.CemberCember.TabIndex = 4;
            this.CemberCember.Text = "Çember -  Çember ";
            this.CemberCember.UseVisualStyleBackColor = true;
            this.CemberCember.CheckedChanged += new System.EventHandler(this.CemberCember_CheckedChanged);
            // 
            // NoktaKure
            // 
            this.NoktaKure.AutoSize = true;
            this.NoktaKure.Location = new System.Drawing.Point(503, 179);
            this.NoktaKure.Name = "NoktaKure";
            this.NoktaKure.Size = new System.Drawing.Size(108, 20);
            this.NoktaKure.TabIndex = 5;
            this.NoktaKure.Text = "Nokta -  Küre ";
            this.NoktaKure.UseVisualStyleBackColor = true;
            this.NoktaKure.CheckedChanged += new System.EventHandler(this.NoktaKure_CheckedChanged);
            // 
            // NoktaDikdortgen
            // 
            this.NoktaDikdortgen.AutoSize = true;
            this.NoktaDikdortgen.Location = new System.Drawing.Point(503, 205);
            this.NoktaDikdortgen.Name = "NoktaDikdortgen";
            this.NoktaDikdortgen.Size = new System.Drawing.Size(185, 20);
            this.NoktaDikdortgen.TabIndex = 6;
            this.NoktaDikdortgen.Text = "Nokta - Dikdörtgen Prizma";
            this.NoktaDikdortgen.UseVisualStyleBackColor = true;
            this.NoktaDikdortgen.CheckedChanged += new System.EventHandler(this.NoktaDikdortgen_CheckedChanged);
            // 
            // NoktaSilindir
            // 
            this.NoktaSilindir.AutoSize = true;
            this.NoktaSilindir.Location = new System.Drawing.Point(503, 231);
            this.NoktaSilindir.Name = "NoktaSilindir";
            this.NoktaSilindir.Size = new System.Drawing.Size(118, 20);
            this.NoktaSilindir.TabIndex = 7;
            this.NoktaSilindir.Text = "Nokta - Silindir ";
            this.NoktaSilindir.UseVisualStyleBackColor = true;
            this.NoktaSilindir.CheckedChanged += new System.EventHandler(this.NoktaSilindir_CheckedChanged);
            // 
            // DikdortgenPrizmasıDikdortgenPrizması
            // 
            this.DikdortgenPrizmasıDikdortgenPrizması.AutoSize = true;
            this.DikdortgenPrizmasıDikdortgenPrizması.Location = new System.Drawing.Point(504, 440);
            this.DikdortgenPrizmasıDikdortgenPrizması.Name = "DikdortgenPrizmasıDikdortgenPrizması";
            this.DikdortgenPrizmasıDikdortgenPrizması.Size = new System.Drawing.Size(262, 20);
            this.DikdortgenPrizmasıDikdortgenPrizması.TabIndex = 8;
            this.DikdortgenPrizmasıDikdortgenPrizması.Text = "Dikdörtgen Prizma - Dikdörtgen Prizma ";
            this.DikdortgenPrizmasıDikdortgenPrizması.UseVisualStyleBackColor = true;
            this.DikdortgenPrizmasıDikdortgenPrizması.CheckedChanged += new System.EventHandler(this.DikdortgenPrizmasıDikdortgenPrizması_CheckedChanged);
            // 
            // KureDikdortgenPrizması
            // 
            this.KureDikdortgenPrizması.AutoSize = true;
            this.KureDikdortgenPrizması.Location = new System.Drawing.Point(503, 414);
            this.KureDikdortgenPrizması.Name = "KureDikdortgenPrizması";
            this.KureDikdortgenPrizması.Size = new System.Drawing.Size(179, 20);
            this.KureDikdortgenPrizması.TabIndex = 9;
            this.KureDikdortgenPrizması.Text = "Küre - Dikdörtgen Prizma ";
            this.KureDikdortgenPrizması.UseVisualStyleBackColor = true;
            this.KureDikdortgenPrizması.CheckedChanged += new System.EventHandler(this.KureDikdortgenPrizması_CheckedChanged);
            // 
            // YuzeySilindir
            // 
            this.YuzeySilindir.AutoSize = true;
            this.YuzeySilindir.Location = new System.Drawing.Point(503, 388);
            this.YuzeySilindir.Name = "YuzeySilindir";
            this.YuzeySilindir.Size = new System.Drawing.Size(119, 20);
            this.YuzeySilindir.TabIndex = 10;
            this.YuzeySilindir.Text = "Yüzey - Silindir ";
            this.YuzeySilindir.UseVisualStyleBackColor = true;
            this.YuzeySilindir.CheckedChanged += new System.EventHandler(this.YuzeySilindir_CheckedChanged);
            // 
            // YüzeyDikdortgen
            // 
            this.YüzeyDikdortgen.AutoSize = true;
            this.YüzeyDikdortgen.Location = new System.Drawing.Point(503, 362);
            this.YüzeyDikdortgen.Name = "YüzeyDikdortgen";
            this.YüzeyDikdortgen.Size = new System.Drawing.Size(186, 20);
            this.YüzeyDikdortgen.TabIndex = 11;
            this.YüzeyDikdortgen.Text = "Yüzey - Dikdörtgen Prizma";
            this.YüzeyDikdortgen.UseVisualStyleBackColor = true;
            this.YüzeyDikdortgen.CheckedChanged += new System.EventHandler(this.YüzeyDikdortgen_CheckedChanged);
            // 
            // YüzeyKure
            // 
            this.YüzeyKure.AutoSize = true;
            this.YüzeyKure.Location = new System.Drawing.Point(504, 336);
            this.YüzeyKure.Name = "YüzeyKure";
            this.YüzeyKure.Size = new System.Drawing.Size(106, 20);
            this.YüzeyKure.TabIndex = 12;
            this.YüzeyKure.Text = "Yüzey -  Küre";
            this.YüzeyKure.UseVisualStyleBackColor = true;
            this.YüzeyKure.CheckedChanged += new System.EventHandler(this.YüzeyKure_CheckedChanged);
            // 
            // KureSilindir
            // 
            this.KureSilindir.AutoSize = true;
            this.KureSilindir.Location = new System.Drawing.Point(503, 310);
            this.KureSilindir.Name = "KureSilindir";
            this.KureSilindir.Size = new System.Drawing.Size(109, 20);
            this.KureSilindir.TabIndex = 13;
            this.KureSilindir.Text = "Küre - Silindir ";
            this.KureSilindir.UseVisualStyleBackColor = true;
            this.KureSilindir.CheckedChanged += new System.EventHandler(this.KureSilindir_CheckedChanged);
            // 
            // KureKure
            // 
            this.KureKure.AutoSize = true;
            this.KureKure.Location = new System.Drawing.Point(503, 284);
            this.KureKure.Name = "KureKure";
            this.KureKure.Size = new System.Drawing.Size(96, 20);
            this.KureKure.TabIndex = 14;
            this.KureKure.Text = "Küre -  Küre";
            this.KureKure.UseVisualStyleBackColor = true;
            this.KureKure.CheckedChanged += new System.EventHandler(this.KureKure_CheckedChanged);
            // 
            // SilindirSilindir
            // 
            this.SilindirSilindir.AutoSize = true;
            this.SilindirSilindir.Location = new System.Drawing.Point(503, 258);
            this.SilindirSilindir.Name = "SilindirSilindir";
            this.SilindirSilindir.Size = new System.Drawing.Size(119, 20);
            this.SilindirSilindir.TabIndex = 15;
            this.SilindirSilindir.Text = "Silindir - Silindir";
            this.SilindirSilindir.UseVisualStyleBackColor = true;
            this.SilindirSilindir.CheckedChanged += new System.EventHandler(this.SilindirSilindir_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "TEST ET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 443);
            this.panel1.TabIndex = 17;
            // 
            // richTextBoxBilgi
            // 
            this.richTextBoxBilgi.BackColor = System.Drawing.Color.White;
            this.richTextBoxBilgi.Location = new System.Drawing.Point(6, 520);
            this.richTextBoxBilgi.Name = "richTextBoxBilgi";
            this.richTextBoxBilgi.ReadOnly = true;
            this.richTextBoxBilgi.Size = new System.Drawing.Size(802, 70);
            this.richTextBoxBilgi.TabIndex = 18;
            this.richTextBoxBilgi.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "TEST ETMEK İSTEDİĞİNİZ CİSİMLERİ SEÇİNİZ";
            // 
            // CarpismaDenetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoktaDortgen);
            this.Controls.Add(this.NoktaCember);
            this.Controls.Add(this.richTextBoxBilgi);
            this.Controls.Add(this.DikdortgenDikdortgen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DikdortgenCember);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CemberCember);
            this.Controls.Add(this.SilindirSilindir);
            this.Controls.Add(this.NoktaKure);
            this.Controls.Add(this.KureKure);
            this.Controls.Add(this.NoktaDikdortgen);
            this.Controls.Add(this.KureSilindir);
            this.Controls.Add(this.NoktaSilindir);
            this.Controls.Add(this.YüzeyKure);
            this.Controls.Add(this.YüzeyDikdortgen);
            this.Controls.Add(this.YuzeySilindir);
            this.Controls.Add(this.KureDikdortgenPrizması);
            this.Controls.Add(this.DikdortgenPrizmasıDikdortgenPrizması);
            this.Name = "CarpismaDenetimi";
            this.Text = "ÇARPIŞMA DENETİMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NoktaDortgen;
        private System.Windows.Forms.CheckBox NoktaCember;
        private System.Windows.Forms.CheckBox DikdortgenDikdortgen;
        private System.Windows.Forms.CheckBox DikdortgenCember;
        private System.Windows.Forms.CheckBox CemberCember;
        private System.Windows.Forms.CheckBox NoktaKure;
        private System.Windows.Forms.CheckBox NoktaDikdortgen;
        private System.Windows.Forms.CheckBox NoktaSilindir;
        private System.Windows.Forms.CheckBox DikdortgenPrizmasıDikdortgenPrizması;
        private System.Windows.Forms.CheckBox KureDikdortgenPrizması;
        private System.Windows.Forms.CheckBox YuzeySilindir;
        private System.Windows.Forms.CheckBox YüzeyDikdortgen;
        private System.Windows.Forms.CheckBox YüzeyKure;
        private System.Windows.Forms.CheckBox KureSilindir;
        private System.Windows.Forms.CheckBox KureKure;
        private System.Windows.Forms.CheckBox SilindirSilindir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxBilgi;
        private System.Windows.Forms.Label label1;
    }
}

