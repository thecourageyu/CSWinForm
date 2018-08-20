using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharactersLib;


namespace BattleWinFormApp
{
    public partial class Battle : Form
    {
        string[] Names = { "無能兔", "肥熊", "海豚兔", "熊兔組合", "偷瞄兔", "路人貓", "驚嚇貓"};
        //string[] Prizes = { "PS4", "Bandai PG 能天使", "Switch", "Bandai MB 攻擊自由", "Bandai PG 攻擊", "Apple Macbook", "科學麵", "SHIT", "C# 進階班免費上課" };
        string[] Prizes = { "PS4", "Bandai PG 能天使", "C# 進階班免費上課" };
        private static Random randomObj = new Random();
        string PicDir = "E:\\GitHub\\CSWinForm\\BattleWinFormApp\\Reference";
        string RabbitPicDir = "E:\\GitHub\\CSWinForm\\RabbitWinFormApp\\References";
        static string EName;
        static Characters Enemy;

        private int exeStat;
        private int rabbitHP;
        private int rabbitMaxHp;
        private int rabbitLevel;
        private int rabbitExp;
        private int rabbitCarrots;

        public int ExeStat { get => exeStat; set => exeStat = value; }
        public int RabbitHP { get => rabbitHP; set => rabbitHP = value; }
        public int RabbitMaxHp { get => rabbitMaxHp; set => rabbitMaxHp = value; }
        public int RabbitLevel { get => rabbitLevel; set => rabbitLevel = value; }
        public int RabbitExp { get => rabbitExp; set => rabbitExp = value; }
        public int RabbitCarrots { get => rabbitCarrots; set => rabbitCarrots = value; }

        public Battle()
        {
            InitializeComponent();
            GenerateEnemy();
        }

        public void GenerateEnemy()
        {
            GC.Collect();
            int lenNames = Names.Length;
            int Id = randomObj.Next(1, lenNames + 1);
            EName = Names[Id - 1];
            Enemy = Characters.Generate(Id, Names[Id - 1]);
            enemyPicBox.Image = new Bitmap(PicDir + "\\Enemy" + Id.ToString() + ".png");
            EnemyLevel.Text = "Lv " + Enemy.Level.ToString("d02");
            EnemyName.Text = Enemy.Name;
            EnemyHP.Text = "HP   " + Enemy.Hp.ToString("d3") + " / " + Enemy.MaxHp.ToString("d3");
            //EnemyMaxHP.Text = Enemy.MaxHp.ToString();
        }

        private void btnSurrendar_Click(object sender, EventArgs e)
        {

            RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\GGRabbit.png");
            MessageBox.Show("Rabbit 投降了!\r\n好弱!\r\n紅蘿蔔 - 20!");
            rabbitCarrots = rabbitCarrots - 20;
            if (rabbitCarrots < 0)
            {
                rabbitCarrots = 0;
            }
            ExeStat = 0;
            this.Close();
        }

        //private

       

        private void Battle_Load(object sender, EventArgs e)
        {
            //richTextBox.Text = RabbitPicDir + "\\BattleRabbit.png";
            //RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\BattleRabbit.png");
            CarrotsLab.Text = RabbitCarrots.ToString();
            RabbitHpLab.Text = "HP   " + RabbitHP.ToString("d03") + " / " + RabbitMaxHp.ToString("d03");
            //RabbitMaxHpLab.Text = RabbitMaxHp.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            GC.Collect();
            RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\GoodRabbit.png");
            Thread.Sleep(500);
            int RAttack = randomObj.Next(20, 31);
            Enemy.Hp = Enemy.Hp - RAttack;
            if(Enemy.Hp <= 0)
            {
                EnemyHP.Text = "0";
                btnAttack.Enabled = false;
                btnSpecialAttack.Enabled = false;
                btnSurrendar.Enabled = false;
                YouWin();
                return;
            }
            richTextBox.Text += "Rabbit 攻擊 " + EName + " 造成 " + RAttack.ToString() + " 點傷害\r\n";
            EnemyHP.Text = Enemy.Hp.ToString();
            

            int EAttack = randomObj.Next(30, 41);
            richTextBox.Text += EName + " 攻擊 Rabbit 造成 " + EAttack.ToString() + " 點傷害\r\n";
            RabbitHP = RabbitHP - EAttack;
            if(RabbitHP <= 0)
            {
                btnAttack.Enabled = false;
                btnSpecialAttack.Enabled = false;
                btnSurrendar.Enabled = false;
                RabbitHP = 1;
                RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\GGRabbit.png");
                YouLose();
            }
            RabbitHpLab.Text = RabbitHP.ToString();
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.ScrollToCaret();
            //RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\NormalRabbit.png");
        }

        private void btnSpecialAttack_Click(object sender, EventArgs e)
        {

            if(RabbitCarrots >= 5)
            {
                RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\Rabbit&Carrot.png");
                Thread.Sleep(500);
                int RAttack = randomObj.Next(20, 31);
                RAttack *= 3;
                Enemy.Hp = Enemy.Hp - RAttack ;
                RabbitCarrots -= 5;
                CarrotsLab.Text= RabbitCarrots.ToString();
                if (Enemy.Hp <= 0)
                {
                    EnemyHP.Text = "0";
                    btnAttack.Enabled = false;
                    btnSpecialAttack.Enabled = false;
                    btnSurrendar.Enabled = false;
                    YouWin();
                    return;
                }
                richTextBox.Text += "Rabbit 特殊攻擊 " + EName + " 造成 " + RAttack.ToString() + " 點傷害\r\n";
                EnemyHP.Text = Enemy.Hp.ToString();


                int EAttack = randomObj.Next(30, 41);
                richTextBox.Text += EName + " 攻擊 Rabbit 造成 " + EAttack.ToString() + " 點傷害\r\n";
                RabbitHP = RabbitHP - EAttack;
                if (RabbitHP <= 0)
                {
                    btnAttack.Enabled = false;
                    btnSpecialAttack.Enabled = false;
                    btnSurrendar.Enabled = false;
                    RabbitHP = 1;
                    RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\GGRabbit.png");
                    YouLose();
                }
                RabbitHpLab.Text = RabbitHP.ToString();
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.ScrollToCaret();
                //RabbitPicBox.Image = new Bitmap(RabbitPicDir + "\\NormalRabbit.png");
            }
            else
            {
                MessageBox.Show("QB! 蘿蔔不足(<5)!");
            }
        }

        private void YouWin()
        {
            ExeStat = 0;
            int lenPrizes = Prizes.Length;
            int Idx = randomObj.Next(0, lenPrizes);
            RabbitCarrots += 20;
            MessageBox.Show("Rabbit 獲得勝利!\r\n紅蘿蔔 + 20!\r\n獲得 " + Prizes[Idx] + "!\r\n請找XXX領取!");
        }

        private void YouLose()
        {
            ExeStat = 0;
            MessageBox.Show("Rabbit 被打敗了!\r\n哭哭!");
        }

    }
}
