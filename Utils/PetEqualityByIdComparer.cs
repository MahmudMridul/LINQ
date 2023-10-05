using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LINQ.Utils
{
    internal class PetEqualityByIdComparer : IEqualityComparer<Pet>
    {
        public bool Equals(Pet x, Pet y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Pet pet)
        {
            return pet.Id;
        }
    }
}