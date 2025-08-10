namespace İB_Stok_Takip
{
	partial class KatogoriEkle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KatogoriEkle));
			this.label1 = new System.Windows.Forms.Label();
			this.Y_K = new System.Windows.Forms.TextBox();
			this.button_Ekle = new System.Windows.Forms.Button();
			this.button_Ana = new System.Windows.Forms.Button();
			this.Geri_D = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(67, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Yeni Katogori Adı :";
			// 
			// Y_K
			// 
			this.Y_K.Location = new System.Drawing.Point(267, 114);
			this.Y_K.Name = "Y_K";
			this.Y_K.Size = new System.Drawing.Size(96, 22);
			this.Y_K.TabIndex = 1;
			// 
			// button_Ekle
			// 
			this.button_Ekle.Location = new System.Drawing.Point(179, 169);
			this.button_Ekle.Name = "button_Ekle";
			this.button_Ekle.Size = new System.Drawing.Size(133, 39);
			this.button_Ekle.TabIndex = 2;
			this.button_Ekle.Text = "Ekle";
			this.button_Ekle.UseVisualStyleBackColor = true;
			this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
			// 
			// button_Ana
			// 
			this.button_Ana.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button_Ana.Image = ((System.Drawing.Image)(resources.GetObject("button_Ana.Image")));
			this.button_Ana.Location = new System.Drawing.Point(394, 12);
			this.button_Ana.Name = "button_Ana";
			this.button_Ana.Size = new System.Drawing.Size(75, 54);
			this.button_Ana.TabIndex = 3;
			this.button_Ana.UseVisualStyleBackColor = false;
			this.button_Ana.Click += new System.EventHandler(this.button_Ana_Click);
			// 
			// Geri_D
			// 
			this.Geri_D.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Geri_D.Image = ((System.Drawing.Image)(resources.GetObject("Geri_D.Image")));
			this.Geri_D.Location = new System.Drawing.Point(12, 12);
			this.Geri_D.Name = "Geri_D";
			this.Geri_D.Size = new System.Drawing.Size(61, 54);
			this.Geri_D.TabIndex = 4;
			this.Geri_D.UseVisualStyleBackColor = false;
			this.Geri_D.Click += new System.EventHandler(this.Geri_D_Click);
			// 
			// KatogoriEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 282);
			this.Controls.Add(this.Geri_D);
			this.Controls.Add(this.button_Ana);
			this.Controls.Add(this.button_Ekle);
			this.Controls.Add(this.Y_K);
			this.Controls.Add(this.label1);
			this.Name = "KatogoriEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KatogoriEkle";
			this.Load += new System.EventHandler(this.KatogoriEkle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Y_K;
		private System.Windows.Forms.Button button_Ekle;
		private System.Windows.Forms.Button button_Ana;
		private System.Windows.Forms.Button Geri_D;
	}
}