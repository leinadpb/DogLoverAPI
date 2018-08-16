using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DogLoverAPI.Models
{
    public class DogLoverContext : DbContext
    {
        public DogLoverContext(DbContextOptions<DogLoverContext> options) : base(options)
        { }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Dislike> Dislikes { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogPicture> DogPictures { get; set; }

    }
}
