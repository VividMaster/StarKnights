using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace StarControls
{
    [DefaultEvent("ClickButton")]
    public partial class StarButton : UserControl
    {

        public event EventHandler ClickButton;

        public Bitmap BackImg = null;//  new Bitmap("StarControls.buttonDark.png");
        public Bitmap BackImgOver = null, BackImgPress = null;

        public string ButText
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
            }
        }
        public string _Text = "";

        public StarButton()
        {
            InitializeComponent();

            Assembly _assembly;
            Stream _imageStream;
            StreamReader _textStreamReader;

            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("StarControls.buttonDark.png");

            BackImg = new Bitmap(_imageStream);

            _imageStream = _assembly.GetManifestResourceStream("StarControls.buttonDarkOver.png");
            BackImgOver = new Bitmap(_imageStream);

            _imageStream = _assembly.GetManifestResourceStream("StarControls.buttonDarkPress.png");

            BackImgPress = new Bitmap(_imageStream);

            this.DoubleBuffered = true;
        }

        private void StarButton_Paint(object sender, PaintEventArgs e)
        {


            if (over==true && press == false)
            {
                e.Graphics.DrawImage(BackImgOver, new Rectangle(0, 0, Width, Height));
            }
            else if (press)
            {
                e.Graphics.DrawImage(BackImgPress, new Rectangle(2,2, Width-4, Height-4));
            }
            else { 

                e.Graphics.DrawImage(BackImg, new Rectangle(0,0, Width, Height));
            }
           var ss = e.Graphics.MeasureString(ButText,SystemFonts.CaptionFont);
            e.Graphics.DrawString(ButText, SystemFonts.DialogFont, Brushes.White, new PointF(Width / 2 - ss.Width / 2,2 +(Height / 2 - ss.Height / 2)));
        }
        bool over=false, press=false;

        private void StarButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                press = true;
                //over = fals
                Invalidate();
            }
        }

        private void StarButton_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                press = false;
                Invalidate();
            }
            ClickButton?.Invoke(this, null);
        }

        private void StarButton_MouseLeave(object sender, EventArgs e)
        {
            over = false;
            Invalidate();
        }

        private void StarButton_MouseEnter(object sender, EventArgs e)
        {

            over = true;
            Invalidate();
        }
    }
}
