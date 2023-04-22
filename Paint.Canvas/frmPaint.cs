
using System.Drawing;

namespace Paint.Canvas;

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



    private void panelDraw_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            // Get the size of the rectangle to draw
            int width = Math.Abs(x.X - e.X);
            int height = Math.Abs(x.Y - e.Y);

            // Get the top-left corner of the rectangle to draw
            Point topLeft = new Point(Math.Min(x.X, e.X), Math.Min(x.Y, e.Y));

            // Create a bitmap to draw the rectangle on
            Bitmap bmp = new Bitmap(width, height);

            // Draw the rectangle on the bitmap
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawRectangle(penA, new Rectangle(0, 0, width - 1, height - 1));
            }

            // Display the bitmap on the picture box
            pictureBoxCanvas.Image = bmp;
        }
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

    private void btnConvert_Click(object sender, EventArgs e)
    {

    }
}


