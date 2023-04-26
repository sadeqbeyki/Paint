using System.Net;

namespace Paint.PaintD
{
    public partial class Form1 : Form
    {
        public Pen penA = new(Color.Black, 2);
        public Pen Eraser = new(Color.White, 10);
        public Graphics graphicsPanelDraw;
        public Graphics graphicsPanelCanvas;
        private bool isDrawing = false;
        private bool isSquare = false;
        private List<Point> points = new();

        Point xGlobal = new();//
        Point yGlobal = new();//
        int sizeDiff = 50; //
        public Form1()
        {
            InitializeComponent();
            graphicsPanelDraw = panelDraw.CreateGraphics();
            graphicsPanelCanvas = panelCanvas.CreateGraphics();
        }
        Point upPoint = new Point(); //Point A for Square
        Point downPoint = new Point(); //Point B for Square
        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                points.Add(e.Location);
            }
            points[points.Count - 1] = e.Location;//
            yGlobal = points[points.Count - 1]; // 
            upPoint = points[points.Count - 1]; //
            downPoint = points[points.Count - 1]; //
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrawing)
                {
                    points.Add(e.Location);
                    graphicsPanelDraw.DrawLine(penA, points[points.Count - 2], points[points.Count - 1]);
                }

                //Verify to decrease upPoint//
                if (points[points.Count - 2].X < upPoint.X)
                {
                    upPoint.X = points[points.Count - 2].X;
                }
                if (points[points.Count - 2].Y < upPoint.Y)
                {
                    upPoint.Y = points[points.Count - 2].Y;
                }

                //Verify to increment downPoint//
                if (points[points.Count - 2].X > downPoint.X)
                {
                    downPoint.X = points[points.Count - 2].X;
                }
                if (points[points.Count - 2].Y > downPoint.Y)
                {
                    downPoint.Y = points[points.Count - 2].Y;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (isDrawing)
                {
                    points.Add(e.Location);
                    graphicsPanelDraw.DrawLine(Eraser, points[points.Count - 2], points[points.Count - 1]);
                }
            }

            if (rbLineWidth5.Checked)
                penA.Width = 5;
            if (rbLineWidth10.Checked)
                penA.Width = 10;
            if (rbLineWidth15.Checked)
                penA.Width = 15;
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            xGlobal = e.Location; // 

            int XDiff = (yGlobal.X - xGlobal.X); // 
            int YDiff = (yGlobal.Y - xGlobal.Y); // 

            // 
            if (XDiff < 0)
            {
                XDiff *= -1;
            }
            if (YDiff < 0)
            {
                YDiff *= -1;
            }

            if (isDrawing)
            {
                points.Add(e.Location);
                isDrawing = false;

                // Differentiate the figure based on the number of points
                switch (points.Count)
                {
                    case 2:
                        // Line
                        graphicsPanelCanvas.DrawLine(penA, points[0], points[1]);
                        break;
                    case 3:
                        // Triangle
                        graphicsPanelCanvas.DrawPolygon(penA, points.ToArray());
                        break;
                    case 4:
                        // Square
                        isSquare = true;
                        graphicsPanelCanvas.DrawPolygon(penA, points.ToArray());
                        break;
                    case 5:
                        // Pentagon
                        graphicsPanelCanvas.DrawPolygon(penA, points.ToArray());
                        break;
                    //case 6:
                    //    //Circle
                    //    graphicsPanelCanvas.DrawEllipse(penA, points.ToArray());
                    //    break;
                    default:
                        // Other figure
                        break;
                }

                points.Clear();
                isSquare = false;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                penA.Color = colorDialog.Color;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphicsPanelDraw.Clear(panelDraw.BackColor);
            graphicsPanelCanvas.Clear(panelCanvas.BackColor);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                points.Clear();
                isDrawing = false;
            }
        }
    }
}