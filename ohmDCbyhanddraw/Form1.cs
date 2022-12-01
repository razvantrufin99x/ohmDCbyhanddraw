using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ohmDCbyhanddraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public limitexywh limit = new limitexywh(0.0f, 0.0f, 400.0f, 300.0f);

        public void writeDebug(TextBox t, string s)
        {
            t.Text = s;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            unitateDragCtrlDot1.limitele = limit;
            unitateDragCtrlDot2.limitele = limit;
            unitateDragCtrlDot3.limitele = limit;

           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            unitateDragCtrlDot1.verifica();
            unitateDragCtrlDot2.verifica();
            unitateDragCtrlDot3.verifica();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            writeDebug(textBox1, unitateDragCtrlDot1.Left.ToString());
            writeDebug(textBox2, unitateDragCtrlDot1.Top.ToString());

            writeDebug(textBox3, unitateDragCtrlDot2.Left.ToString());
            writeDebug(textBox4, unitateDragCtrlDot2.Top.ToString());

            writeDebug(textBox5, unitateDragCtrlDot3.Left.ToString());
            writeDebug(textBox6, unitateDragCtrlDot3.Top.ToString());
        }
    }
}
