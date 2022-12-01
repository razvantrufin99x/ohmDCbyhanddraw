using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ohmDCbyhanddraw
{
    public partial class unitateDragCtrlDot : UserControl
    {
        public unitateDragCtrlDot()
        {
            InitializeComponent();
        }

        public limitexywh limitele = new limitexywh();
        public int ismd = 0;
        public float setval = 0;

        Form1 f = null;

        public void fsetval(float sv)
        {
            setval = sv;
        }

        public float fgetval()
        {
            return setval;
        }

        private void unitateDragCtrlDot_Load(object sender, EventArgs e)
        {
            try {
                f = (Form1)ParentForm;
            }
            catch { }
        }

        private void unitateDragCtrlDot_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
          
        }

        private void unitateDragCtrlDot_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
            
        }
        public bool verifcalimitele(float px, float py)
        {
            bool t = false;

            if (px > limitele.x  && py > limitele.y && px < limitele.w && py < limitele.h)
            {
                t = false;
            }
            else {
                t = true;
            }
            return t;
        }

        public void verifica()
        {
            if (limitele.x > Left)
            {
                Left = (int)limitele.x + 5;
            }
            else if (limitele.y > Top)
            {
                Top = (int)limitele.y + 5;
            }
            else if (limitele.w < Left)
            {
                Left = (int)limitele.w - 5;
            }
            else if (limitele.h < Top)
            {
                Top = (int)limitele.h - 5;
            }
           
        }


            private void unitateDragCtrlDot_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {

               
                    Left += e.X;
                    Top += e.Y;
                    
                
                
            }
           
        }

            private void unitateDragCtrlDot_MouseLeave(object sender, EventArgs e)
            {
                verifica();
            }
    }
}
