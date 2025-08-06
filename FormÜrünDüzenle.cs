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
    public partial class FormÜrünDüzenle : Form
    {
		public Form PreviousForm { get; set; }//1.formdan 1.formun nesne kısmına ulaşmak için ekledik

        public string Geri_Don_Hata {  get; set; }
		public FormÜrünDüzenle()
        {
            InitializeComponent();
        }

       // public String Kat_Ek { get; set; }//katogori formundan değer alabilmek için
       
        

		KatogoriEkle K_ek = new KatogoriEkle(); // K_ek adında nesne oluşturuldu
		public void FormÜrünDüzenle_Load(object sender, EventArgs e)
		{
				

		}

        public ComboBox comboBox1Referance // combobox'u katagori formunda 
        {
            get { return Kat_Sec; }         // düzenleyebilmek için referans atadık
		}
        
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

                 }
                else
                {
                    MessageBox.Show("Katagori kısmını tekrar girin lütfen", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               
            }

			

			if (kat != "" && Geri_Don_Hata != "Hata~")//combobox seşiminde kullanıcıya girebileceği değerler aktif ediliyor.

            { //Daha sonra bakılacak
                 
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;

        }
			
		}
        //Ana menüye dönüş
		private void button1_Click(object sender, EventArgs e)
		{
            
                PreviousForm.Show();
                this.Close();
            
		}

		
	}
}
