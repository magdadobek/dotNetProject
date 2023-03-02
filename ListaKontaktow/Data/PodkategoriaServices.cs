using Microsoft.EntityFrameworkCore;

namespace ListaKontaktow.Data
{
    public class PodkategoriaServices
    {
        #region Private members
        private AppDbContext dbContext;
        #endregion
        #region Constructor
        public PodkategoriaServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion
        #region Public methods
        public async Task<List<Podkategoria>> GetPodkategoriaAsync()
        {
            return await dbContext.Podkategorie.ToListAsync();
        }
        public async Task<Podkategoria> AddPodkategoriaAsync(Podkategoria podkategoria)
        {
            try
            {
                dbContext.Podkategorie.Add(podkategoria);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return podkategoria;
        }
        public async Task<Podkategoria> UpdatePodkategoriaAsync(Podkategoria podkategoria)
        {
            try
            {
                var podkategoriaExist = dbContext.Podkategorie.FirstOrDefault(p => p.Id == podkategoria.Id);
                if (podkategoriaExist != null)
                {
                    dbContext.Update(podkategoria);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return podkategoria;
        }
        public async Task DeletePodkategoriaAsync(Podkategoria podkategoria)
        {
            try
            {
                dbContext.Podkategorie.Remove(podkategoria);
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
