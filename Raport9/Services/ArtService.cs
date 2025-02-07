using Microsoft.EntityFrameworkCore;
using Raport9.Data;
using Raport9.Models;

namespace Raport9.Services
{
    public class ArtService
    {
        private readonly IDbContextFactory<raportyDbContext> _idbcontextFactory;

        public ArtService(IDbContextFactory<raportyDbContext> dbContextFactory)
        {
            _idbcontextFactory = dbContextFactory;
        }

        public async Task<List<Artykul>> GetArtykulyAsync()
        {
            using (var context = _idbcontextFactory.CreateDbContext())
            {
                return await context.art.ToListAsync();
            }
        }

        public void AddArt(Artykul art)
        {
            using (var context = _idbcontextFactory.CreateDbContext())
            {
                context.art.Add(art);
                context.SaveChanges(); // Zapisywanie zmian do bazy
            }
        }

        public void AddPrezentacja(Prezentacja prezentacja, ref string wiadomosc)
        {
            wiadomosc = "zaczynam";
            try
            {
                using (var context = _idbcontextFactory.CreateDbContext())
                {
                    context.Prezentacjas.Add(prezentacja);
                    context.SaveChanges(); // Zapisywanie zmian do bazy
                    wiadomosc = "udalo sie";
                }
            }
            catch (Exception ex)
            {
                wiadomosc = ex.Message;
            }
        }
    }
}
