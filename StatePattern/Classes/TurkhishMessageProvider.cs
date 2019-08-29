using StatePattern.Interface;
using StatePattern.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Classes
{
    public class TurkhishMessageProvider : IMessageProvider
    {
        private int _change;
        public string MessageWriter(int state)
        {


            switch (state)
            {
                case 1:
                    return LanguageMessage.TurkhishDeleted;

                case 2:
                    return LanguageMessage.TurkhishSaved;

                case 3:
                    if (_change == 0)
                    {
                        _change = -1;
                        return LanguageMessage.TurkhishChange;
                    }
                    else
                    {
                        throw new Exception("Undefined Message");
                    }
                   
                default:
                    throw new Exception("Undefined Message");
            }

        }
    }
}
