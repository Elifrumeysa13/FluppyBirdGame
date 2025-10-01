namespace FluppyBirdGame
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
            this.lblScore = new System.Windows.Forms.Label();
            this.pipeBottom3 = new System.Windows.Forms.PictureBox();
            this.pipeTop3 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Indigo;
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScore.Location = new System.Drawing.Point(1019, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 16);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Skor : 0";
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.BackColor = System.Drawing.Color.MediumPurple;
            this.pipeBottom3.Location = new System.Drawing.Point(900, 350);
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.Size = new System.Drawing.Size(100, 350);
            this.pipeBottom3.TabIndex = 6;
            this.pipeBottom3.TabStop = false;
            this.pipeBottom3.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pipeTop3
            // 
            this.pipeTop3.BackColor = System.Drawing.Color.MediumPurple;
            this.pipeTop3.Location = new System.Drawing.Point(900, 0);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Size = new System.Drawing.Size(100, 150);
            this.pipeTop3.TabIndex = 5;
            this.pipeTop3.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.MediumPurple;
            this.pipeBottom2.Location = new System.Drawing.Point(650, 500);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(100, 200);
            this.pipeBottom2.TabIndex = 4;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.MediumPurple;
            this.pipeTop2.Location = new System.Drawing.Point(650, 0);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(100, 300);
            this.pipeTop2.TabIndex = 3;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.BackColor = System.Drawing.Color.MediumPurple;
            this.pipeBottom1.Location = new System.Drawing.Point(400, 450);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(100, 250);
            this.pipeBottom1.TabIndex = 2;
            this.pipeBottom1.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.BackColor = System.Drawing.Color.MediumPurple;
            this.pipeTop1.Location = new System.Drawing.Point(400, 0);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(100, 250);
            this.pipeTop1.TabIndex = 1;
            this.pipeTop1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::FluppyBirdGame.Properties.Resources.bird;
            this.player.Location = new System.Drawing.Point(100, 300);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 80);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop3;
        private System.Windows.Forms.PictureBox pipeBottom3;
        private System.Windows.Forms.Label lblScore;
    }
}

