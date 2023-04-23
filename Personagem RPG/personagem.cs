using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Personagem_RPG
{
    public class Personagem
    {
        public string name;
        public string classe;
        public int hp;
        public int strength;
        public int defense;

       

        public void Attacked() 
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            
           do 
            {
                this.hp = hp + defense - diceRoll;
            } while (diceRoll > this.hp + defense);


            if (diceRoll <= defense)
            {
                Console.WriteLine("O inimigo tirou " + diceRoll + " no dado. Ele errou!");
                Console.ReadLine();
            }
            else Console.WriteLine("O inimigo tirou " + diceRoll + ". O ataque acertou, sua vida restante é: " + this.hp);

        }

        
    }
}
