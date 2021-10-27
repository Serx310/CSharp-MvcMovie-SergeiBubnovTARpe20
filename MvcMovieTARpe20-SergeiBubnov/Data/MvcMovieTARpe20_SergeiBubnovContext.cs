using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieTARpe20_SergeiBubnov.Models;

namespace MvcMovieTARpe20_SergeiBubnov.Data
{
    public class MvcMovieTARpe20_SergeiBubnovContext : DbContext
    {
        public MvcMovieTARpe20_SergeiBubnovContext (DbContextOptions<MvcMovieTARpe20_SergeiBubnovContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieTARpe20_SergeiBubnov.Models.Movie> Movie { get; set; }

        public DbSet<MvcMovieTARpe20_SergeiBubnov.Models.Actor> Actor { get; set; }
    }
}
