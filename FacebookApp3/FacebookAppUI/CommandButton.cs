using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookAppUI
{
    public class CommandButton : Button
    {
        public ICommandExecutor Command { get; set; }

        protected override void OnClick(EventArgs e)
        {
            Command.Execute();
        }
    }
}
