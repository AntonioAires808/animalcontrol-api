namespace animalcontrol_webapi.Models
{
    public class AnimalLearning
    {
        public AnimalLearning()
        {

        }
        public AnimalLearning(int AnimalId, int learningTopicId)
        {
            this.AnimalId = AnimalId;
            this.LearningTopicId = learningTopicId;
        }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int LearningTopicId { get; set; }
        public LearningTopic LearningTopic { get; set; }
    }
}