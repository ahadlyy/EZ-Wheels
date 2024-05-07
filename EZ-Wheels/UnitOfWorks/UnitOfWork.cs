using Car_Rental_APIs.GenericRepo;
using Car_Rental_APIs.Models;

namespace Car_Rental_APIs.UnitOfWorks
{
    public class UnitOfWork
    {
        public RentalDbContext _db;
        //GenericRepo<Car> carRepo;
        GenericRepo<CustomerRentCar> customerRentCarRepo;
        CarRepo carRepo;

        public UnitOfWork(RentalDbContext db)
        {
            _db = db;
        }

        //public GenericRepo<Car> CarRepo
        //{
        //    get
        //    {
        //        if (carRepo == null)
        //        {
        //            carRepo = new GenericRepo<Car>(_db);
        //        }
        //        return carRepo;
        //    }

        //}

        public CarRepo CarRepo
        {
            get
            {
                if (carRepo == null)
                {
                    carRepo = new CarRepo(_db);
                }
                return carRepo;
            }

        }

        public GenericRepo<CustomerRentCar> CustomerRentCarRepo
        {
            get
            {
                if (customerRentCarRepo == null)
                {
                    customerRentCarRepo = new GenericRepo<CustomerRentCar>(_db);
                }
                return customerRentCarRepo;
            }

        }

        public void saveChanges()
        {
            _db.SaveChanges();
        }

    }
}
