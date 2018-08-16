using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogLoverAPI.Models
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }
        [Required]
        public string OwnerUniqueId { get; set; }

        public int DogId { get; set; }
        public Dog Dog { get; set; }

    }
}
