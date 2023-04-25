namespace Paint.PaintD
{
    partial class Form1
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
            btnClear = new Button();
            panelCanvas = new Panel();
            rbLineWidth15 = new RadioButton();
            rbLineWidth10 = new RadioButton();
            btnColor = new Button();
            rbLineWidth5 = new RadioButton();
            panelDraw = new Panel();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(681, 75);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = SystemColors.ButtonFace;
            panelCanvas.Location = new Point(782, 37);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(600, 600);
            panelCanvas.TabIndex = 7;
            // 
            // rbLineWidth15
            // 
            rbLineWidth15.AutoSize = true;
            rbLineWidth15.Location = new Point(343, 11);
            rbLineWidth15.Name = "rbLineWidth15";
            rbLineWidth15.Size = new Size(97, 19);
            rbLineWidth15.TabIndex = 10;
            rbLineWidth15.TabStop = true;
            rbLineWidth15.Text = "Line Width 15";
            rbLineWidth15.UseVisualStyleBackColor = true;
            // 
            // rbLineWidth10
            // 
            rbLineWidth10.AutoSize = true;
            rbLineWidth10.Location = new Point(240, 11);
            rbLineWidth10.Name = "rbLineWidth10";
            rbLineWidth10.Size = new Size(97, 19);
            rbLineWidth10.TabIndex = 9;
            rbLineWidth10.TabStop = true;
            rbLineWidth10.Text = "Line Width 10";
            rbLineWidth10.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(681, 37);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 5;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // rbLineWidth5
            // 
            rbLineWidth5.AutoSize = true;
            rbLineWidth5.Location = new Point(143, 11);
            rbLineWidth5.Name = "rbLineWidth5";
            rbLineWidth5.Size = new Size(91, 19);
            rbLineWidth5.TabIndex = 8;
            rbLineWidth5.TabStop = true;
            rbLineWidth5.Text = "Line Width 5";
            rbLineWidth5.UseVisualStyleBackColor = true;
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.ButtonFace;
            panelDraw.Location = new Point(62, 37);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(600, 600);
            panelDraw.TabIndex = 6;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 648);
            Controls.Add(btnClear);
            Controls.Add(panelCanvas);
            Controls.Add(rbLineWidth15);
            Controls.Add(rbLineWidth10);
            Controls.Add(btnColor);
            Controls.Add(rbLineWidth5);
            Controls.Add(panelDraw);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Panel panelCanvas;
        private RadioButton rbLineWidth15;
        private RadioButton rbLineWidth10;
        private Button btnColor;
        private RadioButton rbLineWidth5;
        private Panel panelDraw;
    }
}