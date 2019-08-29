using StatePattern.Interface;
using StatePattern.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Classes
{
    public class EnglishMessageProvider : IMessageProvider
    {
        public string MessageWriter(int state)
        {
            switch (state)
            {
                case 1:
                    return LanguageMessage.EnglishDeleted;
                case 2:
                    return LanguageMessage.EnglishSaved;
                case 3:
                    return LanguageMessage.EnglishChange;
                default:
                    throw new Exception("Undefined Message");
            }
        }
    }
}
