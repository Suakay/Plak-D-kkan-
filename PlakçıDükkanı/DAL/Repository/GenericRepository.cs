using Microsoft.EntityFrameworkCore;
using PlakçıDükkanı.DAL.Context;

namespace PlakçıDükkanı.DAL.Repository
{
    public class GenericRepository<TEntity> where TEntity : class 
    {

        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<TEntity> GetAll()
        {
          return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            try
            {
                return _context.Set<TEntity>().Find(id);

            }
            catch (Exception ex)
            {
                throw new Exception("İşlem başarısız");
            }


           

        }

        public TEntity Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);

                Console.WriteLine(" Ekleme İşlem Başarılı");
                 _context.SaveChanges();
                
                return entity;  

            }
            catch (Exception ex)
            {
                throw new Exception("Ekleme işlemi başarısız");
            }
        }
        public TEntity Update(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);
                Console.WriteLine("Güncelleme Başarılı");
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception("İşlem başarısız");
            }


        }
        public int Delete(int id)
        {
            try
            {
                TEntity entity = GetById(id);
                _context.Set<TEntity>().Remove(entity);

                Console.WriteLine("Silme işlemi başarılı");
                return _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Silme işlemi başarısız");
            }
        }
    }
   
}