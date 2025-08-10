namespace İB_Stok_Takip
{
    partial class FormÜrünDüzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜrünDüzenle));
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Kat_Sec = new System.Windows.Forms.ComboBox();
			this.textBox_UrunAdı = new System.Windows.Forms.TextBox();
			this.textBox_UrunAdetBirimi = new System.Windows.Forms.TextBox();
			this.textBox_Gelenler = new System.Windows.Forms.TextBox();
			this.textBox_Kullanılanlar = new System.Windows.Forms.TextBox();
			this.textBox_KalalMiktar = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.katdet = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_SıraNo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(162, 332);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(247, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Ürün Adı                        :";
			this.label3.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Enabled = false;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(158, 411);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(248, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ürün Adet Birirmi           :";
			this.label5.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(163, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Katagori                        :";
			// 
			// Kat_Sec
			// 
			this.Kat_Sec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Kat_Sec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Kat_Sec.FormattingEnabled = true;
			this.Kat_Sec.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Kat_Sec.Items.AddRange(new object[] {
            "Toner",
            "PC",
            "Kablo",
            "Diğer"});
			this.Kat_Sec.Location = new System.Drawing.Point(436, 267);
			this.Kat_Sec.Name = "Kat_Sec";
			this.Kat_Sec.Size = new System.Drawing.Size(158, 24);
			this.Kat_Sec.TabIndex = 8;
			this.Kat_Sec.SelectedIndexChanged += new System.EventHandler(this.Kat_Sec_SelectedIndexChanged);
			this.Kat_Sec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kat_Sec_KeyDown);
			// 
			// textBox_UrunAdı
			// 
			this.textBox_UrunAdı.Location = new System.Drawing.Point(436, 332);
			this.textBox_UrunAdı.Name = "textBox_UrunAdı";
			this.textBox_UrunAdı.Size = new System.Drawing.Size(158, 22);
			this.textBox_UrunAdı.TabIndex = 10;
			this.textBox_UrunAdı.Visible = false;
			// 
			// textBox_UrunAdetBirimi
			// 
			this.textBox_UrunAdetBirimi.Enabled = false;
			this.textBox_UrunAdetBirimi.Location = new System.Drawing.Point(436, 414);
			this.textBox_UrunAdetBirimi.Name = "textBox_UrunAdetBirimi";
			this.textBox_UrunAdetBirimi.Size = new System.Drawing.Size(158, 22);
			this.textBox_UrunAdetBirimi.TabIndex = 11;
			this.textBox_UrunAdetBirimi.Visible = false;
			// 
			// textBox_Gelenler
			// 
			this.textBox_Gelenler.Location = new System.Drawing.Point(436, 369);
			this.textBox_Gelenler.Name = "textBox_Gelenler";
			this.textBox_Gelenler.Size = new System.Drawing.Size(158, 22);
			this.textBox_Gelenler.TabIndex = 12;
			this.textBox_Gelenler.Visible = false;
			// 
			// textBox_Kullanılanlar
			// 
			this.textBox_Kullanılanlar.Enabled = false;
			this.textBox_Kullanılanlar.Location = new System.Drawing.Point(436, 483);
			this.textBox_Kullanılanlar.Name = "textBox_Kullanılanlar";
			this.textBox_Kullanılanlar.Size = new System.Drawing.Size(158, 22);
			this.textBox_Kullanılanlar.TabIndex = 13;
			this.textBox_Kullanılanlar.Visible = false;
			// 
			// textBox_KalalMiktar
			// 
			this.textBox_KalalMiktar.Enabled = false;
			this.textBox_KalalMiktar.Location = new System.Drawing.Point(436, 455);
			this.textBox_KalalMiktar.Name = "textBox_KalalMiktar";
			this.textBox_KalalMiktar.Size = new System.Drawing.Size(158, 22);
			this.textBox_KalalMiktar.TabIndex = 14;
			this.textBox_KalalMiktar.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Enabled = false;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(159, 451);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(248, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "Kalan Miktar                  :";
			this.label6.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Enabled = false;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(159, 479);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(246, 25);
			this.label7.TabIndex = 4;
			this.label7.Text = "Kullanılanlar                  :";
			this.label7.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(159, 369);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(244, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Gelenler                        :";
			this.label4.Visible = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(716, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 70);
			this.button1.TabIndex = 15;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// katdet
			// 
			this.katdet.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.katdet.Image = ((System.Drawing.Image)(resources.GetObject("katdet.Image")));
			this.katdet.Location = new System.Drawing.Point(12, 6);
			this.katdet.Name = "katdet";
			this.katdet.Size = new System.Drawing.Size(71, 66);
			this.katdet.TabIndex = 0;
			this.katdet.UseVisualStyleBackColor = false;
			this.katdet.Click += new System.EventHandler(this.katdet_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(779, 156);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(159, 297);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(247, 25);
			this.label2.TabIndex = 17;
			this.label2.Text = "Sıra No                          :";
			this.label2.Visible = false;
			// 
			// textBox_SıraNo
			// 
			this.textBox_SıraNo.Location = new System.Drawing.Point(436, 297);
			this.textBox_SıraNo.Name = "textBox_SıraNo";
			this.textBox_SıraNo.Size = new System.Drawing.Size(158, 22);
			this.textBox_SıraNo.TabIndex = 18;
			this.textBox_SıraNo.Visible = false;
			// 
			// FormÜrünDüzenle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 586);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_SıraNo);
			this.Controls.Add(this.katdet);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_KalalMiktar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_Kullanılanlar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_Gelenler);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_UrunAdetBirimi);
			this.Controls.Add(this.textBox_UrunAdı);
			this.Controls.Add(this.Kat_Sec);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormÜrünDüzenle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormÜrünDüzenle";
			this.Load += new System.EventHandler(this.FormÜrünDüzenle_Load);
			this.Shown += new System.EventHandler(this.FormÜrünDüzenle_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Kat_Sec;
		private System.Windows.Forms.TextBox textBox_UrunAdı;
		private System.Windows.Forms.TextBox textBox_UrunAdetBirimi;
		private System.Windows.Forms.TextBox textBox_Gelenler;
		private System.Windows.Forms.TextBox textBox_Kullanılanlar;
		private System.Windows.Forms.TextBox textBox_KalalMiktar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button katdet;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_SıraNo;
	}
}