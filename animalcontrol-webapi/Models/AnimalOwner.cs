namespace animalcontrol_webapi.Models
{
    public class AnimalOwner
    {
        public AnimalOwner()
        {

        }
        public AnimalOwner(int animalId, int ownerId)
        {
            this.AnimalId = animalId;
            this.OwnerId = ownerId;
        }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}