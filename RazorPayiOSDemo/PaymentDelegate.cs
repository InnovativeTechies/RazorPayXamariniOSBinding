using System;
using Com.RazorPay;
using Foundation;

namespace RazorPayiOSDemo
{
    public class PaymentDelegate : RazorpayPaymentCompletionProtocol
    {
     

        [Export("onPaymentError:description:")]
        public override void OnPaymentError(int code, string str)
        {
            
        }

        [Export("onPaymentSuccess:")]
        public override void OnPaymentSuccess(string payment_id)
        {
            
        }

    }
}
