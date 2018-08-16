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
using BattleWinFormApp;

namespace RabbitWinFormApp
{
    public partial class RabbitHome : Form
    {
       
        DateTime TimeTheFirstCarrot = DateTime.Now;
        private Battle BattleWindow;
        static int numCarrots = 10;
        static int needExp = 10;
        int remainingCarrot = 12;
        //Rabbit rabbit = GenerateRabbit(1, 100, 100, 0, 0, numCarrots);
        //string PicDir = "E:\\GitHub\\RabbitWinFormApp\\Reference\\RabbitHome";
        string PicDir = "E:\\GitHub\\CSWinForm\\RabbitWinFormApp\\References\\RabbitHome";
        Rabbit rabbit = GenerateRabbit(1, 100, 100, 0, 0, numCarrots);

        public class Rabbit : Characters 
        {
            public int NumCarrot { get; set; }
            
            public Rabbit(int nationalId, string name, int level, int hp, int maxHp, int powerUpCandy, int powerUpStardust, int numCarrot) : base(nationalId, name)
            {
                this.NumCarrot = numCarrot;
                
            }
        }

        public static Rabbit GenerateRabbit(int level, int hp, int maxHp, int powerUpCandy, int powerUpStardust, int numCarrot)
        {
            
            Rabbit rabbit = new Rabbit(99, "Rabbit", level, hp, maxHp, powerUpCandy, powerUpCandy, numCarrot);
            return rabbit;
        }

        private void AttrShow()
        {
            RabbitName.Text = rabbit.Name;
            RabbitLevel.Text = rabbit.Level.ToString();
            RabbitHP.Text = rabbit.Hp.ToString();
            RabbitMaxHP.Text = rabbit.MaxHp.ToString();
            labCarrot.Text = numCarrots.ToString();
        }


        public RabbitHome()
        {
            
            InitializeComponent();
            this.DoubleBuffered = true;//設置本窗體
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 雙緩衝
            AttrShow();


            //GenerateRabbit();
        }

        /*
        public void GenerateRabbit()
        {
            Characters RabbitObj = Characters.Generate(Id, Names[Id - 1]);
            EnemyLevel.Text = Enemy.Level.ToString();
            EnemyName.Text = Enemy.Name;
            EnemyHP.Text = Enemy.Hp.ToString();
            EnemyMaxHP.Text = Enemy.MaxHp.ToString();
        }
        */
        private void DrawPage(int PicId)
        {
            string tmpString;
           

            tmpString = PicId <= 9 ? "0" + PicId.ToString() : PicId.ToString();


            //tmpString = PicDir + "/" + tmpString + "-1-01.png";

            TestBox.Text = PicDir + "\\" + tmpString + "-1-01.png";

            /*
            this.BackgroundImage = new Bitmap(PicDir + "/" + tmpString + "-1-01.png");
            Thread.Sleep(1000);
            this.BackgroundImage = new Bitmap(PicDir + "/" + tmpString + "-2-01.png");
            Thread.Sleep(1000);
            this.BackgroundImage = new Bitmap(PicDir + "/" + tmpString + "-3-01.png");
            Thread.Sleep(1000); 
            */
            if (PicId == 0)
            {

                this.BackgroundImage = new Bitmap(PicDir + "/" + tmpString + "-01.png");
            }
            else
            {
                GC.Collect();
                Bitmap bmp = new Bitmap(PicDir + "/" + tmpString + "-4-01.png");
                //this.BackgroundImage = new Bitmap(PicDir + "/" + tmpString + "-4-01.png");
                this.BackgroundImage = bmp;
            }


        }

    

        private async void btnCarrot_Click(object sender, EventArgs e)
        {
            numCarrots = numCarrots + 1;
            labCarrot.Text = numCarrots.ToString();
            remainingCarrot = remainingCarrot - 1;
            if(remainingCarrot >= 1)
            {
                if (remainingCarrot == 12 - 1)
                {
                    TimeTheFirstCarrot = DateTime.Now;
                }
                DrawPage(12 - remainingCarrot);
            }
            else
            {
                DrawPage(12);
                DateTime TimeForNoCarrot = DateTime.Now;

                TimeSpan span = TimeForNoCarrot.Subtract(TimeTheFirstCarrot);
                TestBox.Text = span.ToString() + "s";
                while (span.Seconds <= 10)
                {
                    btnCarrot.Enabled = false;

                    //Thread.Sleep(1000*10);
                    await Task.Delay(3000);

                    DateTime TimeNow = DateTime.Now;
                    span = TimeNow.Subtract(TimeTheFirstCarrot);
                    TestBox.Text = span.Seconds.ToString() + "s";
                    
                }
                DrawPage(0);
                
                remainingCarrot = 12;
                btnCarrot.Enabled = true;
            }
        }

        private void RabbitHome_Load(object sender, EventArgs e)
        {

        }

        private async void btnBattle_Click(object sender, EventArgs e)
        {
            //this.BattleWindow = new Battle();

            Battle BattleWindow = new Battle();
            //BattleWindow.RabbitHP =

            BattleWindow.Owner = this;
            BattleWindow.ExeStat = 99;


            BattleWindow.RabbitHP = rabbit.Hp;
            BattleWindow.RabbitMaxHp = rabbit.MaxHp;
            BattleWindow.RabbitLevel = rabbit.Level;
            BattleWindow.RabbitExp = needExp;
            BattleWindow.RabbitCarrots = numCarrots;
            btnBattle.Enabled = false;
            BattleWindow.Show();

            while (BattleWindow.ExeStat != 0)
            {
                await Task.Delay(3000);
                TestBox.Text += BattleWindow.ExeStat.ToString() + "\r\n";
                TestBox.Text += BattleWindow.RabbitCarrots.ToString() + "\r\n";
                BtnAlive();
            }


            rabbit.Hp = BattleWindow.RabbitHP;
            numCarrots = BattleWindow.RabbitCarrots;
            AttrShow();
            TestBox.Text = "rabbit.HP = " + BattleWindow.RabbitHP;

            //BattleWindow.FormClosed += FormClosedEventHandler(Form2_FormClosed);


            //btnBattle.Enabled = false;


        }

        void BtnAlive()
        {
            btnBattle.Enabled = true;
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            int remainingHP = rabbit.MaxHp - rabbit.Hp;
            if (numCarrots >= remainingHP)
            {
                numCarrots = numCarrots - remainingHP;
                rabbit.Hp = rabbit.MaxHp;
            }
            else
            {
                
                rabbit.Hp = rabbit.Hp + numCarrots;
                numCarrots = 0;
            }
            AttrShow();
        }
    }
}
