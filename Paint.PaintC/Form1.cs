namespace Paint.PaintC;

public partial class Form1 : Form
{
    public Point startPoint = new();
    public Point endPoint = new();

    Point xGlobal = new();
    Point yGlobal = new();
    Point zGlobal = new();

    public Pen penA = new(Color.Black, 2);
    public Pen Eraser = new(Color.White, 10);

    public Graphics graphicsPanelDraw;
    public Graphics graphicsPanelCanvas;

    private bool isDrawing = false;
    int sizeDiff = 50; //Var pixels to difference square to line 
    public Form1()
    {
        InitializeComponent();
        graphicsPanelDraw = panelDraw.CreateGraphics();
        graphicsPanelCanvas = panelCanvas.CreateGraphics();
    }
    Point upPoint = new(); //Point A for Square
    Point downPoint = new(); //Point B for Square
    private void panelDraw_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isDrawing = true; //On drawing var to MouseLeave event
        }
        endPoint = e.Location;
        yGlobal = endPoint; // Y Point for draw in the MouseLeave
        upPoint = endPoint; //Reference point for Square
        downPoint = endPoint; //Reference point for Square
        zGlobal = endPoint; // Z Point for draw in the MouseLeave
    }

    private void panelDraw_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            startPoint = e.Location;
            graphicsPanelDraw.DrawLine(penA, startPoint, endPoint);
            endPoint = e.Location;

            //Verify to decrease upPoint
            if (startPoint.X < upPoint.X)
            {
                upPoint.X = startPoint.X;
            }
            if (startPoint.Y < upPoint.Y)
            {
                upPoint.Y = startPoint.Y;
            }

            //Verify to increment downPoint
            if (startPoint.X > downPoint.X)
            {
                downPoint.X = startPoint.X;
            }
            if (startPoint.Y > downPoint.Y)
            {
                downPoint.Y = startPoint.Y;
            }
        }

        if (e.Button == MouseButtons.Right)
        {
            startPoint = e.Location;
            graphicsPanelDraw.DrawLine(Eraser, startPoint, endPoint);
            endPoint = e.Location;
        }

        //if (rbLineWidth5.Checked)
        //    penA.Width = 5;
        //if (rbLineWidth10.Checked)
        //    penA.Width = 10;
        //if (rbLineWidth15.Checked)
        //    penA.Width = 15;
    }

    private void panelDraw_MouseUp(object sender, MouseEventArgs e)
    {
        xGlobal = e.Location; // X Point for draw in the MouseLeave

        int XDiff = (yGlobal.X - xGlobal.X); // Difference start point and end point int width
        int YDiff = (yGlobal.Y - xGlobal.Y); // Difference start point and end point int height

        // Convert difference to positive integer
        if (XDiff < 0)
        {
            XDiff *= -1;
        }
        if (YDiff < 0)
        {
            YDiff *= -1;
        }

        bool isSquare = false; // isSquare Var
        bool isTriangle = false; // isTriangle Var

        // Verify start point and end point 
        if (XDiff < sizeDiff)
        {
            if (YDiff < sizeDiff)
            {
                isSquare = true;
            }
            else
            {
                isTriangle = true;
            }
        }
        else if (YDiff < sizeDiff)
        {
            isTriangle = true;
        }

        //Draw Square, Triangle or Line
        if (isSquare)
        {
            int width = downPoint.X - upPoint.X;
            int height = downPoint.Y - upPoint.Y;
            Rectangle rect = new Rectangle(upPoint.X, upPoint.Y, width, height);
            graphicsPanelCanvas.DrawRectangle(penA, rect);
        }
        else if (isTriangle)
        {
            Point[] trianglePoints = new Point[]
            {
                new Point(xGlobal.X, xGlobal.Y),
                new Point(yGlobal.X, yGlobal.Y),
                new Point(zGlobal.X, zGlobal.Y)
            };
            graphicsPanelCanvas.DrawPolygon(penA, trianglePoints);
        }
        else
        {
            graphicsPanelCanvas.DrawLine(penA, xGlobal, yGlobal);
        }

        if (XDiff >= sizeDiff && YDiff >= sizeDiff)
        {
            // draw square
            graphicsPanelCanvas.DrawRectangle(penA, upPoint.X, upPoint.Y, downPoint.X - upPoint.X, downPoint.Y - upPoint.Y);
        }
        else if (XDiff < sizeDiff && YDiff < sizeDiff)
        {
            // draw line
            graphicsPanelCanvas.DrawLine(penA, zGlobal.X, zGlobal.Y, xGlobal.X, xGlobal.Y);
        }
        else
        {
            // draw triangle
            Point[] points = { new Point(upPoint.X, downPoint.Y), new Point(downPoint.X, downPoint.Y), new Point((upPoint.X + downPoint.X) / 2, upPoint.Y) };
            graphicsPanelCanvas.DrawPolygon(penA, points);
        }

        isDrawing = false;
    }
}


