using Microsoft.EntityFrameworkCore;

namespace ListaKontaktow.Data
{
    public class KategoriaServices
    {
        #region Private members
        private AppDbContext dbContext;
        #endregion
        #region Constructor
        public KategoriaServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion
        #region Public methods
        public async Task<List<Kategoria>> GetKategoriaAsync()
        {
            return await dbContext.Kategorie.ToListAsync();
        }
        #endregion
    }
}
