using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Classes
{
    public class ChangeMessageProvider
    {
        MessageProvider messageProvider = new MessageProvider();

        public string SetLanguage(int languageId,int state =3)
        {
            if (languageId == 1)
            {
                messageProvider.SetLanguage(new TurkhishMessageProvider());
                return messageProvider.PublishMessage(state);

            }
            else if (languageId == 2)
            {
                messageProvider.SetLanguage(new EnglishMessageProvider());
                return messageProvider.PublishMessage(state);
            }
            else
            {
                throw new Exception("UnDefined language");
            }
        }
    }
}
