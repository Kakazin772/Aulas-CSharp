using System;
using System.Collections.Generic;
using System.Text;

namespace Paypal.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02f;
        }

        public double Interest(double amount, int months)
        {
            return amount * 0.01f * months;
        }
    }
}
