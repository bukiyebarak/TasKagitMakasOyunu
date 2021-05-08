
namespace Tas_Kagıt_Makas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Oyuncu = new System.Windows.Forms.PictureBox();
            this.Bilgisayar = new System.Windows.Forms.PictureBox();
            this.Tas = new System.Windows.Forms.PictureBox();
            this.Makas = new System.Windows.Forms.PictureBox();
            this.Kagıt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_oyun = new System.Windows.Forms.Button();
            this.Oyuncu_Puanı = new System.Windows.Forms.Label();
            this.Bilgisayar_Puanı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Oyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bilgisayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Makas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kagıt)).BeginInit();
            this.SuspendLayout();
            // 
            // Oyuncu
            // 
            this.Oyuncu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Oyuncu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Oyuncu.Location = new System.Drawing.Point(12, 66);
            this.Oyuncu.Name = "Oyuncu";
            this.Oyuncu.Size = new System.Drawing.Size(174, 160);
            this.Oyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Oyuncu.TabIndex = 0;
            this.Oyuncu.TabStop = false;
            // 
            // Bilgisayar
            // 
            this.Bilgisayar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Bilgisayar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bilgisayar.Location = new System.Drawing.Point(582, 79);
            this.Bilgisayar.Name = "Bilgisayar";
            this.Bilgisayar.Size = new System.Drawing.Size(174, 160);
            this.Bilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bilgisayar.TabIndex = 1;
            this.Bilgisayar.TabStop = false;
            // 
            // Tas
            // 
            this.Tas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tas.Image = ((System.Drawing.Image)(resources.GetObject("Tas.Image")));
            this.Tas.Location = new System.Drawing.Point(3, 242);
            this.Tas.Name = "Tas";
            this.Tas.Size = new System.Drawing.Size(54, 72);
            this.Tas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tas.TabIndex = 2;
            this.Tas.TabStop = false;
            this.Tas.Click += new System.EventHandler(this.Tas_Click);
            // 
            // Makas
            // 
            this.Makas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Makas.Image = ((System.Drawing.Image)(resources.GetObject("Makas.Image")));
            this.Makas.Location = new System.Drawing.Point(142, 242);
            this.Makas.Name = "Makas";
            this.Makas.Size = new System.Drawing.Size(55, 72);
            this.Makas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Makas.TabIndex = 3;
            this.Makas.TabStop = false;
            this.Makas.Click += new System.EventHandler(this.Makas_Click);
            // 
            // Kagıt
            // 
            this.Kagıt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Kagıt.Image = ((System.Drawing.Image)(resources.GetObject("Kagıt.Image")));
            this.Kagıt.Location = new System.Drawing.Point(72, 242);
            this.Kagıt.Name = "Kagıt";
            this.Kagıt.Size = new System.Drawing.Size(55, 72);
            this.Kagıt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kagıt.TabIndex = 4;
            this.Kagıt.TabStop = false;
            this.Kagıt.Click += new System.EventHandler(this.Kagıt_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "OYUNCU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(551, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "BİLGİSAYAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "OYUNCU PUANI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "BİLGİSAYAR PUANI";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(258, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "KAZANAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.Font = new System.Drawing.Font("Georgia Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(258, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 38);
            this.label6.TabIndex = 12;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_oyun
            // 
            this.btn_oyun.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btn_oyun.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_oyun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_oyun.BackgroundImage")));
            this.btn_oyun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_oyun.Location = new System.Drawing.Point(582, 245);
            this.btn_oyun.Name = "btn_oyun";
            this.btn_oyun.Size = new System.Drawing.Size(174, 72);
            this.btn_oyun.TabIndex = 13;
            this.btn_oyun.UseVisualStyleBackColor = false;
            this.btn_oyun.Click += new System.EventHandler(this.btn_oyun_Click);
            // 
            // Oyuncu_Puanı
            // 
            this.Oyuncu_Puanı.AutoSize = true;
            this.Oyuncu_Puanı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Oyuncu_Puanı.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Oyuncu_Puanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oyuncu_Puanı.Location = new System.Drawing.Point(240, 115);
            this.Oyuncu_Puanı.Name = "Oyuncu_Puanı";
            this.Oyuncu_Puanı.Size = new System.Drawing.Size(39, 41);
            this.Oyuncu_Puanı.TabIndex = 14;
            this.Oyuncu_Puanı.Text = "0";
            this.Oyuncu_Puanı.UseMnemonic = false;
            // 
            // Bilgisayar_Puanı
            // 
            this.Bilgisayar_Puanı.AutoSize = true;
            this.Bilgisayar_Puanı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bilgisayar_Puanı.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bilgisayar_Puanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bilgisayar_Puanı.Location = new System.Drawing.Point(491, 115);
            this.Bilgisayar_Puanı.Name = "Bilgisayar_Puanı";
            this.Bilgisayar_Puanı.Size = new System.Drawing.Size(39, 41);
            this.Bilgisayar_Puanı.TabIndex = 15;
            this.Bilgisayar_Puanı.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 405);
            this.Controls.Add(this.Bilgisayar_Puanı);
            this.Controls.Add(this.Oyuncu_Puanı);
            this.Controls.Add(this.btn_oyun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kagıt);
            this.Controls.Add(this.Makas);
            this.Controls.Add(this.Tas);
            this.Controls.Add(this.Bilgisayar);
            this.Controls.Add(this.Oyuncu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Taş-Kağıt-Makas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Oyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bilgisayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Makas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kagıt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Oyuncu;
        private System.Windows.Forms.PictureBox Bilgisayar;
        private System.Windows.Forms.PictureBox Tas;
        private System.Windows.Forms.PictureBox Makas;
        private System.Windows.Forms.PictureBox Kagıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_oyun;
        private System.Windows.Forms.Label Oyuncu_Puanı;
        private System.Windows.Forms.Label Bilgisayar_Puanı;
    }
}

