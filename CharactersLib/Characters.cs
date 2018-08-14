using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersLib
{
    public class Characters
    {
        #region 欄位


        private int nationalId;
        private int hp;
        private int level;
        private int maxHp;
        private int powerUpCandy;
        private int powerUpStardust;
        private static Random random; // a random obj for class

        #endregion 欄位

        #region 屬性

        public string Name { get; set; }

        public int Level
        {
            get => level;
            set
            {
                if (value > 10)
                {
                    this.level = 10;
                }
                else if (value <= 1)
                {
                    this.level = 1;
                }
                else
                {
                    this.level = value;
                }
            }
        }

        public int Hp
        {
            get => hp;
            set
            {
                this.hp = value < 0 ? 0 : value;
            }
        }

        public int MaxHp
        {
            get => maxHp;
            set
            {
                if (value < 0)
                    this.maxHp = 0;
                else if (value > 250)
                    this.maxHp = 250;
                else
                    this.maxHp = value;
            }
        }

        public int PowerUpCandy
        {
            get => powerUpCandy;
            set
            {
                this.powerUpCandy = value < 0 ? 0 : value;
            }
        }

        public int PowerUpStardust
        {
            get => powerUpStardust;
            set => powerUpStardust = value < 0 ? 0 : value;
        }

        public int NationalId
        {
            get => nationalId;
            set => nationalId = value < 0 ? 0 : value;
        }

        #endregion 屬性

        #region 建構式
        //public Characters(int nationalId, string name)  // 設定2個屬性即可建構物件
        public Characters(int nationalId, string name)  // 設定2個屬性即可建構物件
        {
            if (Characters.random == null)
                Characters.random = new Random();
            this.NationalId = nationalId;
            this.Name = name;
            this.Level = random.Next(1, 11);
            this.MaxHp = random.Next(10, 101) + this.Level * 10;
            this.Hp = MaxHp;
            this.PowerUpCandy = 2;
            this.PowerUpStardust = 2500;
        }

        //public Characters(
        public Characters(
            int nationalId,
            string name,
            int level,
            int hp,
            int maxHp,
            int powerUpCandy,
            int powerUpStardust,
            Random random)
            : this(nationalId, name) // 繼承2個屬性的建構式，其餘屬性將重新設定
        {
            this.Hp = hp;
            this.MaxHp = maxHp;
            this.PowerUpCandy = powerUpCandy;
            this.PowerUpStardust = powerUpStardust;
        }
        #endregion 建構式

        public override string ToString()
        {
            return string.Format("寶可夢 名稱:{0}, HP{1}/{2}, 進化需要 {0}糖果:{3}, 星塵:{4}"
                , Name, Hp, MaxHp, PowerUpCandy, PowerUpStardust);
        }

        public static Characters Generate(int nationalId, string name)
        {
            return new Characters(nationalId, name);
        }

        public static Characters[] Generate(int nationalId, string name, int count)
        {
            Characters[] characters = new Characters[count];
            for (int index = 0; index < count; index++)
                characters[index] = Characters.Generate(nationalId, name);

            return characters;
        }

        public static void WriteLine(Characters[] pokemons)
        {
            foreach (Characters pokemon in pokemons)
                Console.WriteLine(pokemon);
        }
    }
}
