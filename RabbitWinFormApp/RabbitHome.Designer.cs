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
            this.RabbitMaxHP = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarrot
            // 
            this.btnCarrot.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrot.Location = new System.Drawing.Point(615, 404);
            this.btnCarrot.Name = "btnCarrot";
            this.btnCarrot.Size = new System.Drawing.Size(102, 34);
            this.btnCarrot.TabIndex = 0;
            this.btnCarrot.Text = "Collect Carrot";
            this.btnCarrot.UseVisualStyleBackColor = true;
            this.btnCarrot.Click += new System.EventHandler(this.btnCarrot_Click);
            // 
            // labCarrot
            // 
            this.labCarrot.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCarrot.Location = new System.Drawing.Point(591, 25);
            this.labCarrot.Name = "labCarrot";
            this.labCarrot.Size = new System.Drawing.Size(98, 23);
            this.labCarrot.TabIndex = 1;
            this.labCarrot.Text = "Carrot";
            this.labCarrot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBattle
            // 
            this.btnBattle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(507, 404);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(102, 34);
            this.btnBattle.TabIndex = 2;
            this.btnBattle.Text = "Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(124, 12);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(217, 134);
            this.TestBox.TabIndex = 3;
            this.TestBox.Text = "";
            // 
            // RabbitName
            // 
            this.RabbitName.Location = new System.Drawing.Point(598, 172);
            this.RabbitName.Name = "RabbitName";
            this.RabbitName.Size = new System.Drawing.Size(91, 23);
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
            this.RabbitHP.Size = new System.Drawing.Size(68, 23);
            this.RabbitHP.TabIndex = 11;
            this.RabbitHP.Text = "HP";
            this.RabbitHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RabbitMaxHP
            // 
            this.RabbitMaxHP.Location = new System.Drawing.Point(621, 207);
            this.RabbitMaxHP.Name = "RabbitMaxHP";
            this.RabbitMaxHP.Size = new System.Drawing.Size(68, 23);
            this.RabbitMaxHP.TabIndex = 10;
            this.RabbitMaxHP.Text = "MaxHP";
            this.RabbitMaxHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHeal
            // 
            this.btnHeal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.Location = new System.Drawing.Point(399, 404);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(102, 34);
            this.btnHeal.TabIndex = 14;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // RabbitHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.RabbitName);
            this.Controls.Add(this.RabbitLevel);
            this.Controls.Add(this.RabbitHP);
            this.Controls.Add(this.RabbitMaxHP);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.labCarrot);
            this.Controls.Add(this.btnCarrot);
            this.Name = "RabbitHome";
            this.Text = "Rabbit&Rabbit";
            this.Load += new System.EventHandler(this.RabbitHome_Load);
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
        private System.Windows.Forms.Label RabbitMaxHP;
        private System.Windows.Forms.Button btnHeal;
    }
}

