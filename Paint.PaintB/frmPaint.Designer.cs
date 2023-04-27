namespace Paint.PaintB
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
            panelResult = new Panel();
            panelDraw = new Panel();
            rbLineWidth15 = new RadioButton();
            rbLineWidth10 = new RadioButton();
            btnColor = new Button();
            rbLineWidth5 = new RadioButton();
            btnClear = new Button();
            SuspendLayout();
            // 
            // panelResult
            // 
            panelResult.BackColor = SystemColors.ButtonFace;
            panelResult.Location = new Point(741, 37);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(600, 600);
            panelResult.TabIndex = 3;
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.ButtonFace;
            panelDraw.Location = new Point(12, 37);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(600, 600);
            panelDraw.TabIndex = 2;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;
            // 
            // rbLineWidth15
            // 
            rbLineWidth15.AutoSize = true;
            rbLineWidth15.Location = new Point(314, 12);
            rbLineWidth15.Name = "rbLineWidth15";
            rbLineWidth15.Size = new Size(97, 19);
            rbLineWidth15.TabIndex = 7;
            rbLineWidth15.TabStop = true;
            rbLineWidth15.Text = "Line Width 15";
            rbLineWidth15.UseVisualStyleBackColor = true;
            // 
            // rbLineWidth10
            // 
            rbLineWidth10.AutoSize = true;
            rbLineWidth10.Location = new Point(211, 12);
            rbLineWidth10.Name = "rbLineWidth10";
            rbLineWidth10.Size = new Size(97, 19);
            rbLineWidth10.TabIndex = 6;
            rbLineWidth10.TabStop = true;
            rbLineWidth10.Text = "Line Width 10";
            rbLineWidth10.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(639, 37);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 4;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // rbLineWidth5
            // 
            rbLineWidth5.AutoSize = true;
            rbLineWidth5.Location = new Point(114, 12);
            rbLineWidth5.Name = "rbLineWidth5";
            rbLineWidth5.Size = new Size(91, 19);
            rbLineWidth5.TabIndex = 5;
            rbLineWidth5.TabStop = true;
            rbLineWidth5.Text = "Line Width 5";
            rbLineWidth5.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(639, 105);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 661);
            Controls.Add(btnClear);
            Controls.Add(rbLineWidth15);
            Controls.Add(rbLineWidth10);
            Controls.Add(btnColor);
            Controls.Add(rbLineWidth5);
            Controls.Add(panelResult);
            Controls.Add(panelDraw);
            Name = "frmPaint";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelResult;
        private Panel panelDraw;
        private RadioButton rbLineWidth15;
        private RadioButton rbLineWidth10;
        private Button btnColor;
        private RadioButton rbLineWidth5;
        private Button btnClear;
    }
}