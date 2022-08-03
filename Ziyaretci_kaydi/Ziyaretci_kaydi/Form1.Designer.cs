
namespace Ziyaretci_kaydi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.sebeb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.unvan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.tel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(356, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 21);
            this.textBox1.TabIndex = 67;
            this.textBox1.UseWaitCursor = true;
            // 
            // id
            // 
            this.id.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.id.Location = new System.Drawing.Point(130, -29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(133, 20);
            this.id.TabIndex = 65;
            this.id.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(-1, -22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 64;
            this.label10.Text = "İd:";
            this.label10.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 185);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cellenter);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cellenter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(685, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 30);
            this.button3.TabIndex = 62;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sebeb
            // 
            this.sebeb.FormattingEnabled = true;
            this.sebeb.Items.AddRange(new object[] {
            "Hayırlı olsun",
            "Tanışmak",
            "Yemek yemek",
            "Toplantı",
            "Diğer"});
            this.sebeb.Location = new System.Drawing.Point(130, 200);
            this.sebeb.Name = "sebeb";
            this.sebeb.Size = new System.Drawing.Size(133, 21);
            this.sebeb.TabIndex = 61;
            this.sebeb.UseWaitCursor = true;
            this.sebeb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sebeb_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(356, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 60;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 57;
            this.label9.Text = "Çıkış saati:";
            this.label9.UseWaitCursor = true;
            // 
            // tarih
            // 
            this.tarih.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tarih.Enabled = false;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tarih.Location = new System.Drawing.Point(130, 227);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(133, 21);
            this.tarih.TabIndex = 56;
            this.tarih.UseWaitCursor = true;
            this.tarih.Value = new System.DateTime(2022, 7, 6, 10, 18, 55, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "Giriş saati:";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ziyaret tarihi:";
            this.label7.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 204);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ziyaret sebebi:";
            this.label2.UseWaitCursor = true;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(130, 81);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(133, 76);
            this.adres.TabIndex = 51;
            this.adres.Text = "";
            this.adres.UseWaitCursor = true;
            this.adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adres_KeyPress);
            this.adres.Validated += new System.EventHandler(this.adres_Validated);
            // 
            // unvan
            // 
            this.unvan.Location = new System.Drawing.Point(130, 55);
            this.unvan.Name = "unvan";
            this.unvan.Size = new System.Drawing.Size(133, 20);
            this.unvan.TabIndex = 50;
            this.unvan.UseWaitCursor = true;
            this.unvan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unvan_KeyPress);
            this.unvan.Validated += new System.EventHandler(this.unvan_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Telefon:";
            this.label5.UseWaitCursor = true;
            // 
            // adsoyad
            // 
            this.adsoyad.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.adsoyad.Location = new System.Drawing.Point(130, 25);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(133, 20);
            this.adsoyad.TabIndex = 47;
            this.adsoyad.UseWaitCursor = true;
            this.adsoyad.TextChanged += new System.EventHandler(this.adsoyad_TextChanged);
            this.adsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adsoyad_KeyPress_1);
            this.adsoyad.Validating += new System.ComponentModel.CancelEventHandler(this.adsoyad_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ad Soyad:";
            this.label3.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Adres:";
            this.label6.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ünvan:";
            this.label4.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 44;
            this.label1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(565, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 70;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlueViolet;
            this.button4.Location = new System.Drawing.Point(356, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 30);
            this.button4.TabIndex = 71;
            this.button4.Text = "SİL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumOrchid;
            this.button5.Location = new System.Drawing.Point(356, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 30);
            this.button5.TabIndex = 76;
            this.button5.Text = "YAZDIR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button6.Location = new System.Drawing.Point(356, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 30);
            this.button6.TabIndex = 77;
            this.button6.Text = "GÜNCELLE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(130, 261);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox1.TabIndex = 78;
            this.maskedTextBox1.UseWaitCursor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(130, 293);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox2.TabIndex = 79;
            this.maskedTextBox2.UseWaitCursor = true;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(130, 170);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(133, 20);
            this.tel.TabIndex = 80;
            this.tel.UseWaitCursor = true;
            this.tel.TextChanged += new System.EventHandler(this.tel_TextChanged);
            this.tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 509);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sebeb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.unvan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox sebeb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.TextBox unvan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox tel;
    }
}

