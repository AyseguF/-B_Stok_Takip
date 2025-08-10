using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;//Katagori giriniz kısmı içi(silik ve giri gösterir.)


namespace İB_Stok_Takip
{
	public partial class FormÜrünDüzenle : Form
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lParam);
		private const int CB_SETCUEBANNER = 0x1703;
		public Form PreviousForm { get; set; }//1.formdan 1.formun nesne kısmına ulaşmak için ekledik

		public string Geri_Don_Hata { get; set; }




		public FormÜrünDüzenle()
		{
			InitializeComponent();


		}

		// public String Kat_Ek { get; set; }//katogori formundan değer alabilmek için



		KatogoriEkle K_ek = new KatogoriEkle(); // K_ek adında nesne oluşturuldu
		DataTable dt = new DataTable();



		static string baglantiDizesi = "Data Source=stok.db;Version=3;";

		public void Listele()
		{

			try
			{
				using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
				{

					baglanti.Open();
					string sql = "SELECT * FROM urun_tablo";
					using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
					{
						using (SQLiteDataAdapter adaptor = new SQLiteDataAdapter(komut))
						{
							dt.Clear();//eski veriler silinsin
							adaptor.Fill(dt);
							dataGridView1.DataSource = dt;
						}
					}
				}

			}

			catch (Exception ex)
			{
				MessageBox.Show("Veri Tabanına Bağlanılamadı:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void FormÜrünDüzenle_Load(object sender, EventArgs e)
		{
			Listele();
			KategorileriYukle();
			SendMessage(Kat_Sec.Handle, CB_SETCUEBANNER, IntPtr.Zero, "Kategori seçiniz...");//yazı gelmeden önceki bilgi


		}


		public ComboBox comboBox1Referance // combobox'u katagori formunda 
		{
			get { return Kat_Sec; }         // düzenleyebilmek için referans atadık
		}

		private void KategorileriYukle()
		{
			Kat_Sec.Items.Clear();

			using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
			{
				baglanti.Open();
				string sql = "SELECT DISTINCT KATEGORİ FROM urun_tablo";
				using (SQLiteCommand cmd = new SQLiteCommand(sql, baglanti))
				using (SQLiteDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Kat_Sec.Items.Add(reader["KATEGORİ"].ToString());
					}
				}
			}
			Kat_Sec.Items.Add("Diğer");
		}
		
		//Ana menüye dönüş
		private void button1_Click(object sender, EventArgs e)
		{

			PreviousForm.Show();
			this.Close();

		}


		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)//herhangi bir stuna bastığımda o stunu algılaması için CellControClick yerine cellClick kullanıldı
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow satır = dataGridView1.Rows[e.RowIndex];

				string katagori = satır.Cells["KATEGORİ"].Value.ToString();


				int index = Kat_Sec.Items.IndexOf(katagori);//combobox içinde katagori değişkeninde olan değer var mıkontrolü

				if (index >= 0)
				{
					Kat_Sec.SelectedIndex = index;//varsa direk seç 
					textBox_UrunAdı.Text = satır.Cells["ÜRÜN"].Value.ToString();
					textBox_SıraNo.Text = satır.Cells["ID"].Value.ToString();
					textBox_Gelenler.Text = satır.Cells["MİKTARI"].Value.ToString();
				}
				else
				{
					DialogResult cevap;
					cevap = MessageBox.Show("Seçtiğiniz değer karagori listesinde yok.Seçilen değeri katagoriye eklemek ister misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (cevap == DialogResult.Yes)
					{

						Kat_Sec.Items.Insert(0, katagori);
						Kat_Sec.SelectedIndex = 0;
						textBox_Gelenler.Text = satır.Cells["MİKTARI"].Value.ToString();
						textBox_SıraNo.Text = satır.Cells["ID"].Value.ToString();
						textBox_UrunAdı.Text = satır.Cells["ÜRÜN"].Value.ToString();

					}
					else
					{
						MessageBox.Show("Seçiminizden dolayı ürün verileri sistemden çekilip yazılamıyor.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					}

				}


			}

		}


		private void katdet_Click(object sender, EventArgs e)
		{
			var baglanti = new SQLiteConnection(baglantiDizesi);
			baglanti.Open();

			String sql = "UPDATE urun_tablo SET MİKTARI=@mik, ÜRÜN=@ad, KATEGORİ=@kat WHERE ID=@id";

			using (SQLiteCommand cmd = new SQLiteCommand(sql, baglanti))
			{
				cmd.Parameters.AddWithValue("@mik", textBox_Gelenler.Text);
				cmd.Parameters.AddWithValue("@ad", textBox_UrunAdı.Text);
				cmd.Parameters.AddWithValue("@kat", Kat_Sec.SelectedItem?.ToString());
				cmd.Parameters.AddWithValue("@id", textBox_SıraNo.Text);
				Kat_Sec.Items.Insert(0, Kat_Sec.Text);
				cmd.ExecuteNonQuery();
			}

			MessageBox.Show("Güncellendi");
			Listele();


		}

		private void Kat_Sec_SelectedIndexChanged(object sender, EventArgs e)
		{


			
			String kat = Kat_Sec.SelectedItem.ToString(); // combobox seçilen değer okuma

			if (kat == "Diğer")
			{

				DialogResult sec = MessageBox.Show("Yeni katagori girmek ister misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); // kullanıcıya karar vermesi için mesaj
				if (sec == DialogResult.Yes)
				{

					K_ek.Baglan = this; // katagori formuna bağlantı sağlanıyor
					K_ek.PreviousForm = this;//katagori formuunun geri butonu için bağlantı
					this.Hide();//açık formun görüntü olarak kapatılmasını ama arka platformda çalışmasını sağlıyor
					K_ek.ShowDialog();
					Kat_Sec.SelectedItem = Kat_Sec.Items[0];

				}
				else
				{
					MessageBox.Show("Katagori kısmını tekrar girin lütfen", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}


			}



			if (kat != "")//combobox seşiminde kullanıcıya girebileceği değerler aktif ediliyor.

			{ //Daha sonra bakılacak

				for (int i = 2; i < 8; i++)
				{
					var controls = this.Controls.Find("label" + i, true);

					if (controls.Length > 0 && controls[0] is Label lbl)
					{
						lbl.Visible = true;
					}

				}

				foreach (TextBox txt in this.Controls.OfType<TextBox>())
				{ txt.Visible = true; }


			}

		}

		private void Kat_Sec_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string yaz = Kat_Sec.Text;
				int index = Kat_Sec.Items.IndexOf(yaz);

				if (index < 0)
				{
					MessageBox.Show(" Veri tabanında kayıtlı olamyan bir katagori girdiniz... Eğer yeni kategori eklemek istiyorsanız \"Diğer\" sekmesini kullanarak yeni katagori ekleyebilirsiniz. ");
				}
				
			}
		}
	}
}