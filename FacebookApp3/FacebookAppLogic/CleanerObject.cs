using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookAppLogic
{
    public class FormCleaner
    {
        public bool Activated { get; set; }

        private Dictionary<string, IObserverClean> Observers;
        
        public FormCleaner()
        {
            Activated = false;
            Observers = new Dictionary<string, IObserverClean>();
        }
        
        public void Attach(IObserverClean observer)
        {
            this.Observers.Add(observer.ToString(), observer);
        }

        public void AttachLegacyControl(Control i_Control)
        {
            ControlObserver temp = new ControlObserver(i_Control, this);

            this.Observers.Add(temp.GetHashCode().ToString() + i_Control.Name, temp);
        }
        
        public void AttachAllControls(Control i_Control)
        {
            foreach (Control control in i_Control.Controls)
            {
                AttachAllControls(control);

                if (control is PictureBox || control is FlowLayoutPanel || control is ListBox || control is TextBox)
                {
                    this.AttachLegacyControl(control);
                }
            }
        }

        public void Detach(IObserverClean observer)
        {
            Observers.Remove(observer.GetHashCode().ToString() + (observer as ControlObserver).control.Name);
        }

        //// Notify to all proxy'd (for legacy) to clear.
        public void NotifyClear()
        {
            foreach (IObserverClean observer in Observers.Values)
            {
                observer.Clear(this);
            }
        }
    }

    //// Proxy of Control's legacy Components.
    public class ControlObserver : IObserverClean
    {
        private FormCleaner Cleaner { get; set; }           /* -Subject */

        private bool Loaded { get; set; }                   /* -State */

        public Control control { get; private set; }        /* -Actual Control*/

        public ControlObserver(Control i_Control, FormCleaner i_FormCleaner)
        {
            control = i_Control;
            Loaded = true;
            Cleaner = i_FormCleaner;
        }

        /* Clear the current legacy component controls*/
        public void Clear(FormCleaner i_cleaner)
        {
            Type t = this.control.GetType(); /* get the Type of the proxy'ed Control. */
                                             /* Reflaction ! */

            if (t.IsInstanceOfType(new PictureBox()))
            {
                (this.control as PictureBox).Image = null;
            }
            else if (t.IsInstanceOfType(new ListBox()))
            {
                (this.control as ListBox).Items.Clear();
            }
            else if (t.IsInstanceOfType(new FlowLayoutPanel()))
            {
                this.control.Controls.Clear();
            }
            else if (t.IsInstanceOfType(new TextBox()))
            {
                this.control.ResetText();
            }
            else
            {
                throw new ArgumentException();
            }

            Loaded = false;
        }
    }
}
