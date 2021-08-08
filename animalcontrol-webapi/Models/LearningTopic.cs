namespace animalcontrol_webapi.Models
{
    public class LearningTopic
    {
        public LearningTopic()
        {
            
        }

        public LearningTopic(int id, string topicName, string description, int ownerId)
        {
            this.Id = id;
            this.TopicName = topicName;
            this.Description = description;
            this.OwnerId = ownerId;
        }

        public int Id { get; set; }
        public string TopicName { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}