using System.Collections.Generic;

namespace LINQ.Utils
{
    public class PetOwner
    {
        public int Id { get; }
        public string Name { get; }
        public IEnumerable<Pet> Pets;

        public PetOwner(int id, string name, IEnumerable<Pet> pets)
        {
            Id = id;
            Name = name;
            Pets = pets;
        }
    }
}
