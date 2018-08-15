using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharactersLib;

namespace BattleWinFormApp
{
    public partial class Battle : Form
    {
        string[] Names = { "無能兔", "肥熊", "海豚兔", "熊兔組合", "偷瞄兔", "路人貓", "驚嚇貓"};

        Random randomObj = new Random();

        public int RabbitHP;
        
        public Battle()
        {
            InitializeComponent();
            GenerateEnemy();
        }

        public void GenerateEnemy()
        {
            int lenNames = Names.Length;
            int Id = randomObj.Next(1, lenNames + 1);
            Characters Enemy = Characters.Generate(Id, Names[Id - 1]);
            EnemyLevel.Text = Enemy.Level.ToString();
            EnemyName.Text = Enemy.Name;
            EnemyHP.Text = Enemy.Hp.ToString();
            EnemyMaxHP.Text = Enemy.MaxHp.ToString();
        }

        private void btnSurrendar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GG");
            this.Close();
        }

        //private

       

        private void Battle_Load(object sender, EventArgs e)
        {

        }
    }
}
