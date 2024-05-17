using PayPal.Api;
using Car_Rental_APIs.UnitOfWorks;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Car_Rental_APIs.GenericRepo;

namespace Car_Rental_APIs.Services
{
    public class PaypalService : PaypalRepo
    {
        private readonly APIContext _apiContext;
        private readonly UnitOfWork _unitOfWork;

        public PaypalService(APIContext apiContext, UnitOfWork unitOfWork)
        {
            _apiContext = apiContext;
            _unitOfWork = unitOfWork;
        }

        public async Task<Payment> CreatePaymentAsync(decimal amount, string currency)
        {
            var payment = new Payment
            {
                intent = "sale",
                payer = new Payer { payment_method = "paypal" },
                transactions = new List<Transaction>
                {
                    new Transaction
                    {
                        amount = new Amount
                        {
                            total = amount.ToString("F2", CultureInfo.InvariantCulture),
                            currency = currency
                        },
                        description = "Transaction description"
                    }
                },
                redirect_urls = new RedirectUrls
                {
                    return_url = "http://your-url.com/return", // Replace with your actual return URL
                    cancel_url = "http://your-url.com/cancel" // Replace with your actual cancel URL
                }
            };

            var createdPayment = await Task.Run(() => payment.Create(_apiContext));
            // If you need to save any information to the database, do so here
            // await _unitOfWork.SomeRepo.InsertAsync(someEntity);
            await _unitOfWork.SaveChangesAsync();

            return createdPayment;
        }

        public async Task<Payment> ExecutePaymentAsync(string paymentId, string payerId)
        {
            var paymentExecution = new PaymentExecution { payer_id = payerId };
            var payment = new Payment { id = paymentId };
            var executedPayment = await Task.Run(() => payment.Execute(_apiContext, paymentExecution));
            // If you need to update any information in the database, do so here
            // await _unitOfWork.SomeRepo.UpdateAsync(someEntity);
            await _unitOfWork.SaveChangesAsync();

            return executedPayment;
        }
    }
}

