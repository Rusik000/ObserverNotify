using ObserverNotify.GmailService;
using ObserverNotify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNotify.Classes
{
    public class CustomerViaGmail : ICustomer
    {
        public string ProductName { get; set; }
        public string CustomerEmail { get; set; }

        public void GetMessage()
        {
            Sending_Gmail.SendMail(CustomerEmail,ProductName);
        }
    }
}
