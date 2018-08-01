using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCSClass
{
    public partial class MainWindow : Form
    {
        public int pokemonCP;
        public int pokemonCurrentHP;
        public int pokemonMaxHP;
        public float pokemonHeight;
        public float pokemonWeight;
        public int NeedStarDust;
        public int NeedCandy;
        public int UserStarDust;
        public int UserCandy;
        public bool InnovationOK;
        public string pokemonName;


        public MainWindow()
        {
            // 初始化視窗元件
            InitializeComponent();

            // 初始化寶可夢
            initalData();

            // 繪製寶可夢相關視窗
            DrawPage();
        }

        public void initalData()
        {
            pokemonCP = 1860;
            pokemonCurrentHP = 999;
            pokemonMaxHP = 999;
            pokemonHeight = 21;
            pokemonWeight = 10;
            NeedStarDust = 2000;
            NeedCandy = 3;
            UserStarDust = 31000;
            UserCandy = 100000;
            InnovationOK = UserStarDust >= NeedStarDust && UserCandy >= NeedCandy;
            pokemonName = "RX-93-nu";
        }
       

        public void DrawPage()
        {
            NameLabel.Text = string.Format("Name {0}", pokemonName);
            pokemonCPLabel.Text = string.Format("CP {0}", pokemonCP);
            pokemonHPLabel.Text = string.Format("HP {0}", pokemonCurrentHP);
            pokemonMaxHPLabel.Text = string.Format("MaxHP {0}", pokemonMaxHP);
            UserCandyLabel.Text = string.Format("UserCandy {0}", UserCandy);
            UserStarDustLabel.Text = string.Format("UserStarDust {0}", UserStarDust);
            EnhanceBtn.Enabled = InnovationOK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCandy -= NeedCandy;
            UserStarDust -= NeedStarDust;
            if (UserCandy >=0 && UserStarDust >=0)
            {
                InnovationOK = UserStarDust >= NeedStarDust && UserCandy >= NeedCandy;
                DrawPage();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
