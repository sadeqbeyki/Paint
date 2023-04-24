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
            btnClear = new Button();
            SuspendLayout();
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.ButtonFace;
            panelDraw.Location = new Point(30, 50);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(600, 600);
            panelDraw.TabIndex = 0;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(649, 50);
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
            panelCanvas.Location = new Point(750, 50);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(600, 600);
            panelCanvas.TabIndex = 1;
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
            // frmPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1384, 661);
            Controls.Add(btnClear);
            Controls.Add(panelCanvas);
            Controls.Add(rbLineWidth15);
            Controls.Add(rbLineWidth10);
            Controls.Add(btnColor);
            Controls.Add(rbLineWidth5);
            Controls.Add(panelDraw);
            Name = "frmPaint";
            Text = "CanvasPaint";
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
        private Button btnClear;
    }
}