using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutorialMvc.Models;

namespace TutorialMvc.Data
{
    public class TutorialMvcContext : DbContext
    {
        public TutorialMvcContext (DbContextOptions<TutorialMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
