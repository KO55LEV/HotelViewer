using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace HotelsViewer.Services
{
    
    public class MailService : IMailService
    {
        private readonly ILogger<MailService> _logger;

        public MailService(ILogger<MailService> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string to,string subject,string body)
        {
            //Send message 
            _logger.LogInformation($"Send Message, To: {to} Subject:{subject} Body:{body}");

            //Todo write implementation for SendMessage
        }

    }
}
