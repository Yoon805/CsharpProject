
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CalculatorApp.UserControls
{
    internal class UserToggleButton: CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;


        public override string Text { get => base.Text; }
        public Color OnBackColor { get => onBackColor; set => onBackColor = value; }
        public Color OnToggleColor { get => onToggleColor; set => onToggleColor = value; }
        public Color OffBackColor { get => offBackColor; set => offBackColor = value; }
        public Color OffToggleColor { get => offToggleColor; set => offToggleColor = value; }


        //Constructor
        public UserToggleButton() 
        {
            this.MinimumSize = new Size(10, 10);
        }

        //Methods
        private GraphicsPath GetFigurePath() 
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize -2 , 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;


        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) // ON
            {   //Draw the conntrol surface
                pevent.Graphics.FillPath(new SolidBrush(OnBackColor),GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(OnToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            { //Draw the conntrol surface
                pevent.Graphics.FillPath(new SolidBrush(OffBackColor), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(OffToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
