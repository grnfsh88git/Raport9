using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Raport9.Data;
using Raport9.Models;

namespace Raport9.Services
{
    public class ArtService
    {
       
        private IDbContextFactory<raportyDbContext> _idbcontextFactory;
        public ArtService(IDbContextFactory<raportyDbContext> dbCotextFactory)
        {
            _idbcontextFactory = dbCotextFactory;
        }

        public void AddArt(Artykul art)
        {
            using (var context = _idbcontextFactory.CreateDbContext())
            {
                context.Arts.Add(art);
            }
        }
        public void Addprezentacja(Prezentacja prezentacja, string wiadomosc)
        {
            wiadomosc = "zaczynam";
            try
            {
                using (var context = _idbcontextFactory.CreateDbContext())
                {
                    context.Prezentacjas.Add(prezentacja);
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
