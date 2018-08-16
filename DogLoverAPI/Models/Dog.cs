using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogLoverAPI.Models
{
    public class Dog
    {
        [Key]
        public int DogId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public float Weight { get; set; }

        public float Height { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        public string OwnerUniqueId { get; set; }

        [Required]
        public string MainPicture { get; set; }

        public List<Like> Likes { get; set; }
        public List<Dislike> Dislikes { get; set; }
        public List<DogPicture> DogPictures { get; set; }

    }
}
