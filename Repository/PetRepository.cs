using PetShop.Models;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Repository
{
    public class PetRepository : IPet
    {
        private DB_Context db;
        public PetRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Pet> GetPets => db.Pets;

        public void Add(Pet _Pet)
        {
            db.Pets.Add(_Pet);
            db.SaveChanges();
        }

        public Pet GetPet(int? Id)
        {
            Pet dbEntity=db.Pets.Find(Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Pet dbEntity=db.Pets.Find(Id);
            db.Pets.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
