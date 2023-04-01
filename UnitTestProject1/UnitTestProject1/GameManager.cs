using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class GameManager
    {
        public static GameManager Instance { get; private set; } = new GameManager();

        public void CombatSimulator1turnEach(Player p1, Player p2)
        {
            int x = 0;
            Player playerAtk = p1;
            Player playerDef = p2;
            Player temp; 

            while (x<2)
            {
                playerDef.TakeDamage(playerAtk.DealDamage());
                
                temp = playerAtk;
                playerAtk =playerDef;
                playerDef= temp;
                x++;


            }
        }
    }
}
