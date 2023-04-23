
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Net;

namespace Paint.Canvas;

public partial class frmPaint : Form
{
    public Point startPoint = new();
    public Point endPoint = new();
    public Pen penA = new(Color.Black, 2);

    public Graphics graphics;

    private bool isDrawing = false;


    public frmPaint()
    {
        InitializeComponent();
        graphics = panelDraw.CreateGraphics();
    }
    private void panelDraw_MouseDown(object sender, MouseEventArgs e)
    {

       
        isDrawing = true;
        startPoint = e.Location;


        endPoint = e.Location;

    }

    private void panelDraw_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            startPoint = e.Location;
            graphics.DrawLine(penA, startPoint, endPoint);
            endPoint = e.Location;
        }
        //if (isDrawing)
        //{
        //    using (Graphics g = panelDraw.CreateGraphics())
        //    {
        //        // Clear previous drawings
        //        g.Clear(panelDraw.BackColor);

        //        // Draw temporary line
        //        g.DrawLine(Pens.Black, startPoint, e.Location);

        //        // Update end point
        //        endPoint = e.Location;
        //    }
        //}
    }



    private void panelDraw_MouseUp(object sender, MouseEventArgs e)
    {
        isDrawing = false;
        // Create graphics object for panelCanvas
        Graphics g = panelCanvas.CreateGraphics();


        //float m = (endPoint.Y - startPoint.Y) / (float)(endPoint.X - startPoint.X);
        //float b = startPoint.Y - m * startPoint.X;

        //float drawX = (endPoint.X - startPoint.X);
        //float drawY = (endPoint.Y - startPoint.Y);


        //int newX = (int)((panelCanvas.Height - b) / m);
        //int newY = (int)((panelCanvas.Height - b));
        //Point newEndPoint = new(newX, newY);

        g.DrawLine(Pens.Black, startPoint, endPoint);

    }

    private void panelDraw_Paint(object sender, PaintEventArgs e)
    {

    }


    private void panelCanvas_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnColor_Click(object sender, EventArgs e)
    {
        ColorDialog colorDialog = new();
        if (colorDialog.ShowDialog() == DialogResult.OK)
            penA.Color = colorDialog.Color;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        graphics.Clear(panelDraw.BackColor);
    }


}


