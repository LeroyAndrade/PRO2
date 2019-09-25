using System;
using System.Collections;

namespace PopulationControl
{
    class Program
    {
        static void Main(string[] args)
        {
           //Maak een ArrayList aan om personen in op te slaan
            ArrayList people = new ArrayList();
            //Maak een nieuwe persoon aan
            Person newPerson = new Person();
            //Vraag om de naam van de persoon
            Console.WriteLine("goedemorgen wat is je naam?");
            string name = Console.ReadLine();
            //Roep de setter aan. In de setter vind de controle plaats of het een valide naam is.
            newPerson.SetName(name); 
                        
            //Controleer of de naam succesvol is opgeslagen
            if(newPerson.GetName() != null){
                Console.WriteLine("good morning "+ newPerson.GetName());
                people.Add(newPerson);//Voeg de nieuwe persoon toe aan de lijst
            }            

            //Controle of de persoon is toegevoegd
            Console.WriteLine("the are "+people.Count+" in the list");
            

        }
    }
}
