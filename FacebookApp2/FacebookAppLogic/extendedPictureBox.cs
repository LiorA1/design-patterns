using System;
using System.Windows.Forms;

namespace FacebookAppLogic
{
    public class extendedPictureBox : PictureBox
    {
        public Uri URI { get; private set; }

        public Form Review { get; private set; }

        public bool DownloadWanted { get; private set; }

        public void Load(string i_UriToLoad)
        {
            URI = new Uri(i_UriToLoad);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            DownloadWanted = false;
            Padding = new Padding(2);
            Margin = new Padding(1);
            Enabled = true;
            CausesValidation = true;

            if (ImageLocation == null)
            {
                ImageLocation = this.URI.OriginalString;             
            }

            base.OnPaint(pe);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Review = new Form();
            Review.Location = new System.Drawing.Point(MousePosition.X + 100, MousePosition.Y - 100);
            Review.StartPosition = FormStartPosition.Manual;
            PictureBox pic = new PictureBox();
            pic.Image = Image;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Dock = DockStyle.Fill;
            Review.Controls.Add(pic);
            
            Review.Show();

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Review.Close();
            Review.Dispose();
            base.OnMouseLeave(e);
        }

        // With double click - You select the Image for download.
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.BlueViolet)
            {
                this.BackColor = this.Parent.BackColor;
                DownloadWanted = false;
            }
            else
            {
                this.BackColor = System.Drawing.Color.BlueViolet;
                DownloadWanted = true;
            }

            base.OnMouseDoubleClick(e);         
        }       
    }
}
