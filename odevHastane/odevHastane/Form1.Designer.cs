
namespace odevHastane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btnhastagirisi = new System.Windows.Forms.Button();
            this.Btndoktorgiris = new System.Windows.Forms.Button();
            this.Btnsekretergiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnhastagirisi
            // 
            this.Btnhastagirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnhastagirisi.BackgroundImage")));
            this.Btnhastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnhastagirisi.Location = new System.Drawing.Point(47, 183);
            this.Btnhastagirisi.Name = "Btnhastagirisi";
            this.Btnhastagirisi.Size = new System.Drawing.Size(245, 149);
            this.Btnhastagirisi.TabIndex = 0;
            this.Btnhastagirisi.UseVisualStyleBackColor = true;
            this.Btnhastagirisi.Click += new System.EventHandler(this.Btnhastagirisi_Click);
            // 
            // Btndoktorgiris
            // 
            this.Btndoktorgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btndoktorgiris.BackgroundImage")));
            this.Btndoktorgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btndoktorgiris.Location = new System.Drawing.Point(374, 183);
            this.Btndoktorgiris.Name = "Btndoktorgiris";
            this.Btndoktorgiris.Size = new System.Drawing.Size(245, 149);
            this.Btndoktorgiris.TabIndex = 1;
            this.Btndoktorgiris.UseVisualStyleBackColor = true;
            this.Btndoktorgiris.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btnsekretergiris
            // 
            this.Btnsekretergiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnsekretergiris.BackgroundImage")));
            this.Btnsekretergiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnsekretergiris.Location = new System.Drawing.Point(681, 183);
            this.Btnsekretergiris.Name = "Btnsekretergiris";
            this.Btnsekretergiris.Size = new System.Drawing.Size(245, 149);
            this.Btnsekretergiris.TabIndex = 2;
            this.Btnsekretergiris.UseVisualStyleBackColor = true;
            this.Btnsekretergiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(420, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(723, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(986, 120);
            this.label4.TabIndex = 6;
            this.label4.Text = "CAN HASTANESİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(979, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnsekretergiris);
            this.Controls.Add(this.Btndoktorgiris);
            this.Controls.Add(this.Btnhastagirisi);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CAN HASTANESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnhastagirisi;
        private System.Windows.Forms.Button Btndoktorgiris;
        private System.Windows.Forms.Button Btnsekretergiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

