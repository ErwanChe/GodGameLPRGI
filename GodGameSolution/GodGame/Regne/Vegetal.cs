using System;
namespace GodGame.Regne
{
    public class Vegetal 
    {

        private byte populationNumber;
        private String name;

        public string Name { get => name; set => name = value; }

        public Vegetal(String p_name)
        {
            this.Name = p_name; 
        }

        enum EspeceVegetal
        {
            Arbre,
            Fleur,
            Buisson, 
        }

        public void TosTring()
        {
            Console.WriteLine("Je m'appelle {0} , je suis de race {1} , et de Regne  {3} ");
        }
    }
}
