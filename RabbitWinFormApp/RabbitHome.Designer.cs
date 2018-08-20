namespace RabbitWinFormApp
{
    partial class RabbitHome
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RabbitHome));
            this.btnCarrot = new System.Windows.Forms.Button();
            this.labCarrot = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.TestBox = new System.Windows.Forms.RichTextBox();
            this.RabbitName = new System.Windows.Forms.Label();
            this.RabbitLevel = new System.Windows.Forms.Label();
            this.RabbitHP = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarrot
            // 
            this.btnCarrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCarrot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarrot.BackgroundImage")));
            this.btnCarrot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarrot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrot.FlatAppearance.BorderSize = 0;
            this.btnCarrot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCarrot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCarrot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrot.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrot.Location = new System.Drawing.Point(595, 392);
            this.btnCarrot.Name = "btnCarrot";
            this.btnCarrot.Size = new System.Drawing.Size(118, 46);
            this.btnCarrot.TabIndex = 0;
            this.btnCarrot.UseVisualStyleBackColor = false;
            this.btnCarrot.Click += new System.EventHandler(this.btnCarrot_Click);
            // 
            // labCarrot
            // 
            this.labCarrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labCarrot.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCarrot.Location = new System.Drawing.Point(600, 23);
            this.labCarrot.Name = "labCarrot";
            this.labCarrot.Size = new System.Drawing.Size(63, 36);
            this.labCarrot.TabIndex = 1;
            this.labCarrot.Text = "Carrot";
            this.labCarrot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBattle
            // 
            this.btnBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBattle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBattle.BackgroundImage")));
            this.btnBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBattle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBattle.FlatAppearance.BorderSize = 0;
            this.btnBattle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBattle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBattle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(474, 392);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(118, 46);
            this.btnBattle.TabIndex = 2;
            this.btnBattle.UseVisualStyleBackColor = false;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(12, 12);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(65, 39);
            this.TestBox.TabIndex = 3;
            this.TestBox.Text = "";
            // 
            // RabbitName
            // 
            this.RabbitName.Location = new System.Drawing.Point(602, 172);
            this.RabbitName.Name = "RabbitName";
            this.RabbitName.Size = new System.Drawing.Size(65, 23);
            this.RabbitName.TabIndex = 13;
            this.RabbitName.Text = "Name";
            this.RabbitName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RabbitLevel
            // 
            this.RabbitLevel.Location = new System.Drawing.Point(547, 172);
            this.RabbitLevel.Name = "RabbitLevel";
            this.RabbitLevel.Size = new System.Drawing.Size(45, 23);
            this.RabbitLevel.TabIndex = 12;
            this.RabbitLevel.Text = "Level";
            this.RabbitLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RabbitHP
            // 
            this.RabbitHP.Location = new System.Drawing.Point(547, 207);
            this.RabbitHP.Name = "RabbitHP";
            this.RabbitHP.Size = new System.Drawing.Size(116, 23);
            this.RabbitHP.TabIndex = 11;
            this.RabbitHP.Text = "HP";
            this.RabbitHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHeal
            // 
            this.btnHeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHeal.BackgroundImage")));
            this.btnHeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHeal.FlatAppearance.BorderSize = 0;
            this.btnHeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnHeal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHeal.Location = new System.Drawing.Point(350, 392);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(118, 46);
            this.btnHeal.TabIndex = 14;
            this.btnHeal.UseVisualStyleBackColor = false;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(522, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 36);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RabbitHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RabbitHP);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.RabbitName);
            this.Controls.Add(this.RabbitLevel);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.labCarrot);
            this.Controls.Add(this.btnCarrot);
            this.Name = "RabbitHome";
            this.Text = "Rabbit&Rabbit";
            this.Load += new System.EventHandler(this.RabbitHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarrot;
        private System.Windows.Forms.Label labCarrot;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.RichTextBox TestBox;
        private System.Windows.Forms.Label RabbitName;
        private System.Windows.Forms.Label RabbitLevel;
        private System.Windows.Forms.Label RabbitHP;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

