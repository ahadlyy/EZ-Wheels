using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Car_Rental_APIs.GenericRepo;
using Car_Rental_APIs.UnitOfWorks;

namespace Car_Rental_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly PaypalRepo _payPalRepo;
        private readonly UnitOfWork _unitOfWork;

        public PaymentController(PaypalRepo payPalRepo, UnitOfWork unitOfWork)
        {
            _payPalRepo = payPalRepo;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Creates a PayPal payment.
        /// </summary>
        /// <param name="request">The payment creation request containing amount and currency.</param>
        /// <returns>The payment ID and approval URL.</returns>
        [HttpPost("create-payment")]
        public async Task<IActionResult> CreatePayment([FromBody] CreatePaymentRequest request)
        {
            var payment = await _payPalRepo.CreatePaymentAsync(request.Amount, request.Currency);
            var approvalUrl = payment.links.FirstOrDefault(x => x.rel.Equals("approval_url", StringComparison.OrdinalIgnoreCase))?.href;
            return Ok(new { id = payment.id, approvalUrl });
        }


        /// <summary>
        /// Executes a PayPal payment.
        /// </summary>
        /// <param name="request">The payment execution request containing payment ID and payer ID.</param>
        /// <returns>The executed payment details.</returns>
        [HttpPost("execute-payment")]
        public async Task<IActionResult> ExecutePayment([FromBody] ExecutePaymentRequest request)
        {
            var executedPayment = await _payPalRepo.ExecutePaymentAsync(request.PaymentId, request.PayerId);
            return Ok(executedPayment);
        }
    }

    public class CreatePaymentRequest
    {
        public float Amount { get; set; }
        public string Currency { get; set; }
    }

    public class ExecutePaymentRequest
    {
        public string PaymentId { get; set; }
        public string PayerId { get; set; }
    }
}

