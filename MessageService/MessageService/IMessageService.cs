using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;

namespace MessageService
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        string GetMessage(string name);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string GetMessageWithoutAnyProtection();

        [OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
        string GetSignedMessage();

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        string GetSignedAndEncryptedMessage();
    }
}
