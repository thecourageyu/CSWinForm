namespace WindowsFormsAppCSClass
{
    partial class MainWindow
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
            this.EnhanceBtn = new System.Windows.Forms.Button();
            this.pokemonCPLabel = new System.Windows.Forms.Label();
            this.pokemonHPLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pokemonMaxHPLabel = new System.Windows.Forms.Label();
            this.UserCandyLabel = new System.Windows.Forms.Label();
            this.UserStarDustLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnhanceBtn
            // 
            this.EnhanceBtn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EnhanceBtn.Location = new System.Drawing.Point(450, 358);
            this.EnhanceBtn.Name = "EnhanceBtn";
            this.EnhanceBtn.Size = new System.Drawing.Size(121, 49);
            this.EnhanceBtn.TabIndex = 0;
            this.EnhanceBtn.Text = "Enhance";
            this.EnhanceBtn.UseVisualStyleBackColor = true;
            this.EnhanceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pokemonCPLabel
            // 
            this.pokemonCPLabel.AutoSize = true;
            this.pokemonCPLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemonCPLabel.Location = new System.Drawing.Point(125, 164);
            this.pokemonCPLabel.Name = "pokemonCPLabel";
            this.pokemonCPLabel.Size = new System.Drawing.Size(44, 31);
            this.pokemonCPLabel.TabIndex = 1;
            this.pokemonCPLabel.Text = "CP";
            this.pokemonCPLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pokemonHPLabel
            // 
            this.pokemonHPLabel.AutoSize = true;
            this.pokemonHPLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemonHPLabel.Location = new System.Drawing.Point(125, 255);
            this.pokemonHPLabel.Name = "pokemonHPLabel";
            this.pokemonHPLabel.Size = new System.Drawing.Size(46, 31);
            this.pokemonHPLabel.TabIndex = 2;
            this.pokemonHPLabel.Text = "HP";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(478, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 38);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(478, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 38);
            this.textBox2.TabIndex = 4;
            // 
            // pokemonMaxHPLabel
            // 
            this.pokemonMaxHPLabel.AutoSize = true;
            this.pokemonMaxHPLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemonMaxHPLabel.Location = new System.Drawing.Point(223, 255);
            this.pokemonMaxHPLabel.Name = "pokemonMaxHPLabel";
            this.pokemonMaxHPLabel.Size = new System.Drawing.Size(94, 31);
            this.pokemonMaxHPLabel.TabIndex = 5;
            this.pokemonMaxHPLabel.Text = "MaxHP";
            // 
            // UserCandyLabel
            // 
            this.UserCandyLabel.AutoSize = true;
            this.UserCandyLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserCandyLabel.Location = new System.Drawing.Point(125, 327);
            this.UserCandyLabel.Name = "UserCandyLabel";
            this.UserCandyLabel.Size = new System.Drawing.Size(137, 31);
            this.UserCandyLabel.TabIndex = 6;
            this.UserCandyLabel.Text = "UserCandy";
            this.UserCandyLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserStarDustLabel
            // 
            this.UserStarDustLabel.AutoSize = true;
            this.UserStarDustLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserStarDustLabel.Location = new System.Drawing.Point(125, 376);
            this.UserStarDustLabel.Name = "UserStarDustLabel";
            this.UserStarDustLabel.Size = new System.Drawing.Size(164, 31);
            this.UserStarDustLabel.TabIndex = 7;
            this.UserStarDustLabel.Text = "UserStarDust";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(125, 93);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(82, 31);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UserStarDustLabel);
            this.Controls.Add(this.UserCandyLabel);
            this.Controls.Add(this.pokemonMaxHPLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pokemonHPLabel);
            this.Controls.Add(this.pokemonCPLabel);
            this.Controls.Add(this.EnhanceBtn);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnhanceBtn;
        private System.Windows.Forms.Label pokemonCPLabel;
        private System.Windows.Forms.Label pokemonHPLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label pokemonMaxHPLabel;
        private System.Windows.Forms.Label UserCandyLabel;
        private System.Windows.Forms.Label UserStarDustLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}

