using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;

namespace RoundKit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string GetCallPhone()
        {
            string AccountSid = "AC250c475896904f3249306f633df6d114";
            string AuthToken = "ed3be1bdddedf301c711c4ee33f0e185";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);


            var options = new CallOptions();
            options.Url = "http://demo.twilio.com/docs/voice.xml";
            options.To = "+18179466874";
            options.From = "+18179622556";
            var call = twilio.InitiateOutboundCall(options);
            return "sucess";
        }

        public string GetSendSMS()
        {
            string AccountSid = "AC250c475896904f3249306f633df6d114";
            string AuthToken = "ed3be1bdddedf301c711c4ee33f0e185";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            var message = twilio.SendSmsMessage("+18179622556", "+18179466874", "Sunny please?! I love you <3", "");
            ViewBag.msg = message.Sid;

            return "sucess";
        }
        public string GetListSMS()
        {
            return "sucess";
        }


    }
}
