namespace Paint.Canvas
{
    partial class frmPaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDraw = new Panel();
            btnColor = new Button();
            rbLineWidth5 = new RadioButton();
            rbLineWidth10 = new RadioButton();
            rbLineWidth15 = new RadioButton();
            panelCanvas = new Panel();
            btnSmooth = new Button();
            btnClear = new Button();
            btnLine = new Button();
            btnTriangle = new Button();
            btnEllipse = new Button();
            btnRectangle = new Button();
            rbLine = new RadioButton();
            btnConvert = new Button();
            pictureBoxCanvas = new PictureBox();
            panelDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
            SuspendLayout();
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.ButtonFace;
            panelDraw.Controls.Add(pictureBoxCanvas);
            panelDraw.Location = new Point(30, 49);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(600, 600);
            panelDraw.TabIndex = 0;
            panelDraw.Paint += panelDraw_Paint;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(30, 20);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 0;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // rbLineWidth5
            // 
            rbLineWidth5.AutoSize = true;
            rbLineWidth5.Location = new Point(111, 24);
            rbLineWidth5.Name = "rbLineWidth5";
            rbLineWidth5.Size = new Size(91, 19);
            rbLineWidth5.TabIndex = 1;
            rbLineWidth5.TabStop = true;
            rbLineWidth5.Text = "Line Width 5";
            rbLineWidth5.UseVisualStyleBackColor = true;
            // 
            // rbLineWidth10
            // 
            rbLineWidth10.AutoSize = true;
            rbLineWidth10.Location = new Point(208, 24);
            rbLineWidth10.Name = "rbLineWidth10";
            rbLineWidth10.Size = new Size(97, 19);
            rbLineWidth10.TabIndex = 2;
            rbLineWidth10.TabStop = true;
            rbLineWidth10.Text = "Line Width 10";
            rbLineWidth10.UseVisualStyleBackColor = true;
            // 
            // rbLineWidth15
            // 
            rbLineWidth15.AutoSize = true;
            rbLineWidth15.Location = new Point(311, 24);
            rbLineWidth15.Name = "rbLineWidth15";
            rbLineWidth15.Size = new Size(97, 19);
            rbLineWidth15.TabIndex = 3;
            rbLineWidth15.TabStop = true;
            rbLineWidth15.Text = "Line Width 15";
            rbLineWidth15.UseVisualStyleBackColor = true;
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = SystemColors.ButtonFace;
            panelCanvas.Location = new Point(748, 49);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(600, 600);
            panelCanvas.TabIndex = 1;
            panelCanvas.Paint += panelCanvas_Paint;
            // 
            // btnSmooth
            // 
            btnSmooth.Location = new Point(649, 49);
            btnSmooth.Name = "btnSmooth";
            btnSmooth.Size = new Size(75, 23);
            btnSmooth.TabIndex = 4;
            btnSmooth.Text = "Smooth";
            btnSmooth.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(649, 88);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLine
            // 
            btnLine.Location = new Point(649, 183);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(75, 23);
            btnLine.TabIndex = 5;
            btnLine.Text = "Line";
            btnLine.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            btnTriangle.Location = new Point(649, 324);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(75, 23);
            btnTriangle.TabIndex = 6;
            btnTriangle.Text = "Triangle";
            btnTriangle.UseVisualStyleBackColor = true;
            // 
            // btnEllipse
            // 
            btnEllipse.Location = new Point(649, 276);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(75, 23);
            btnEllipse.TabIndex = 7;
            btnEllipse.Text = "Ellipse";
            btnEllipse.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Location = new Point(649, 228);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(75, 23);
            btnRectangle.TabIndex = 8;
            btnRectangle.Text = "Rectangle";
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            rbLine.AutoSize = true;
            rbLine.Location = new Point(662, 158);
            rbLine.Name = "rbLine";
            rbLine.Size = new Size(47, 19);
            rbLine.TabIndex = 9;
            rbLine.TabStop = true;
            rbLine.Text = "Line";
            rbLine.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(649, 387);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 10;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.Location = new Point(472, 240);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(430, 367);
            pictureBoxCanvas.TabIndex = 11;
            pictureBoxCanvas.TabStop = false;
            // 
            // frmPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1384, 661);
            Controls.Add(btnConvert);
            Controls.Add(rbLine);
            Controls.Add(btnRectangle);
            Controls.Add(btnEllipse);
            Controls.Add(btnTriangle);
            Controls.Add(btnLine);
            Controls.Add(btnClear);
            Controls.Add(btnSmooth);
            Controls.Add(panelCanvas);
            Controls.Add(rbLineWidth15);
            Controls.Add(rbLineWidth10);
            Controls.Add(btnColor);
            Controls.Add(rbLineWidth5);
            Controls.Add(panelDraw);
            Name = "frmPaint";
            Text = "CanvasPaint";
            panelDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDraw;
        private Button btnColor;
        private RadioButton rbLineWidth5;
        private RadioButton rbLineWidth10;
        private RadioButton rbLineWidth15;
        private Panel panelCanvas;
        private Button btnSmooth;
        private Button btnClear;
        private Button btnLine;
        private Button btnTriangle;
        private Button btnEllipse;
        private Button btnRectangle;
        private RadioButton rbLine;
        private Button btnConvert;
        private PictureBox pictureBoxCanvas;
    }
}