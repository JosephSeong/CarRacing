
namespace CarRacing
{
    partial class Form5
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
            this.start = new System.Windows.Forms.Button();
            this.rank = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(168, 87);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(160, 60);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // rank
            // 
            this.rank.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rank.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank.ForeColor = System.Drawing.Color.Black;
            this.rank.Location = new System.Drawing.Point(168, 188);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(160, 60);
            this.rank.TabIndex = 2;
            this.rank.Text = "Ranking";
            this.rank.UseVisualStyleBackColor = false;
            this.rank.Click += new System.EventHandler(this.rank_Click);
            // 
            // logout
            // 
            this.logout.Image = global::CarRacing.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(432, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(35, 35);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 3;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CarRacing.Properties.Resources.racing11;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Black;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(12, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(188, 26);
            this.txtID.TabIndex = 14;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 657);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Racing Game";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button rank;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.TextBox txtID;
    }
}