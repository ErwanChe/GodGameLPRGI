using System;
namespace GodGame.Regne
{
    public class Bacterie
    {

        private byte populationNumber;
        private String name;

        public string Name { get => name; set => name = value; }

        public Bacterie(String p_name)
        {
            this.Name = p_name; 

        }

        enum EspeceBacterie
        {
            Champignon,
            Archee,
            Protiste,
        }

        public void TosTring()
        {
            Console.WriteLine("Je m'appelle {0} , je suis de race {1} et de regne {3}");
        }
    }
}
