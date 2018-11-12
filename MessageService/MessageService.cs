using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessageService
{
    public class MessageService : IMessageService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }

        public string GetMessageWithoutAnyProtection()
        {
            return "This message is sent without any protection";
        }

        public string GetSignedAndEncryptedMessage()
        {
            return "This is a signed and encrypted message";
        }

        public string GetSignedMessage()
        {
            return "This is a signed message";
        }
    }
}
