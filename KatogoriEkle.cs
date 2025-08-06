using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
	public partial class KatogoriEkle : Form
	{
		public Form PreviousForm { get; set; }//düzenle formunun bağlantısı için
		public Form AnaForm {  get; set; }//Ana formun bağlantısı için
		public FormÜrünDüzenle Baglan { get; set; }//combobox erişim bağlantısı için
		public string Kat_Ek {  get; set; }// Değişkenin her metotta kullanılmasına uygun olması için dışarıda
		public KatogoriEkle()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)// ekle butonunun ismi değiştirilemedi o yüzden böyle kaldı. daha sonra tekrar denenecek
		{
			Kat_Ek = Y_K.Text; //textbox değer alma
			//FormÜrünDüzenle düz = new FormÜrünDüzenle();//düzenleme formu için nesne oluşturma
			if (Kat_Ek != "")
			{
				Baglan.comboBox1Referance.Items.Add(Kat_Ek);//düzenleme formundaki combobax'a değer girme
				this.Close();
				PreviousForm.Show();
				
			}
			else
			{ 
				MessageBox.Show("Geçersiz işlem tekrar deneyin","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			
			}
			
			

		}
		
		
		private void button2_Click(object sender, EventArgs e)//Ana menü butonu
		{
			Form1 ana = new Form1();
			ana.ShowDialog();
			System.Windows.Forms.Application.ExitThread();//Yeni ana pencereye dönerken geride kalan win pencerelerini kapatmak için
			
			
		}

		private void Geri_D_Click(object sender, EventArgs e)
		{
			FormÜrünDüzenle hata =new FormÜrünDüzenle();
			hata.Geri_Don_Hata = "Hata~";//Daha sonra bakılacak
			PreviousForm.Show();
			this.Close();

		}

		private void KatogoriEkle_Load(object sender, EventArgs e)
		{
			
		}
	}
}
