using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard_Game
{
    public class Monster
    {
        public int LowestXp { get; set; }
        public int HighestXp { get; set; }   
        public int LowestDamage { get; set; }
        public int HighestDamage { get; set; }
        public string MonsterName { get; set; }
        public int MonsterType { get; set; }
        public int damageTaken;
        public Monster(int lowestXp, int highestXp, int lowestDamage, int highestDamage, string monsterName, int monsterType)
        {
            LowestXp = lowestXp;
            HighestXp = highestXp;
            LowestDamage = lowestDamage;
            HighestDamage = highestDamage;
            MonsterName = monsterName;
            MonsterType = monsterType;
        }
        public void Attack()
        {
            Random rand = new Random();
            damageTaken = rand.Next(LowestDamage, HighestDamage);
        }
        public void TakeDamage()
        {

        }
    }
}