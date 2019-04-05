using System;
using System.Timers;

namespace FacebookAppLogic
{
    public class managedDelayedPost
    {       
        private FacebookEngine m_facebookEngine; 
        private string m_Text;

        public Exception InnerException { get; private set; }

        public DateTime OperateTime { get; set; }

        public Timer TimerToOperate { get; set; }

        public managedDelayedPost(FacebookEngine i_facebookEngine, DateTime i_OperateTime, string i_text)
        {
            this.InnerException = null;
            this.m_facebookEngine = i_facebookEngine;
            this.TimerToOperate = new Timer((i_OperateTime.Ticks / TimeSpan.TicksPerMillisecond) - (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond));
            this.OperateTime = i_OperateTime;
            this.m_Text = i_text;

            delayedPostWarpper();
        }

        private void delayedPostWarpper()
        {
            try
            {
                this.TimerToOperate.Enabled = true;
                this.TimerToOperate.Start();

                TimerToOperate.Elapsed += new System.Timers.ElapsedEventHandler(postDelayedStatus);
            }
            catch (Exception ex)
            {
                this.InnerException = ex;
            }
        }

        private void postDelayedStatus(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                this.m_facebookEngine.PostStatus(this.m_Text);
            }
            catch (Exception ex)
            {
                this.InnerException = ex;
            }
            finally
            {
                this.TimerToOperate.Enabled = false;
                this.TimerToOperate.Stop();
                this.TimerToOperate.Dispose();
            }
        }

        public void AbortDelayedPostStatus()
        {
            try
            {
                this.TimerToOperate.Enabled = false;
                this.TimerToOperate.Stop();
            }
            catch (Exception ex)
            {
                this.InnerException = ex;
            }
            finally
            {
                TimerToOperate.Dispose();
            }
        }
    }
}
