﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.PaintA
{
    public partial class frmResult : Form
    {
        public Graphics graphicsResult;

        public frmResult()
        {
            InitializeComponent();
            graphicsResult = panelResult.CreateGraphics();
        }
    }
}
