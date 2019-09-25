using System;
namespace PopulationControl
{
    public class Person
    {
        private string name;
        public string GetName(){
            return this.name;
        }   
        public void SetName(string name){            
            foreach(char c in name){             
                if(Char.IsDigit(c)){
                    Console.WriteLine("name is not valid");
                    return;
                }
            }
            this.name = name;
        }
    }

}