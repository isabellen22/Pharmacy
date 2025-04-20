using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    internal class frmBackground : Form
    {
        public frmBackground()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.BackColor = ColorTranslator.FromHtml("#ffffff");
        }

        private void InitializeComponent()
        {
        }
    }
    }