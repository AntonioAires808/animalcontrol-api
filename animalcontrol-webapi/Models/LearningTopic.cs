using System.Collections.Generic;

namespace animalcontrol_webapi.Models
{
    public class LearningTopic
    {
        public LearningTopic()
        {
            
        }
        public LearningTopic(int id, string name, int OwnerId)
        {
            this.Id = id;
            this.Name = name;
            this.OwnerId = OwnerId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public IEnumerable<AnimalLearning> AnimalLearnings { get; set; }      
    }
}