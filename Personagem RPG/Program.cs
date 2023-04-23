using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personagem_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Personagem guerreiro = new Personagem();
            Console.WriteLine("Qual o nome do seu personagem?");
            guerreiro.name = Console.ReadLine();

            guerreiro.hp = 10;
            guerreiro.defense = 2;
            guerreiro.strength = 2;


            Console.WriteLine("Nome: " + guerreiro.name);
            Console.WriteLine("Hp: " + guerreiro.hp);
            Console.WriteLine("Força de ataque: " + guerreiro.strength);
            Console.WriteLine("Defesa: " + guerreiro.defense);
            Console.ReadLine();

            Console.WriteLine("Um inimigo atacou!");
            guerreiro.Attacked();
          
            Console.ReadLine() ;

        }
    }
}
