namespace BattleWinFormApp
{
    partial class Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle));
            this.btnAttack = new System.Windows.Forms.Button();
            this.enemyPicBox = new System.Windows.Forms.PictureBox();
            this.btnSpecialAttack = new System.Windows.Forms.Button();
            this.btnSurrendar = new System.Windows.Forms.Button();
            this.EnemyHP = new System.Windows.Forms.Label();
            this.EnemyLevel = new System.Windows.Forms.Label();
            this.EnemyName = new System.Windows.Forms.Label();
            this.RabbitPicBox = new System.Windows.Forms.PictureBox();
            this.RabbitHpLab = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.CarrotsLab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RabbitPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAttack.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAttack.Location = new System.Drawing.Point(368, 310);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(79, 25);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "攻擊";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // enemyPicBox
            // 
            this.enemyPicBox.BackColor = System.Drawing.Color.White;
            this.enemyPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemyPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enemyPicBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyPicBox.Image")));
            this.enemyPicBox.Location = new System.Drawing.Point(162, 12);
            this.enemyPicBox.Name = "enemyPicBox";
            this.enemyPicBox.Size = new System.Drawing.Size(160, 147);
            this.enemyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPicBox.TabIndex = 3;
            this.enemyPicBox.TabStop = false;
            // 
            // btnSpecialAttack
            // 
            this.btnSpecialAttack.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSpecialAttack.Location = new System.Drawing.Point(368, 341);
            this.btnSpecialAttack.Name = "btnSpecialAttack";
            this.btnSpecialAttack.Size = new System.Drawing.Size(79, 25);
            this.btnSpecialAttack.TabIndex = 4;
            this.btnSpecialAttack.Text = "特殊攻擊";
            this.btnSpecialAttack.UseVisualStyleBackColor = true;
            this.btnSpecialAttack.Click += new System.EventHandler(this.btnSpecialAttack_Click);
            // 
            // btnSurrendar
            // 
            this.btnSurrendar.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSurrendar.Location = new System.Drawing.Point(368, 372);
            this.btnSurrendar.Name = "btnSurrendar";
            this.btnSurrendar.Size = new System.Drawing.Size(79, 25);
            this.btnSurrendar.TabIndex = 5;
            this.btnSurrendar.Text = "投降";
            this.btnSurrendar.UseVisualStyleBackColor = true;
            this.btnSurrendar.Click += new System.EventHandler(this.btnSurrendar_Click);
            // 
            // EnemyHP
            // 
            this.EnemyHP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHP.Location = new System.Drawing.Point(26, 47);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(130, 23);
            this.EnemyHP.TabIndex = 7;
            this.EnemyHP.Text = "HP";
            this.EnemyHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyLevel
            // 
            this.EnemyLevel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLevel.Location = new System.Drawing.Point(26, 12);
            this.EnemyLevel.Name = "EnemyLevel";
            this.EnemyLevel.Size = new System.Drawing.Size(52, 23);
            this.EnemyLevel.TabIndex = 8;
            this.EnemyLevel.Text = "Level";
            this.EnemyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyName
            // 
            this.EnemyName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EnemyName.Location = new System.Drawing.Point(84, 12);
            this.EnemyName.Name = "EnemyName";
            this.EnemyName.Size = new System.Drawing.Size(72, 23);
            this.EnemyName.TabIndex = 9;
            this.EnemyName.Text = "Name";
            this.EnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RabbitPicBox
            // 
            this.RabbitPicBox.BackColor = System.Drawing.Color.White;
            this.RabbitPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RabbitPicBox.Image = ((System.Drawing.Image)(resources.GetObject("RabbitPicBox.Image")));
            this.RabbitPicBox.Location = new System.Drawing.Point(453, 268);
            this.RabbitPicBox.Name = "RabbitPicBox";
            this.RabbitPicBox.Size = new System.Drawing.Size(161, 147);
            this.RabbitPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RabbitPicBox.TabIndex = 10;
            this.RabbitPicBox.TabStop = false;
            // 
            // RabbitHpLab
            // 
            this.RabbitHpLab.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RabbitHpLab.Location = new System.Drawing.Point(317, 268);
            this.RabbitHpLab.Name = "RabbitHpLab";
            this.RabbitHpLab.Size = new System.Drawing.Size(130, 23);
            this.RabbitHpLab.TabIndex = 12;
            this.RabbitHpLab.Text = "HP";
            this.RabbitHpLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox.Location = new System.Drawing.Point(339, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(275, 147);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "";
            // 
            // CarrotsLab
            // 
            this.CarrotsLab.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarrotsLab.Location = new System.Drawing.Point(297, 341);
            this.CarrotsLab.Name = "CarrotsLab";
            this.CarrotsLab.Size = new System.Drawing.Size(65, 25);
            this.CarrotsLab.TabIndex = 15;
            this.CarrotsLab.Text = "Carrots";
            this.CarrotsLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(297, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 25);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CarrotsLab);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.RabbitHpLab);
            this.Controls.Add(this.RabbitPicBox);
            this.Controls.Add(this.EnemyName);
            this.Controls.Add(this.EnemyLevel);
            this.Controls.Add(this.EnemyHP);
            this.Controls.Add(this.btnSurrendar);
            this.Controls.Add(this.btnSpecialAttack);
            this.Controls.Add(this.enemyPicBox);
            this.Controls.Add(this.btnAttack);
            this.Name = "Battle";
            this.Text = "Batltle";
            this.Load += new System.EventHandler(this.Battle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RabbitPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox enemyPicBox;
        private System.Windows.Forms.Button btnSpecialAttack;
        private System.Windows.Forms.Button btnSurrendar;
        private System.Windows.Forms.Label EnemyHP;
        private System.Windows.Forms.Label EnemyLevel;
        private System.Windows.Forms.Label EnemyName;
        private System.Windows.Forms.PictureBox RabbitPicBox;
        private System.Windows.Forms.Label RabbitHpLab;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label CarrotsLab;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

