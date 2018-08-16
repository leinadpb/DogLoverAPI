using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogLoverAPI.Models;

namespace DogLoverAPI.Services
{
    public class DogService : IDogService
    {
        private readonly DogLoverContext _context;

        public DogService(DogLoverContext ctx) //Inject DogLoverDbContext into this Service
        {
            this._context = ctx;
        }

        public Task Add(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task<Dog> Get(int dogId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dog>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dog>> GetByAge(int age)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dog>> GetByBreed(string breed)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dog>> GetByHeight(float height)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dog>> GetByName(string text)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dog>> GetBySex(string sex)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dog>> GetByWeight(float weight)
        {
            throw new NotImplementedException();
        }

        public Task GiveDislike(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task GiveLike(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task Update(Dog dog)
        {
            throw new NotImplementedException();
        }
    }
}
