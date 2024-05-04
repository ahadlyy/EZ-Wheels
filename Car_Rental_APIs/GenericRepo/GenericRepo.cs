using Car_Rental_APIs.Models;

namespace Car_Rental_APIs.GenericRepo
{
    public class GenericRepo<T> where T : class
    {
        RentalDbContext _db;

        public GenericRepo(RentalDbContext db)
        {
            _db = db;
        }


        public IEnumerable<T> getAll()
        {
            return _db.Set<T>().ToList();
        }

        public IEnumerable<T> getAllQuery(int pageNumber, int pageSize)
        {
            var cars = getAll();
            var totalCount = cars.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            if (totalPages < pageNumber)
                throw new Exception("page number out of bound");
            else
            {
                cars = cars.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                return cars;
            }
        }
        public T getById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Add(T item)
        {
            _db.Set<T>().Add(item);
        }

        public void update(T item)
        {
            _db.Set<T>().Update(item);
        }

        public void delete(T item)
        {
            _db.Set<T>().Remove(item);
        }

        public void save()
        {
            _db.SaveChanges();
        }
    }
}