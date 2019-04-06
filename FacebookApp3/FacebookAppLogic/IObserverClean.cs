using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppLogic
{
    public interface IObserverClean
    {
        void Clear(FormCleaner i_cleaner);
    }
}
