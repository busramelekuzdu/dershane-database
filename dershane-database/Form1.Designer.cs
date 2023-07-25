namespace dershane_database
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
            this.ogrenciisimtextbox = new System.Windows.Forms.TextBox();
            this.ogrenciisim = new System.Windows.Forms.Label();
            this.kayitbutton = new System.Windows.Forms.Button();
            this.cinisyetgroupbox = new System.Windows.Forms.GroupBox();
            this.erkekradiobutton = new System.Windows.Forms.RadioButton();
            this.kadinradiobutton = new System.Windows.Forms.RadioButton();
            this.ogrencimaskedtextbox = new System.Windows.Forms.MaskedTextBox();
            this.adresrichtextbox = new System.Windows.Forms.RichTextBox();
            this.ogrencisoyisim = new System.Windows.Forms.Label();
            this.ogrencisoyisimtextbox = new System.Windows.Forms.TextBox();
            this.ogrencinumara = new System.Windows.Forms.Label();
            this.velinumara = new System.Windows.Forms.Label();
            this.velisoyisim = new System.Windows.Forms.Label();
            this.veliisim = new System.Windows.Forms.Label();
            this.velisoyisimtextbox = new System.Windows.Forms.TextBox();
            this.veliisimtextbox = new System.Windows.Forms.TextBox();
            this.velinumaramaskedtextbox = new System.Windows.Forms.MaskedTextBox();
            this.adres = new System.Windows.Forms.Label();
            this.ogrencitcnomaskedtextbox = new System.Windows.Forms.MaskedTextBox();
            this.ogrencitcno = new System.Windows.Forms.Label();
            this.velitcno = new System.Windows.Forms.Label();
            this.velitcnomaskedtextbox = new System.Windows.Forms.MaskedTextBox();
            this.kayittarihi = new System.Windows.Forms.Label();
            this.kayittarihidateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cinisyetgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrenciisimtextbox
            // 
            this.ogrenciisimtextbox.BackColor = System.Drawing.Color.Silver;
            this.ogrenciisimtextbox.Location = new System.Drawing.Point(154, 33);
            this.ogrenciisimtextbox.Name = "ogrenciisimtextbox";
            this.ogrenciisimtextbox.Size = new System.Drawing.Size(194, 20);
            this.ogrenciisimtextbox.TabIndex = 0;
            // 
            // ogrenciisim
            // 
            this.ogrenciisim.AutoSize = true;
            this.ogrenciisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciisim.Location = new System.Drawing.Point(6, 33);
            this.ogrenciisim.Name = "ogrenciisim";
            this.ogrenciisim.Size = new System.Drawing.Size(101, 20);
            this.ogrenciisim.TabIndex = 1;
            this.ogrenciisim.Text = "Öğrenci İsim:";
            // 
            // kayitbutton
            // 
            this.kayitbutton.BackColor = System.Drawing.Color.DarkSalmon;
            this.kayitbutton.Location = new System.Drawing.Point(618, 277);
            this.kayitbutton.Name = "kayitbutton";
            this.kayitbutton.Size = new System.Drawing.Size(109, 45);
            this.kayitbutton.TabIndex = 2;
            this.kayitbutton.Text = "KAYIT";
            this.kayitbutton.UseVisualStyleBackColor = false;
            this.kayitbutton.Click += new System.EventHandler(this.kayitbutton_Click);
            // 
            // cinisyetgroupbox
            // 
            this.cinisyetgroupbox.Controls.Add(this.erkekradiobutton);
            this.cinisyetgroupbox.Controls.Add(this.kadinradiobutton);
            this.cinisyetgroupbox.Location = new System.Drawing.Point(21, 277);
            this.cinisyetgroupbox.Name = "cinisyetgroupbox";
            this.cinisyetgroupbox.Size = new System.Drawing.Size(102, 87);
            this.cinisyetgroupbox.TabIndex = 3;
            this.cinisyetgroupbox.TabStop = false;
            this.cinisyetgroupbox.Text = "Cinsiyet";
            // 
            // erkekradiobutton
            // 
            this.erkekradiobutton.AutoSize = true;
            this.erkekradiobutton.Location = new System.Drawing.Point(15, 51);
            this.erkekradiobutton.Name = "erkekradiobutton";
            this.erkekradiobutton.Size = new System.Drawing.Size(52, 17);
            this.erkekradiobutton.TabIndex = 6;
            this.erkekradiobutton.TabStop = true;
            this.erkekradiobutton.Text = "erkek";
            this.erkekradiobutton.UseVisualStyleBackColor = true;
            // 
            // kadinradiobutton
            // 
            this.kadinradiobutton.AutoSize = true;
            this.kadinradiobutton.Location = new System.Drawing.Point(15, 28);
            this.kadinradiobutton.Name = "kadinradiobutton";
            this.kadinradiobutton.Size = new System.Drawing.Size(51, 17);
            this.kadinradiobutton.TabIndex = 5;
            this.kadinradiobutton.TabStop = true;
            this.kadinradiobutton.Text = "kadın";
            this.kadinradiobutton.UseVisualStyleBackColor = true;
            // 
            // ogrencimaskedtextbox
            // 
            this.ogrencimaskedtextbox.BackColor = System.Drawing.Color.Silver;
            this.ogrencimaskedtextbox.Location = new System.Drawing.Point(154, 90);
            this.ogrencimaskedtextbox.Name = "ogrencimaskedtextbox";
            this.ogrencimaskedtextbox.Size = new System.Drawing.Size(194, 20);
            this.ogrencimaskedtextbox.TabIndex = 4;
            // 
            // adresrichtextbox
            // 
            this.adresrichtextbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adresrichtextbox.Location = new System.Drawing.Point(67, 166);
            this.adresrichtextbox.Name = "adresrichtextbox";
            this.adresrichtextbox.Size = new System.Drawing.Size(281, 84);
            this.adresrichtextbox.TabIndex = 6;
            this.adresrichtextbox.Text = "";
            // 
            // ogrencisoyisim
            // 
            this.ogrencisoyisim.AutoSize = true;
            this.ogrencisoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencisoyisim.Location = new System.Drawing.Point(6, 59);
            this.ogrencisoyisim.Name = "ogrencisoyisim";
            this.ogrencisoyisim.Size = new System.Drawing.Size(126, 20);
            this.ogrencisoyisim.TabIndex = 7;
            this.ogrencisoyisim.Text = "Öğrenci Soyisim:";
            // 
            // ogrencisoyisimtextbox
            // 
            this.ogrencisoyisimtextbox.BackColor = System.Drawing.Color.Silver;
            this.ogrencisoyisimtextbox.Location = new System.Drawing.Point(154, 61);
            this.ogrencisoyisimtextbox.Name = "ogrencisoyisimtextbox";
            this.ogrencisoyisimtextbox.Size = new System.Drawing.Size(194, 20);
            this.ogrencisoyisimtextbox.TabIndex = 8;
            // 
            // ogrencinumara
            // 
            this.ogrencinumara.AutoSize = true;
            this.ogrencinumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencinumara.Location = new System.Drawing.Point(6, 88);
            this.ogrencinumara.Name = "ogrencinumara";
            this.ogrencinumara.Size = new System.Drawing.Size(128, 20);
            this.ogrencinumara.TabIndex = 9;
            this.ogrencinumara.Text = "Öğrenci Numara:";
            // 
            // velinumara
            // 
            this.velinumara.AutoSize = true;
            this.velinumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.velinumara.Location = new System.Drawing.Point(410, 88);
            this.velinumara.Name = "velinumara";
            this.velinumara.Size = new System.Drawing.Size(99, 20);
            this.velinumara.TabIndex = 10;
            this.velinumara.Text = "Veli Numara:";
            // 
            // velisoyisim
            // 
            this.velisoyisim.AutoSize = true;
            this.velisoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.velisoyisim.Location = new System.Drawing.Point(410, 61);
            this.velisoyisim.Name = "velisoyisim";
            this.velisoyisim.Size = new System.Drawing.Size(97, 20);
            this.velisoyisim.TabIndex = 11;
            this.velisoyisim.Text = "Veli Soyisim:";
            // 
            // veliisim
            // 
            this.veliisim.AutoSize = true;
            this.veliisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliisim.Location = new System.Drawing.Point(410, 31);
            this.veliisim.Name = "veliisim";
            this.veliisim.Size = new System.Drawing.Size(72, 20);
            this.veliisim.TabIndex = 12;
            this.veliisim.Text = "Veli İsim:";
            // 
            // velisoyisimtextbox
            // 
            this.velisoyisimtextbox.BackColor = System.Drawing.Color.Silver;
            this.velisoyisimtextbox.Location = new System.Drawing.Point(533, 63);
            this.velisoyisimtextbox.Name = "velisoyisimtextbox";
            this.velisoyisimtextbox.Size = new System.Drawing.Size(194, 20);
            this.velisoyisimtextbox.TabIndex = 13;
            // 
            // veliisimtextbox
            // 
            this.veliisimtextbox.BackColor = System.Drawing.Color.Silver;
            this.veliisimtextbox.Location = new System.Drawing.Point(533, 33);
            this.veliisimtextbox.Name = "veliisimtextbox";
            this.veliisimtextbox.Size = new System.Drawing.Size(194, 20);
            this.veliisimtextbox.TabIndex = 14;
            // 
            // velinumaramaskedtextbox
            // 
            this.velinumaramaskedtextbox.BackColor = System.Drawing.Color.Silver;
            this.velinumaramaskedtextbox.Location = new System.Drawing.Point(533, 90);
            this.velinumaramaskedtextbox.Name = "velinumaramaskedtextbox";
            this.velinumaramaskedtextbox.Size = new System.Drawing.Size(194, 20);
            this.velinumaramaskedtextbox.TabIndex = 15;
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.Location = new System.Drawing.Point(6, 166);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(55, 20);
            this.adres.TabIndex = 16;
            this.adres.Text = "Adres:";
            // 
            // ogrencitcnomaskedtextbox
            // 
            this.ogrencitcnomaskedtextbox.BackColor = System.Drawing.Color.Silver;
            this.ogrencitcnomaskedtextbox.Location = new System.Drawing.Point(154, 121);
            this.ogrencitcnomaskedtextbox.Name = "ogrencitcnomaskedtextbox";
            this.ogrencitcnomaskedtextbox.Size = new System.Drawing.Size(194, 20);
            this.ogrencitcnomaskedtextbox.TabIndex = 17;
            // 
            // ogrencitcno
            // 
            this.ogrencitcno.AutoSize = true;
            this.ogrencitcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencitcno.Location = new System.Drawing.Point(6, 119);
            this.ogrencitcno.Name = "ogrencitcno";
            this.ogrencitcno.Size = new System.Drawing.Size(114, 20);
            this.ogrencitcno.TabIndex = 18;
            this.ogrencitcno.Text = "Öğrenci TC no:";
            // 
            // velitcno
            // 
            this.velitcno.AutoSize = true;
            this.velitcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.velitcno.Location = new System.Drawing.Point(410, 121);
            this.velitcno.Name = "velitcno";
            this.velitcno.Size = new System.Drawing.Size(85, 20);
            this.velitcno.TabIndex = 19;
            this.velitcno.Text = "Veli TC no:";
            // 
            // velitcnomaskedtextbox
            // 
            this.velitcnomaskedtextbox.BackColor = System.Drawing.Color.Silver;
            this.velitcnomaskedtextbox.Location = new System.Drawing.Point(533, 123);
            this.velitcnomaskedtextbox.Name = "velitcnomaskedtextbox";
            this.velitcnomaskedtextbox.Size = new System.Drawing.Size(194, 20);
            this.velitcnomaskedtextbox.TabIndex = 20;
            // 
            // kayittarihi
            // 
            this.kayittarihi.AutoSize = true;
            this.kayittarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayittarihi.Location = new System.Drawing.Point(410, 188);
            this.kayittarihi.Name = "kayittarihi";
            this.kayittarihi.Size = new System.Drawing.Size(85, 20);
            this.kayittarihi.TabIndex = 22;
            this.kayittarihi.Text = "Kayıt Tarihi";
            // 
            // kayittarihidateTimePicker
            // 
            this.kayittarihidateTimePicker.Location = new System.Drawing.Point(533, 187);
            this.kayittarihidateTimePicker.Name = "kayittarihidateTimePicker";
            this.kayittarihidateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.kayittarihidateTimePicker.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.kayittarihidateTimePicker);
            this.Controls.Add(this.kayittarihi);
            this.Controls.Add(this.velitcnomaskedtextbox);
            this.Controls.Add(this.velitcno);
            this.Controls.Add(this.ogrencitcno);
            this.Controls.Add(this.ogrencitcnomaskedtextbox);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.velinumaramaskedtextbox);
            this.Controls.Add(this.veliisimtextbox);
            this.Controls.Add(this.velisoyisimtextbox);
            this.Controls.Add(this.veliisim);
            this.Controls.Add(this.velisoyisim);
            this.Controls.Add(this.velinumara);
            this.Controls.Add(this.ogrencinumara);
            this.Controls.Add(this.ogrencisoyisimtextbox);
            this.Controls.Add(this.ogrencisoyisim);
            this.Controls.Add(this.adresrichtextbox);
            this.Controls.Add(this.ogrencimaskedtextbox);
            this.Controls.Add(this.cinisyetgroupbox);
            this.Controls.Add(this.kayitbutton);
            this.Controls.Add(this.ogrenciisim);
            this.Controls.Add(this.ogrenciisimtextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.cinisyetgroupbox.ResumeLayout(false);
            this.cinisyetgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ogrenciisimtextbox;
        private System.Windows.Forms.Label ogrenciisim;
        private System.Windows.Forms.Button kayitbutton;
        private System.Windows.Forms.GroupBox cinisyetgroupbox;
        private System.Windows.Forms.RadioButton erkekradiobutton;
        private System.Windows.Forms.RadioButton kadinradiobutton;
        private System.Windows.Forms.MaskedTextBox ogrencimaskedtextbox;
        private System.Windows.Forms.RichTextBox adresrichtextbox;
        private System.Windows.Forms.Label ogrencisoyisim;
        private System.Windows.Forms.TextBox ogrencisoyisimtextbox;
        private System.Windows.Forms.Label ogrencinumara;
        private System.Windows.Forms.Label velinumara;
        private System.Windows.Forms.Label velisoyisim;
        private System.Windows.Forms.Label veliisim;
        private System.Windows.Forms.TextBox velisoyisimtextbox;
        private System.Windows.Forms.TextBox veliisimtextbox;
        private System.Windows.Forms.MaskedTextBox velinumaramaskedtextbox;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.MaskedTextBox ogrencitcnomaskedtextbox;
        private System.Windows.Forms.Label ogrencitcno;
        private System.Windows.Forms.Label velitcno;
        private System.Windows.Forms.MaskedTextBox velitcnomaskedtextbox;
        private System.Windows.Forms.Label kayittarihi;
        private System.Windows.Forms.DateTimePicker kayittarihidateTimePicker;
    }
}

