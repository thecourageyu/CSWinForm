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
        int numCarrot = 12;
        //string PicDir = "E:\\GitHub\\RabbitWinFormApp\\Reference\\RabbitHome";
        string PicDir = "E:\\GitHub\\RabbitWinFormApp\\References\\RabbitHome";

        /*public class Rabbit : Characters 
        {
            private int numCarrot;
            public int NumCarrot { get; set; }
     
            public Rabbit(int nationalId, string name, numCarrot) : base(nationalId, name)
            {
                this.numCarrot = 100;
            }
            
            protected override Characters Generate(int nationalId, string name)
            {
              
                return base.Generate(nationalId, name);
            }
        }*/

        public RabbitHome()
        {
            
            InitializeComponent();
            
            int tmp = 1;
            while(tmp < 1000)
            {
                tmp = tmp + 1;
                labCarrot.Text = tmp.ToString();
            }
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
            if(PicId == 0)
            {
                PicId = 12;
            }
            
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
            this.BackgroundImage = new Bitmap(PicDir + "/" + tmpString + "-4-01.png");
           
        }

        private void btnCarrot_Click(object sender, EventArgs e)
        {

            numCarrot = numCarrot - 1;
            if(numCarrot >= 1)
            {
                if (numCarrot == 12 - 1)
                {
                    TimeTheFirstCarrot = DateTime.Now;
                }
                DrawPage(12 - numCarrot);
            }
            else
            {
                DateTime TimeForNoCarrot = DateTime.Now;
                
                TimeSpan span = TimeForNoCarrot.Subtract(TimeTheFirstCarrot);
                TestBox.Text = span.ToString() + "s";
                while (span.Seconds <= 6)
                {

                    Thread.Sleep(1000*10);
                    
                    DateTime TimeNow = DateTime.Now;
                    span = TimeNow.Subtract(TimeTheFirstCarrot);
                    TestBox.Text = span.ToString() + "s";
                }
                numCarrot = 12;
                DrawPage(0);
            }
        }

        private void RabbitHome_Load(object sender, EventArgs e)
        {

        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            this.BattleWindow = new Battle();
            //BattleWindow.RabbitHP =
            BattleWindow.Show();
        }
    }
}
