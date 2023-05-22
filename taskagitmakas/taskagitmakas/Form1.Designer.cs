namespace taskagitmakas
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
            this.btnTas = new System.Windows.Forms.Button();
            this.btnKagit = new System.Windows.Forms.Button();
            this.btnMakas = new System.Windows.Forms.Button();
            this.picOyuncu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.picBilgisayar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGeriSayac = new System.Windows.Forms.Label();
            this.btnTekrar = new System.Windows.Forms.Button();
            this.zamanSay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBilgisayar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTas
            // 
            this.btnTas.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTas.Location = new System.Drawing.Point(20, 114);
            this.btnTas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTas.Name = "btnTas";
            this.btnTas.Size = new System.Drawing.Size(151, 68);
            this.btnTas.TabIndex = 0;
            this.btnTas.Text = "TAŞ";
            this.btnTas.UseVisualStyleBackColor = true;
            this.btnTas.Click += new System.EventHandler(this.btnTas_Click);
            // 
            // btnKagit
            // 
            this.btnKagit.Location = new System.Drawing.Point(18, 194);
            this.btnKagit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(151, 68);
            this.btnKagit.TabIndex = 1;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = true;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // btnMakas
            // 
            this.btnMakas.Location = new System.Drawing.Point(20, 282);
            this.btnMakas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakas.Name = "btnMakas";
            this.btnMakas.Size = new System.Drawing.Size(151, 68);
            this.btnMakas.TabIndex = 2;
            this.btnMakas.Text = "MAKAS";
            this.btnMakas.UseVisualStyleBackColor = true;
            this.btnMakas.Click += new System.EventHandler(this.btnMakas_Click);
            // 
            // picOyuncu
            // 
            this.picOyuncu.Image = global::taskagitmakas.Properties.Resources.indir__2_;
            this.picOyuncu.Location = new System.Drawing.Point(204, 114);
            this.picOyuncu.Name = "picOyuncu";
            this.picOyuncu.Size = new System.Drawing.Size(304, 346);
            this.picOyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOyuncu.TabIndex = 3;
            this.picOyuncu.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(202, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oyuncu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkor
            // 
            this.lblSkor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(541, 114);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(257, 39);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "Oyuncu 0-0 Bilgisayar";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTur
            // 
            this.lblTur.Location = new System.Drawing.Point(541, 409);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(257, 39);
            this.lblTur.TabIndex = 4;
            this.lblTur.Text = "Oyuncu";
            this.lblTur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBilgisayar
            // 
            this.picBilgisayar.Image = global::taskagitmakas.Properties.Resources.indir__2_;
            this.picBilgisayar.Location = new System.Drawing.Point(825, 122);
            this.picBilgisayar.Name = "picBilgisayar";
            this.picBilgisayar.Size = new System.Drawing.Size(304, 346);
            this.picBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBilgisayar.TabIndex = 3;
            this.picBilgisayar.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(820, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bilgisayar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeriSayac
            // 
            this.lblGeriSayac.Location = new System.Drawing.Point(541, 244);
            this.lblGeriSayac.Name = "lblGeriSayac";
            this.lblGeriSayac.Size = new System.Drawing.Size(257, 39);
            this.lblGeriSayac.TabIndex = 4;
            this.lblGeriSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTekrar
            // 
            this.btnTekrar.Location = new System.Drawing.Point(887, 509);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(227, 54);
            this.btnTekrar.TabIndex = 5;
            this.btnTekrar.Text = "Terar Başlat";
            this.btnTekrar.UseVisualStyleBackColor = true;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // zamanSay
            // 
            this.zamanSay.Interval = 5000;
            this.zamanSay.Tick += new System.EventHandler(this.ZamanSayEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 591);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblGeriSayac);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBilgisayar);
            this.Controls.Add(this.picOyuncu);
            this.Controls.Add(this.btnMakas);
            this.Controls.Add(this.btnKagit);
            this.Controls.Add(this.btnTas);
            this.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBilgisayar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTas;
        private System.Windows.Forms.Button btnKagit;
        private System.Windows.Forms.Button btnMakas;
        private System.Windows.Forms.PictureBox picOyuncu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.PictureBox picBilgisayar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGeriSayac;
        private System.Windows.Forms.Button btnTekrar;
        private System.Windows.Forms.Timer zamanSay;
    }
}

