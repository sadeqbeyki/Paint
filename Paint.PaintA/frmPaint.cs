namespace Paint.PaintA
{
    public partial class frmPaint : Form
    {
        public Point x = new();
        public Point y = new();
        public Pen penA = new(Color.Red, 2);
        public Pen Eraser = new(Color.White, 10);
        public Graphics graphics;
        public frmPaint()
        {
            InitializeComponent();
            graphics = panelDraw.CreateGraphics();
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            y = e.Location;

            if (rbLineWidth5.Checked)
                penA.Width = 5;
            if (rbLineWidth10.Checked)
                penA.Width = 10;
            if (rbLineWidth15.Checked)
                penA.Width = 15;
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { 
                x = e.Location;
                graphics.DrawLine(penA, x, y);
                y = e.Location;
            }

            if (e.Button == MouseButtons.Right)
            {
                x = e.Location;
                graphics.DrawLine(Eraser, x, y);
                y = e.Location;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                penA.Color = colorDialog.Color;
        }
    }
}