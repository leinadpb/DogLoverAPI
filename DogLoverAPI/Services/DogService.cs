using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogLoverAPI.Models;
using DogLoverAPI.Data;
namespace DogLoverAPI.Services
{
    public class DogService : IDogService
    {
        private readonly AppDbContext _context;

        public DogService(AppDbContext ctx) //Inject DbContext into this Service
        {
            this._context = ctx;
        }

        public Task<Dog> Add(Dog dog)
        {
            return Task.Run(() => {
                try
                {
                    _context.Dogs.Add(dog);
                    _context.SaveChanges();
                    return dog;
                }catch(Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                }
                return null;
            });
        }

        public Task Delete(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task<Dog> Get(int dogId)
        {
            return Task.Run(() => {
                try
                {
                    var dog = _context.Dogs.Where(d => d.DogId == dogId).First();
                    if(dog != null)
                        return dog;

                }catch(Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                }
                return null;
            });
        }

        public Task<IEnumerable<Dog>> GetAll()
        {
            return Task.Run(() => {

                try
                {
                    var dogs = _context.Dogs.AsEnumerable();
                    return dogs;
                }catch(Exception exp)
                {
                    Console.WriteLine($"Error on getting dogs: {exp}");
                }

                return null;
            });
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
