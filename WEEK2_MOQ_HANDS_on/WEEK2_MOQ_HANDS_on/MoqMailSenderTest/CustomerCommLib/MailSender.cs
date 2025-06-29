
using System.Net;
using System.Net.Mail;

namespace CustomerCommLib
{
    public class MailSender : IMailSender
    {
        public bool SendMail(string toAddress, string message)
        {
            // Simulating a real mail send which would be skipped in unit test
            return true;
        }
    }
}
