using Core.Contracts;

namespace Core.Entities
{
    public class Product : EntityBase, IMustHaveTenant
    {
        private Product() : base() { }

        public Product(string name, string description, int rate)
        {
            Name = name;
            Description = description;
            Rate = rate;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Rate { get; private set; }
        public string TenantId { get; set; }
    }
}
