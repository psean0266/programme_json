using Newtonsoft.Json;
using System;

namespace programme_json
{

    class Personne
    {
       public string nom { get; init; }
       public  int age { get; init; }
       public  bool majeur { get; init; }

        //public Personne(string nom, int age, bool majeur) 
        //{
        //    this.nom = nom;
        //    this.age = age;
        //    this.majeur = majeur;
        //}

        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - age: " + age + " ans");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne() { nom = "Toto", age = 20, majeur = true };

            /*
            var personne1 = new Personne();
            personne1.nom = "Toto";
            personne1.age = 20;
            personne1.majeur = true;   
            */
            personne1.Afficher();


            string json =  JsonConvert.SerializeObject(personne1);
            Console.WriteLine(json);

            

            string JsonTiti =  "{ \"nom\":\"Titi\",\"age\":15,\"majeur\":false}";
            Personne titi =  JsonConvert.DeserializeObject<Personne>(JsonTiti);
            titi.Afficher();    

        }
    }
}
