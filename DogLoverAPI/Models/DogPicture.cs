using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogLoverAPI.Models
{
    public class DogPicture
    {
        [Key]
        public int DogPictureId { get; set; }
        [Required]
        public string PictureUrl { get; set; }

        public int DogId { get; set; }
        public Dog Dog { get; set; }


    }
}
