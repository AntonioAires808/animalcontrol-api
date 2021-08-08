namespace animalcontrol_webapi.Models
{
    public class AnimalLearning
    {
        public AnimalLearning()
        {

        }
        public AnimalLearning(int animalId, int learningTopicId)
        {          
            this.AnimalId = animalId;
            this.LearningTopicId = learningTopicId;          
        }

        public Animal Animal { get; set; }
        public int AnimalId { get; set; }
        public int LearningTopicId { get; set; }
        public LearningTopic LearningTopic { get; set; }
    }
}