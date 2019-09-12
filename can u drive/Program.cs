using System;

namespace can_u_drive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe oud ben jij?");
            string input = Console.ReadLine();
            int age = Int32.Parse(input);
            if(age < 18){
                 Console.WriteLine("je mag niet rijden omdat je geen 18 bent!");
            }else{
                Console.WriteLine("Heb jij al een Rijbewijs?");
                input = Console.ReadLine();
                if(input == "ja" || input == "j"){

                    Console.WriteLine("Lekker dan!");
                }                
                
            }

               

        }
    }
}
