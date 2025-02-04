using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Raport9.Components.Pages.slowniki;
using Raport9.Models;
namespace Raport9.Data
{
    public class raportyDbContext : DbContext
    {
        public raportyDbContext(DbContextOptions<raportyDbContext> options)
        : base(options)
        {

        }
        public DbSet<Artykul> Arts { get; set; }
        public DbSet<Prezentacja> Prezentacjas { get; set; }

    }
}



