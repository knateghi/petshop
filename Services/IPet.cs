using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
   public interface IPet
    {
        IEnumerable<Pet> GetPets { get; }
        Pet GetPet(int? Id);
        void Add(Pet _Pet);
        void Remove(int? Id);
    }
}
