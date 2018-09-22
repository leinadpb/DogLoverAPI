using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogLoverAPI.Services;
using DogLoverAPI.Models;

namespace DogLoverAPI.Services
{
    public interface IDogService
    {
        /**
         * Summary: 
         *      Get a unique dog by id.
         * 
         * Returns: 
         *      A dog object.
         * Creator:
         *      Not specified yet.
         * */
        Task<Dog> Get(int dogId);
        /**
         * Summary:
         *      Add a new dog to the app.
         * Returns:
         *      Task status completation.
         * Creator:
         *      Not specified yet.
         * */
        Task<Dog> Add(Dog dog);
        /**
         * Summary:
         *      Delete an existing dog.
         * Returns:
         *      Task status completation.
         * Creator:
         *      Not specified yet.
         * */
        Task Delete(Dog dog);
        /**
         * Summary:
         *      Update an existing dog.
         * Returns:
         *      Task status completation.
         * Creator:
         *      Not specified yet.
         * */
        Task Update(Dog dog);
        /**
         * Summary: Give a like to a dog.
         * Returns: Task status completation.
         * Creator: -
         * */
        Task GiveLike(Dog dog);
        /**
         * Summary: Give a dislike to a dog.
         * Returns: Task status completation.
         * Creator: -
         * */
        Task GiveDislike(Dog dog);
        /**
          * Summary: Get all dogs stored in app.
          * Returns: IEnumerable of dogs
          * Creator: -
          * */
        Task<IEnumerable<Dog>> GetAll();
        /**
         * Summary: Get a dog by it's name
         * Returns: IEnumarable of dogs.
         * Creator: -
         * */
        Task<IEnumerable<Dog>> GetByName(string text);
        /**
         * Summary: Get a dog by it's sex
         * Returns: IEnumarable of dogs.
         * Creator: -
         * */
        Task<IEnumerable<Dog>> GetBySex(string sex);
        /**
         * Summary: Get a dog by it's age
         * Returns: IEnumarable of dogs..
         * Creator: -
         * */
        Task<IEnumerable<Dog>> GetByAge(int age);
        /**
         * Summary: Get a dog by it's weight
         * Returns: IEnumarable of dogs.
         * Creator: -
         * */
        Task<IEnumerable<Dog>> GetByWeight(float weight);
        /**
         * Summary: Get a dog by it's height
         * Returns: IEnumarable of dogs.
         * Creator: -
         * */
        Task<IEnumerable<Dog>> GetByHeight(float height);
        /**
         * Summary: Get a dog by it's breed
         * Returns: IEnumarable of dogs.
         * Creator: -
         * */
        Task<IEnumerable<Dog>> GetByBreed(string breed);
    }
}
