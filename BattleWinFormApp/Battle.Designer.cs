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
            this.EnemyMaxHP = new System.Windows.Forms.Label();
            this.EnemyHP = new System.Windows.Forms.Label();
            this.EnemyLevel = new System.Windows.Forms.Label();
            this.EnemyName = new System.Windows.Forms.Label();
            this.RabbitPicBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RabbitPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(354, 280);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(93, 44);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "攻擊";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // enemyPicBox
            // 
            this.enemyPicBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyPicBox.Image")));
            this.enemyPicBox.Location = new System.Drawing.Point(162, 12);
            this.enemyPicBox.Name = "enemyPicBox";
            this.enemyPicBox.Size = new System.Drawing.Size(161, 147);
            this.enemyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPicBox.TabIndex = 3;
            this.enemyPicBox.TabStop = false;
            // 
            // btnSpecialAttack
            // 
            this.btnSpecialAttack.Location = new System.Drawing.Point(354, 330);
            this.btnSpecialAttack.Name = "btnSpecialAttack";
            this.btnSpecialAttack.Size = new System.Drawing.Size(93, 44);
            this.btnSpecialAttack.TabIndex = 4;
            this.btnSpecialAttack.Text = "特殊攻擊";
            this.btnSpecialAttack.UseVisualStyleBackColor = true;
            // 
            // btnSurrendar
            // 
            this.btnSurrendar.Location = new System.Drawing.Point(354, 380);
            this.btnSurrendar.Name = "btnSurrendar";
            this.btnSurrendar.Size = new System.Drawing.Size(93, 44);
            this.btnSurrendar.TabIndex = 5;
            this.btnSurrendar.Text = "投降";
            this.btnSurrendar.UseVisualStyleBackColor = true;
            // 
            // EnemyMaxHP
            // 
            this.EnemyMaxHP.Location = new System.Drawing.Point(88, 47);
            this.EnemyMaxHP.Name = "EnemyMaxHP";
            this.EnemyMaxHP.Size = new System.Drawing.Size(68, 23);
            this.EnemyMaxHP.TabIndex = 6;
            this.EnemyMaxHP.Text = "MaxHP";
            this.EnemyMaxHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyHP
            // 
            this.EnemyHP.Location = new System.Drawing.Point(14, 47);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(68, 23);
            this.EnemyHP.TabIndex = 7;
            this.EnemyHP.Text = "HP";
            this.EnemyHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyLevel
            // 
            this.EnemyLevel.Location = new System.Drawing.Point(14, 12);
            this.EnemyLevel.Name = "EnemyLevel";
            this.EnemyLevel.Size = new System.Drawing.Size(45, 23);
            this.EnemyLevel.TabIndex = 8;
            this.EnemyLevel.Text = "Level";
            this.EnemyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyName
            // 
            this.EnemyName.Location = new System.Drawing.Point(65, 12);
            this.EnemyName.Name = "EnemyName";
            this.EnemyName.Size = new System.Drawing.Size(91, 23);
            this.EnemyName.TabIndex = 9;
            this.EnemyName.Text = "Name";
            this.EnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RabbitPicBox
            // 
            this.RabbitPicBox.Image = ((System.Drawing.Image)(resources.GetObject("RabbitPicBox.Image")));
            this.RabbitPicBox.Location = new System.Drawing.Point(453, 245);
            this.RabbitPicBox.Name = "RabbitPicBox";
            this.RabbitPicBox.Size = new System.Drawing.Size(161, 147);
            this.RabbitPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RabbitPicBox.TabIndex = 10;
            this.RabbitPicBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(305, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "HP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(379, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "MaxHP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(339, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 147);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(593, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 147);
            this.vScrollBar1.TabIndex = 14;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RabbitPicBox);
            this.Controls.Add(this.EnemyName);
            this.Controls.Add(this.EnemyLevel);
            this.Controls.Add(this.EnemyHP);
            this.Controls.Add(this.EnemyMaxHP);
            this.Controls.Add(this.btnSurrendar);
            this.Controls.Add(this.btnSpecialAttack);
            this.Controls.Add(this.enemyPicBox);
            this.Controls.Add(this.btnAttack);
            this.Name = "Battle";
            this.Text = "Batltle";
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RabbitPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox enemyPicBox;
        private System.Windows.Forms.Button btnSpecialAttack;
        private System.Windows.Forms.Button btnSurrendar;
        private System.Windows.Forms.Label EnemyMaxHP;
        private System.Windows.Forms.Label EnemyHP;
        private System.Windows.Forms.Label EnemyLevel;
        private System.Windows.Forms.Label EnemyName;
        private System.Windows.Forms.PictureBox RabbitPicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

