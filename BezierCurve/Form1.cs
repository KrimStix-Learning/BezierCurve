using System.Drawing;
using System.Windows.Forms;

namespace BezierCurve
{
    public partial class Form1 : Form
    {
        private PointF p0 = new PointF(100, 200);
        private PointF p1 = new PointF(150, 100);
        private PointF p2 = new PointF(350, 400);
        private PointF p3 = new PointF(400, 200);
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.DarkBlue, 2);

            g.FillEllipse(Brushes.Red, p0.X - 3, p0.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Red, p1.X - 3, p1.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Red, p2.X - 3, p2.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Red, p3.X - 3, p3.Y - 3, 6, 6);

            g.DrawBezier(pen, p0, p1, p2, p3);

            g.DrawLine(Pens.Gray, p0, p1);
            g.DrawLine(Pens.Gray, p1, p2);
            g.DrawLine(Pens.Gray, p2, p3);
        }
    }
}
