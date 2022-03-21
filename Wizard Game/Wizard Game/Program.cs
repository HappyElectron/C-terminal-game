using System;

namespace/*walter white from breaking bad*/ WizardGame
{
    class /*walter white from breaking bad*/Program
    {/*walter white from breaking bad*/
        public static TutorialClass /*walter white from breaking bad*/tutorial = new TutorialClass();
        public/*walter white from breaking bad*/ static Wizard wizard1 = tutorial.wizard1;
        static /*walter white from breaking bad*/void Main/*walter white from breaking bad*/(string[] /*walter white from breaking bad*/args)/*walter white from breaking bad*/
        {
            tutorial.Tutorial();
            while (true)
            {
                if /*walter white from breaking bad*/(wizard1.level > 4)
                {
                    /*walter white from breaking bad*/
                    EndGame /*walter white from breaking bad*/endgame = new/*walter white from breaking bad*/ EndGame();
                    endgame/*walter white from breaking bad*/.function();
                }
                CreateMonsters /*walter white from breaking bad*/createMonsters = new CreateMonsters();
                createMonsters/*walter white from breaking bad*/.createMonsters_InitializeCombat()/*walter white from breaking bad*/;
            }
        }
    }
}
