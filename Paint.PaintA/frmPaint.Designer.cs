namespace Paint.PaintA
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
            SuspendLayout();
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.ButtonFace;
            panelDraw.Location = new Point(30, 30);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(800, 600);
            panelDraw.TabIndex = 0;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(872, 30);
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
            rbLineWidth5.Location = new Point(853, 140);
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
            rbLineWidth10.Location = new Point(853, 193);
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
            rbLineWidth15.Location = new Point(853, 247);
            rbLineWidth15.Name = "rbLineWidth15";
            rbLineWidth15.Size = new Size(97, 19);
            rbLineWidth15.TabIndex = 3;
            rbLineWidth15.TabStop = true;
            rbLineWidth15.Text = "Line Width 15";
            rbLineWidth15.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1008, 729);
            Controls.Add(rbLineWidth15);
            Controls.Add(rbLineWidth10);
            Controls.Add(btnColor);
            Controls.Add(rbLineWidth5);
            Controls.Add(panelDraw);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDraw;
        private Button btnColor;
        private RadioButton rbLineWidth5;
        private RadioButton rbLineWidth10;
        private RadioButton rbLineWidth15;
    }
}