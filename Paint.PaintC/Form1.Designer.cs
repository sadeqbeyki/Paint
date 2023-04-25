namespace Paint.PaintC
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
            panelCanvas = new Panel();
            panelDraw = new Panel();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = SystemColors.ButtonFace;
            panelCanvas.Location = new Point(779, 23);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(600, 600);
            panelCanvas.TabIndex = 5;
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.ButtonFace;
            panelDraw.Location = new Point(59, 23);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(600, 600);
            panelDraw.TabIndex = 4;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 647);
            Controls.Add(panelCanvas);
            Controls.Add(panelDraw);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCanvas;
        private Panel panelDraw;
    }
}