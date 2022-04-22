namespace RentalApi
{
    public class RentalObject
    {
        public RentalObject(string name)
        {
            ID = new Guid();
            Name = name;

        }

        public Guid ID { get; set; }
        public string Name { get; set; }


    }
}
