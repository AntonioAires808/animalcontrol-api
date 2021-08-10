using System.Collections.Generic;

namespace animalcontrol_webapi.Models
{
    public class Animal
    {
        public Animal()
        {
            
        }

        public Animal(int id, string name, string nickname, int chipNumber, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Nickname = nickname;
            this.ChipNumber = chipNumber;
            this.Age = age; 
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int ChipNumber { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public IEnumerable<AnimalLearning> AnimalLearnings { get; set; }        
    }
}