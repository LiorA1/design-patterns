using System;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookAppLogic
{
    public class extendedPictureBox : PictureBox
    {
        public Uri URI { get; private set; }

        public Form Review { get; private set; }

        public bool DownloadWanted { get; private set; }

        public new void Load(string i_UriToLoad)
        {
            URI = new Uri(i_UriToLoad);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            DownloadWanted = false;  /*TODO : PROBLEM - THIS METHOD CALLED TOO DAMN MUCH*/
            /*Padding = new Padding(2);
            //Margin = new Padding(1);*/
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
                this.DownloadWanted = false;
            }
            else
            {
                this.BackColor = System.Drawing.Color.BlueViolet;
                this.DownloadWanted = true;
            }

            base.OnMouseDoubleClick(e);         
        }       
    }

    //// Core PictureBox or maybe a thin version of extendedPictureBox
    public class CorePictureBox : IDecoratedPictureBox
    {
        public extendedPictureBox PictureBox { get; set; }

        public CorePictureBox(extendedPictureBox i_PictureBox)
        {
            PictureBox = i_PictureBox;
        }

        public void Execute()
        {
            PictureBox.Show();
        }

        public extendedPictureBox getPictureBoxItem()
        {
            return this.PictureBox;
        }
    }

    //// Decorated PictureBox or maybe a extenedable version of extendedPictureBox
    public class DecoratedPictureBox : IDecoratedPictureBox
    {
        public extendedPictureBox PictureBoxToDecorate { get; set; }

        public IDecoratedPictureBox DecoratedFatherPictureBox { get; set; }

        public DecoratedPictureBox(IDecoratedPictureBox i_PictureBox)
        {
            if (i_PictureBox is CorePictureBox)
            {
                PictureBoxToDecorate = (i_PictureBox as CorePictureBox).PictureBox;
            }
            else
            {
                PictureBoxToDecorate = (i_PictureBox as DecoratedPictureBox).PictureBoxToDecorate;
            }

            DecoratedFatherPictureBox = i_PictureBox;
            PictureBoxToDecorate.Visible = true;
            PictureBoxToDecorate.Enabled = true;
        }
        
        public virtual void Execute()
        {
            DecoratedFatherPictureBox.Execute();
        }

        public extendedPictureBox getPictureBoxItem()
        {
            return this.PictureBoxToDecorate;
        }
    }

    ////**********************************************************************/
    ////* Change the back color */
    public class DecoratorBackColor : DecoratedPictureBox
    {
        private Color BackColor { get; set; }

        public DecoratorBackColor(IDecoratedPictureBox i_DecoratedPictureBox, Color i_Color) : base(i_DecoratedPictureBox)
        {
            BackColor = i_Color;
        }

        public override void Execute()
        {
            base.Execute();
            PictureBoxToDecorate.BackColor = BackColor;
        }
    }

    // Change the margin 
    public class DecoratorMargin : DecoratedPictureBox
    {
        private Padding Margin { get; set; }

        public DecoratorMargin(IDecoratedPictureBox i_DecoratedPictureBox, Padding i_Margin) : base(i_DecoratedPictureBox)
        {
            Margin = i_Margin;
        }

        public override void Execute()
        {
            base.Execute();
            PictureBoxToDecorate.Margin = Margin;
        }
    }

    // Change the padding 
    public class DecoratorPadding : DecoratedPictureBox
    {
        private Padding Padding { get; set; }

        public DecoratorPadding(IDecoratedPictureBox i_DecoratedPictureBox, Padding i_Padding) : base(i_DecoratedPictureBox)
        {
            Padding = i_Padding;
        }
        
        public override void Execute()
        {
            base.Execute();
            PictureBoxToDecorate.Padding = Padding;
        }
    }
}
