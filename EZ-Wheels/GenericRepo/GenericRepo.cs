using Car_Rental_APIs.Models;
using Car_Rental_APIs.UnitOfWorks;

namespace Car_Rental_APIs.GenericRepo
{
    public class GenericRepo<T> where T : class
    {
       protected RentalDbContext _db;

        public GenericRepo(RentalDbContext db)
        {
            _db = db;
        }


        //public IEnumerable<T> getAll()
        //{
        //    return _db.Set<T>().ToList();
        //}

        public IEnumerable<T> getAll(int pageNumber, int pageSize)
        {
          
            var query = _db.Set<T>().ToList();
            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            if (totalPages < pageNumber)
                throw new Exception("page number out of bound");
            else
            {
                query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                return query;
            }
        }
        public IEnumerable<T> getAllWithFilter(int pageNumber, int pageSize, IEnumerable<T> filteredQuery)
        {
            var query = filteredQuery;
            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            if (totalCount == 0 || totalPages < pageNumber)
                return query;
            //if (totalPages < pageNumber)
            //    throw new Exception("page number out of bound");
            else
            {
                query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                return query;
            }
        }
        public T getById(int id)
        {
            return _db.Set<T>().Find(id);
        }
        public T getByStringId(string id)
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

        public async Task Add(PayPal.Api.Payment newPayment)
        {
            var payment = new purchase
            {
                PaymentId = newPayment.id,
                Amount = Convert.ToSingle(newPayment.transactions[0].amount.total),
                Currency = newPayment.transactions[0].amount.currency,
                CreatedDate = DateTime.UtcNow
            };

            _db.Add(payment);
            await _db.SaveChangesAsync();
        }
    }
}