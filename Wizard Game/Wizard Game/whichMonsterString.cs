using System;

namespace WizardGame
{
    public class whichMonsterString
    {
        public void whichMonsterStringFind(int whichMonster)
        {
            switch (whichMonster)
            {
                case 1:
                    monsterType = "Goblin";
                    break;
                case 2:
                    monsterType = "Big Angry Bird";
                    break;
                case 3:
                    monsterType = "Sea Serpent";
                    break;
                case 4:
                    monsterType = "Dragon";
                    break;
            }
        }
    }
}