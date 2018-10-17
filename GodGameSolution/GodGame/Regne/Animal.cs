using System;
namespace GodGame.Regne
{
    public class Animal
    {
        private int populationNumber;  
        private String name;
        private String sexe;

        public string Name { get => name; set => name = value; }
        public int PopulationNumber { get => populationNumber; set => populationNumber = value; }
        public string Sexe { get => sexe; set => sexe = value; }

        //liste des premiers animaux:

        List<Animal> AnimalList = new List<Animal>(); 

        AnimalList.Add(""); 


        public Animal(String p_name )
        {
            this.Name = p_name;
            this.PopulationNumber = PopulationNumber + 1;
            //this.Sexe = SexeEnum.Femelle; 
        }
           
          
        public string Sexe { get => sexe; set => sexe = value; }
        public string Name { get => name; set => name = value; }
        public int PopulationNumber { get => populationNumber; set => populationNumber = value; }

        public Animal(String p_name, String p_sexe)
        {
            this.Name = p_name;
            this.Sexe = p_sexe;
            this.PopulationNumber = PopulationNumber + 1;

        }

        enum EspeceAnimal
        {
            Chien,
            Chat,
            Humain,
            Dauphin,
        }

        enum SexeEnum
        {
            Femelle,
            Mâle , 
        }

        public void TosTring()
        {
            Console.WriteLine("Je m'appelle {0} , je suis de race {1} , de sexe {2} et du regne {4}");
        }
    }
}
