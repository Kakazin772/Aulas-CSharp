using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using Paypal.Entites;

namespace Paypal.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Paypal.Entites.Contract contract, int mounth)
        {
            double basequota = contract.TotalValue / mounth;
            int i;

            for (i = 1; i <= mounth; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double quotainterest, totalquota;

                quotainterest = basequota + _onlinePaymentService.Interest(basequota, i);
                totalquota = quotainterest + _onlinePaymentService.PaymentFee(quotainterest);

                contract.AddInstallment(new Installment(date, totalquota));
            }
        }
    }
}
