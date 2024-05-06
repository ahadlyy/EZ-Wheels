using Microsoft.EntityFrameworkCore;
using Car_Rental_APIs.Models;
using Car_Rental_APIs.UnitOfWorks;

namespace CarRentalWebAPI.Services
{
    public class NotificationScheduler : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly IServiceProvider _serviceProvider;

        public NotificationScheduler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromDays(1)); // Run every day
            return Task.CompletedTask;
        }

        private async void DoWork(object state)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var unitOfWork = scope.ServiceProvider.GetRequiredService<UnitOfWork>();

                var approachingRentals = await unitOfWork.CustomerRentCarRepo.getAll().AsQueryable()
                    .Include(r => r.Customer.Id) // Assuming user information is needed for notifications
                    .Where(r => r.EndingDate == DateTime.Today.AddDays(1)) // Rental deadline is tomorrow
                    .ToListAsync();

                foreach (var rental in approachingRentals)
                {
                    var notification = new Notification
                    {
                        CustomerId = rental.Customer.Id,
                        Message = $"Your rental for car {rental.CustomerCar.PlateNumber} is due tomorrow. Please return the car promptly.",
                        IsRead = false,
                        SentAt = DateTime.Today
                    };

                    unitOfWork.NotificationRepo.Add(notification);
                }

                unitOfWork.saveChanges();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
