﻿using PayPal.Api;
using System.Threading.Tasks;

namespace Car_Rental_APIs.GenericRepo
{
    public interface PaypalRepo
    {
        Task<Payment> CreatePaymentAsync(decimal amount, string currency);
        Task<Payment> ExecutePaymentAsync(string paymentId, string payerId);
    }
}
