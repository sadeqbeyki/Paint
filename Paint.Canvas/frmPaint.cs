namespace Paint.Canvas;

public partial class frmPaint : Form
{
    public Point startPoint = new();
    public Point endPoint = new();

    Point xGlobal = new();
    Point yGlobal = new();

    public Pen penA = new(Color.Black, 2);
    public Pen Eraser = new(Color.White, 10);

    public Graphics graphicsPanelDraw;
    public Graphics graphicsPanelCanvas;

    private bool isDrawing = false;
    int sizeDiff = 50; //Var pixels to difference square to line 


    public frmPaint()
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

        if (rbLineWidth5.Checked)
            penA.Width = 5;
        if (rbLineWidth10.Checked)
            penA.Width = 10;
        if (rbLineWidth15.Checked)
            penA.Width = 15;
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

        // Verify start point and end point 
        if (XDiff < sizeDiff)
        {
            if (YDiff < sizeDiff)
            {
                isSquare = true; // defines whether it is a square or not based on the start and end point
            }
        }

        if (isDrawing == true)
        {
            if (isSquare)
            {
                //Draw Square in Panel B
                graphicsPanelCanvas.DrawRectangle(penA, new Rectangle(upPoint, new Size(downPoint.X - upPoint.X, downPoint.Y - upPoint.Y))); //Graphics panel B
            }
            else
            {
                //Draw Line in Panel B
                graphicsPanelCanvas.DrawLine(penA, xGlobal, yGlobal); //Graphics panel B
            }


            isDrawing = false;
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


}


