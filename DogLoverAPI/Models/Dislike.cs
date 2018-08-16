using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogLoverAPI.Models
{
    public class Dislike
    {
        [Key]
        public int DislikeId { get; set; }
        public string OwnerUniqueId { get; set; }

        public int DogId { get; set; }
        public Dog Dog { get; set; }
    }
}
