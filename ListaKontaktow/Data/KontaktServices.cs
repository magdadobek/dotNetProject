using Microsoft.EntityFrameworkCore;

namespace ListaKontaktow.Data
{
    public class KontaktServices
    {
        #region Private members
        private AppDbContext dbContext;
        #endregion
        #region Constructor
        public KontaktServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion
        #region Public methods
        public async Task<List<Kontakt>> GetKontaktAsync()
        {
            return await dbContext.Kontakty.ToListAsync();
        }
        public async Task<Kontakt> AddKontaktAsync(Kontakt kontakt)
        {
            try
            {
                dbContext.Kontakty.Add(kontakt);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return kontakt;
        }
        public async Task<Kontakt> UpdateKontaktAsync(Kontakt kontakt)
        {
            try
            {
                var kontaktExist = dbContext.Kontakty.FirstOrDefault(p => p.Id == kontakt.Id);
                if (kontaktExist != null)
                {
                    dbContext.Update(kontakt);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return kontakt;
        }
        public async Task DeleteKontaktAsync(Kontakt kontakt)
        {
            try
            {
                dbContext.Kontakty.Remove(kontakt);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
