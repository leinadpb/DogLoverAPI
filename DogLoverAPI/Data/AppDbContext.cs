using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogLoverAPI.Models;

namespace DogLoverAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Dislike> Dislikes { get; set; }
        public DbSet<DogPicture> DogsPictures { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}
