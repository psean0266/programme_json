using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace programme_json
{
    // deserializer soit par champs ou par constructeur
    class Personne
    {
       public string nom { get; private set; }
       public  int age { get; private set; }
       public  bool majeur { get; private set; }

        public Personne(string nom, int age, bool majeur)
        {
            this.nom = nom;
            this.age = age;
            this.majeur = majeur;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - age: " + age + " ans");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  var personne1 = new Personne() { nom = "Toto", age = 20, majeur = true };

            //   var personne1 = new Personne("Toto", 20, true);

            /*
            var personne1 = new Personne();
            personne1.nom = "Toto";
            personne1.age = 20;
            personne1.majeur = true;   
            */
            //personne1.Afficher();


            //string json =  JsonConvert.SerializeObject(personne1);
            //Console.WriteLine(json);

            //List<string> noms = new List<string>() { "Jean", "Paul", "Claire" };
            //string JsonList = JsonConvert.SerializeObject(noms);    

            //Console.WriteLine(JsonList);

            //string JsonTiti =  "{ \"nom\":\"Titi\",\"age\":15,\"majeur\":false}";
            //Personne titi =  JsonConvert.DeserializeObject<Personne>(JsonTiti);
            //titi.Afficher();    

            var path = "out";

            var personnes = new List<Personne>()
            {
                new Personne("paul",15,false),
                new Personne("Jean",23,true),
                new Personne("Karim",17,false),
                new Personne("Marine",26,true),
                new Personne("Joseph",26,true),
            };

            string json =  JsonConvert.SerializeObject(personnes);
            Console.WriteLine(json);

            if(!Directory.Exists(path)) { 

              Directory.CreateDirectory(path);
            }

            string fileName = "JsonFileSerialize";
            string pathEAndFile = Path.Combine(path, fileName);

            File.WriteAllText(pathEAndFile, json);

            var lire = File.ReadAllText(pathEAndFile);

            List<Personne> PersonneDeserialize =  JsonConvert.DeserializeObject<List<Personne>>(lire);  

            foreach( Personne personne in PersonneDeserialize)
            {
                personne.Afficher();
            }




        }
    }
}
