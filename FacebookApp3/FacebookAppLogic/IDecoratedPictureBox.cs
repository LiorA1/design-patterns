using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppLogic
{
    public interface IDecoratedPictureBox
    {
        void Execute();

        extendedPictureBox getPictureBoxItem();
    }
}
