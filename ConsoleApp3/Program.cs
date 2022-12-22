using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static char saisie(string message, char rep1, char rep2)
        {
            //declaration
            char reponse;

            Console.Write(message + "(" + rep1 + "/" + rep2 + ")");
            reponse = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return reponse;
        }
        

        static void Main(string[] args)
        {
            //declaration
            char rep;
            int NbrBonbons = 0;


            //demande si il a mangé des bonbons
            rep = saisie("Avez vous mangé des bonbons ? ", 'O', 'N');

            while(rep == 'O')
            {
                Console.WriteLine();
                Console.Write("Entrez le nombre de bonbons = ");
                NbrBonbons = int.Parse(Console.ReadLine());

                if (NbrBonbons < 20)
                {
                    Console.WriteLine("Pas de risque carries");
                }
                else
                {
                    Console.WriteLine("Risque de carries");
                }

                //demande si une autre personne veut verifier le risque 
                rep = saisie("Une autre personne veut elle verifier ", 'O', 'N');
                


            }
            Console.ReadLine();

        }
    }
}
