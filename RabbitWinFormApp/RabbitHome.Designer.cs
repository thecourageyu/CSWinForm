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
            this.SuspendLayout();
            // 
            // btnCarrot
            // 
            this.btnCarrot.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrot.Location = new System.Drawing.Point(567, 391);
            this.btnCarrot.Name = "btnCarrot";
            this.btnCarrot.Size = new System.Drawing.Size(122, 47);
            this.btnCarrot.TabIndex = 0;
            this.btnCarrot.Text = "Collect Carrot";
            this.btnCarrot.UseVisualStyleBackColor = true;
            this.btnCarrot.Click += new System.EventHandler(this.btnCarrot_Click);
            // 
            // labCarrot
            // 
            this.labCarrot.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCarrot.Location = new System.Drawing.Point(503, 9);
            this.labCarrot.Name = "labCarrot";
            this.labCarrot.Size = new System.Drawing.Size(98, 23);
            this.labCarrot.TabIndex = 1;
            this.labCarrot.Text = "Carrot";
            this.labCarrot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBattle
            // 
            this.btnBattle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(422, 391);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(122, 47);
            this.btnBattle.TabIndex = 2;
            this.btnBattle.Text = "Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(444, 51);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(217, 134);
            this.TestBox.TabIndex = 3;
            this.TestBox.Text = "";
            // 
            // RabbitHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 450);
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
    }
}

