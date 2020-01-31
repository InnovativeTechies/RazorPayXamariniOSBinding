using Foundation;
using System;
using UIKit;
using Com.RazorPay;
namespace RazorPayiOSDemo
{
    public partial class ViewController : UIViewController
    {
        protected RazorpayPaymentCompletionProtocol paymentDelegate { get; set; }
        Razorpay razorPay;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            paymentDelegate = new PaymentDelegate();
            razorPay = Razorpay.InitWithKey("rzp_test_jrp8tiisBLMEyN", paymentDelegate);

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            this.ShowPaymentForm();
        }

        private void ShowPaymentForm()
        {

            var keys = new[]
{
    new NSString("amount"),
    new NSString("currency"),
    new NSString("description"),
    new NSString("order_id"),
    new NSString("name")
};

            var objects = new NSObject[]
            {
    // don't have to be strings... can be any NSObject.
    new NSString("100"),
    new NSString("INR"),
    new NSString("Purchase of phone"),
    new NSString("order_EB26m7S11mb9fN"),
    new NSString("My business")
            };

            var options = new NSDictionary<NSString, NSObject>(keys, objects);
            razorPay.Open(options);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void OnPaymentError(int code, string str, NSDictionary response)
        {
            
        }

        public void OnPaymentSuccess(string payment_id, NSDictionary response)
        {
            
        }

        public void OnPaymentError(int code, string str)
        {
            throw new NotImplementedException();
        }

        public void OnPaymentSuccess(string payment_id)
        {
            throw new NotImplementedException();
        }
    }
}