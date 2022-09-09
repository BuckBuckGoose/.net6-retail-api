namespace RentalApi
{
    public class InventoryObject
    {
        public InventoryObject(Guid guid, string name)
        {
            ID = guid;
            Name = name;

        }

        public Guid ID { get; private set; }
        public string Name { get; set; }

        public static InventoryObject Create(string name)
        {
            return new InventoryObject(Guid.NewGuid(), name);
        }


    }
}
