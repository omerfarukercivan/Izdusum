
namespace Izdusum
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
            this.btnIzoEksen = new System.Windows.Forms.Button();
            this.btnBirim = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOtele = new System.Windows.Forms.Button();
            this.btnOlcekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txty1 = new System.Windows.Forms.TextBox();
            this.txtz1 = new System.Windows.Forms.TextBox();
            this.txtz2 = new System.Windows.Forms.TextBox();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzoEksen
            // 
            this.btnIzoEksen.Location = new System.Drawing.Point(12, 12);
            this.btnIzoEksen.Name = "btnIzoEksen";
            this.btnIzoEksen.Size = new System.Drawing.Size(120, 60);
            this.btnIzoEksen.TabIndex = 1;
            this.btnIzoEksen.Text = "Eksenleri Çiz (XYZ)";
            this.btnIzoEksen.UseVisualStyleBackColor = true;
            this.btnIzoEksen.Click += new System.EventHandler(this.btnIzoEksen_Click);
            // 
            // btnBirim
            // 
            this.btnBirim.Location = new System.Drawing.Point(12, 78);
            this.btnBirim.Name = "btnBirim";
            this.btnBirim.Size = new System.Drawing.Size(120, 60);
            this.btnBirim.TabIndex = 2;
            this.btnBirim.Text = "Cismin İzometrik İzdüşümünü Al";
            this.btnBirim.UseVisualStyleBackColor = true;
            this.btnBirim.Click += new System.EventHandler(this.btnBirim_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 381);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 60);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOtele
            // 
            this.btnOtele.Location = new System.Drawing.Point(12, 162);
            this.btnOtele.Name = "btnOtele";
            this.btnOtele.Size = new System.Drawing.Size(120, 80);
            this.btnOtele.TabIndex = 4;
            this.btnOtele.Text = "ÖTELE";
            this.btnOtele.UseVisualStyleBackColor = true;
            this.btnOtele.Click += new System.EventHandler(this.btnOtele_Click);
            // 
            // btnOlcekle
            // 
            this.btnOlcekle.Location = new System.Drawing.Point(12, 270);
            this.btnOlcekle.Name = "btnOlcekle";
            this.btnOlcekle.Size = new System.Drawing.Size(120, 80);
            this.btnOlcekle.TabIndex = 5;
            this.btnOlcekle.Text = "ÖLÇEKLE";
            this.btnOlcekle.UseVisualStyleBackColor = true;
            this.btnOlcekle.Click += new System.EventHandler(this.btnOlcekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "x:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "z:";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(160, 162);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(100, 22);
            this.txtx1.TabIndex = 18;
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(160, 191);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(100, 22);
            this.txty1.TabIndex = 19;
            // 
            // txtz1
            // 
            this.txtz1.Location = new System.Drawing.Point(160, 220);
            this.txtz1.Name = "txtz1";
            this.txtz1.Size = new System.Drawing.Size(100, 22);
            this.txtz1.TabIndex = 20;
            // 
            // txtz2
            // 
            this.txtz2.Location = new System.Drawing.Point(160, 328);
            this.txtz2.Name = "txtz2";
            this.txtz2.Size = new System.Drawing.Size(100, 22);
            this.txtz2.TabIndex = 23;
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(160, 299);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(100, 22);
            this.txty2.TabIndex = 22;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(160, 270);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(100, 22);
            this.txtx2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.txtz2);
            this.Controls.Add(this.txty2);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.txtz1);
            this.Controls.Add(this.txty1);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOlcekle);
            this.Controls.Add(this.btnOtele);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnBirim);
            this.Controls.Add(this.btnIzoEksen);
            this.Name = "Form1";
            this.Text = "İzdüşüm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIzoEksen;
        private System.Windows.Forms.Button btnBirim;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOtele;
        private System.Windows.Forms.Button btnOlcekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.TextBox txtz1;
        private System.Windows.Forms.TextBox txtz2;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.TextBox txtx2;
    }
}

