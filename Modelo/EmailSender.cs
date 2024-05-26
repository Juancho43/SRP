using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Single_responsability.Modelo
{
    public class EmailSender
    {
        private String From;
        private String To;
        private String Subject;
        private String Body;


        public EmailSender()
        {
            From = "company@company.com";
        }
        public void SetEmailSender(string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }


        public String Send()
        {
            return $"Sending email to {To} \n" +
                $"Subject: {Subject} \n" +
                $"{Body}";
        }
    }
}
