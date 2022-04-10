using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneTransition
{
    internal abstract class MobilePhoneEra3 : IEmail, IGaming, IMessaging
    {
        public void PlayGame(string gameName)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string messagingPlatform)
        {
            throw new NotImplementedException();
        }
    }
}
