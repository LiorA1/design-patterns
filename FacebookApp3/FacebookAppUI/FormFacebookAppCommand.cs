using System.Windows.Forms;

namespace FacebookAppUI
{
    public abstract class FormFacebookAppCommand : ICommandExecutor
    {
        public FormFacebookApp Client { get; set; }

        public abstract void Execute();
    }
}
