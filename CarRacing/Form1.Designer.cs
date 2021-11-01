
namespace CarRacing
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textResult = new System.Windows.Forms.Label();
            this.money3 = new System.Windows.Forms.PictureBox();
            this.money2 = new System.Windows.Forms.PictureBox();
            this.money1 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.roadtrack2 = new System.Windows.Forms.PictureBox();
            this.roadtrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.textCoin = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.money3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.textResult);
            this.panel1.Controls.Add(this.money3);
            this.panel1.Controls.Add(this.money2);
            this.panel1.Controls.Add(this.money1);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.roadtrack2);
            this.panel1.Controls.Add(this.roadtrack1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 519);
            this.panel1.TabIndex = 0;
            // 
            // textResult
            // 
            this.textResult.AutoSize = true;
            this.textResult.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textResult.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.ForeColor = System.Drawing.Color.White;
            this.textResult.Location = new System.Drawing.Point(60, 180);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(0, 77);
            this.textResult.TabIndex = 6;
            // 
            // money3
            // 
            this.money3.Image = global::CarRacing.Properties.Resources.doge;
            this.money3.Location = new System.Drawing.Point(169, 144);
            this.money3.Name = "money3";
            this.money3.Size = new System.Drawing.Size(46, 46);
            this.money3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.money3.TabIndex = 12;
            this.money3.TabStop = false;
            this.money3.Tag = "coinCenter";
            // 
            // money2
            // 
            this.money2.Image = global::CarRacing.Properties.Resources.doge;
            this.money2.Location = new System.Drawing.Point(395, 47);
            this.money2.Name = "money2";
            this.money2.Size = new System.Drawing.Size(46, 46);
            this.money2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.money2.TabIndex = 11;
            this.money2.TabStop = false;
            this.money2.Tag = "coinRight";
            // 
            // money1
            // 
            this.money1.Image = global::CarRacing.Properties.Resources.doge;
            this.money1.Location = new System.Drawing.Point(26, 11);
            this.money1.Name = "money1";
            this.money1.Size = new System.Drawing.Size(46, 46);
            this.money1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.money1.TabIndex = 10;
            this.money1.TabStop = false;
            this.money1.Tag = "coinLeft";
            // 
            // A1
            // 
            this.A1.Image = global::CarRacing.Properties.Resources.neocar;
            this.A1.Location = new System.Drawing.Point(86, 47);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(54, 109);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 9;
            this.A1.TabStop = false;
            this.A1.Tag = "carLeft";
            // 
            // explosion
            // 
            this.explosion.Image = global::CarRacing.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(140, 330);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(145, 148);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.explosion.TabIndex = 8;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::CarRacing.Properties.Resources.sportcar48;
            this.player.Location = new System.Drawing.Point(193, 384);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 115);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 7;
            this.player.TabStop = false;
            // 
            // A2
            // 
            this.A2.Image = global::CarRacing.Properties.Resources.poicecar11;
            this.A2.Location = new System.Drawing.Point(249, 85);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(56, 108);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 5;
            this.A2.TabStop = false;
            this.A2.Tag = "carRight";
            // 
            // roadtrack2
            // 
            this.roadtrack2.Image = global::CarRacing.Properties.Resources.roadtrack;
            this.roadtrack2.Location = new System.Drawing.Point(0, 0);
            this.roadtrack2.Name = "roadtrack2";
            this.roadtrack2.Size = new System.Drawing.Size(475, 519);
            this.roadtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack2.TabIndex = 3;
            this.roadtrack2.TabStop = false;
            // 
            // roadtrack1
            // 
            this.roadtrack1.Image = global::CarRacing.Properties.Resources.roadtrack;
            this.roadtrack1.Location = new System.Drawing.Point(0, -519);
            this.roadtrack1.Name = "roadtrack1";
            this.roadtrack1.Size = new System.Drawing.Size(475, 519);
            this.roadtrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack1.TabIndex = 2;
            this.roadtrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(164, 580);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 56);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.ForeColor = System.Drawing.Color.White;
            this.textScore.Location = new System.Drawing.Point(12, 532);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(81, 29);
            this.textScore.TabIndex = 1;
            this.textScore.Text = "score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // textCoin
            // 
            this.textCoin.AutoSize = true;
            this.textCoin.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCoin.ForeColor = System.Drawing.Color.White;
            this.textCoin.Location = new System.Drawing.Point(135, 532);
            this.textCoin.Name = "textCoin";
            this.textCoin.Size = new System.Drawing.Size(70, 29);
            this.textCoin.TabIndex = 2;
            this.textCoin.Text = "coin : 0";
            // 
            // menu
            // 
            this.menu.Image = global::CarRacing.Properties.Resources.menu;
            this.menu.Location = new System.Drawing.Point(428, 534);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(35, 35);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 5;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 10);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Black;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(353, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 26);
            this.txtID.TabIndex = 13;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(476, 657);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textCoin);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Racing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.money3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox roadtrack2;
        private System.Windows.Forms.PictureBox roadtrack1;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.Label textCoin;
        private System.Windows.Forms.PictureBox money3;
        private System.Windows.Forms.PictureBox money2;
        private System.Windows.Forms.PictureBox money1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Label textResult;
        private System.Windows.Forms.TextBox txtID;
    }
}

