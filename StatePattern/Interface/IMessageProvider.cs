using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Interface
{
    public interface IMessageProvider
    {
        string MessageWriter(int state);
    }
}
