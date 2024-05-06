using Car_Rental_APIs.GenericRepo;
using Car_Rental_APIs.Models;

namespace Car_Rental_APIs.UnitOfWorks
{
    public class UnitOfWork
    {
        RentalDbContext _db;
        GenericRepo<Car> carRepo;
        GenericRepo<CustomerRentCar> customerRentCarRepo;
        GenericRepo<Notification> notificationRepo;

        public UnitOfWork(RentalDbContext db)
        {
            _db = db;
        }

        public GenericRepo<Car> CarRepo
        {
            get
            {
                if (carRepo == null)
                {
                    carRepo = new GenericRepo<Car> (_db);
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

        public GenericRepo<Notification> NotificationRepo
        {
            get
            {
                if (notificationRepo == null)
                {
                    notificationRepo = new GenericRepo<Notification>(_db);
                }
                return notificationRepo;
            }
        }

        public void saveChanges()
        {
            _db.SaveChanges();
        }
    }
}
