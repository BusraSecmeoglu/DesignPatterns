using StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Classes
{
    public class MessageProvider
    {
        IMessageProvider _IMessageProvider;
        public MessageProvider()
        {
            _IMessageProvider = new TurkhishMessageProvider();
        }

        public void SetLanguage(IMessageProvider messageProvider)
        {
            _IMessageProvider = messageProvider;
        }

        public string PublishMessage(int state)
        {
            return _IMessageProvider.MessageWriter(state);
        }
    }
}
