using Azure.Messaging.ServiceBus;
using EmailProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProvider.Services
{
    public interface IEmailService
    {
        bool SendEmail(EmailRequest emailRequest);
        EmailRequest UnpackEmailRequest(ServiceBusReceivedMessage message);
    }
}
