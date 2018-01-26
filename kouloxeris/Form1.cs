using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kouloxeris
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            //τα κανω disable για να τα ενεργοποιησει ο χρηστης οποτε θελει με το πατημα ενος κουμπιου
            orange1.Visible = false;
            orange2.Visible = false;
            orange3.Visible = false;
            orange4.Visible = false;
            banana4.Visible = false;
            cherry4.Visible = false;
            seven4.Visible = false;
            grape4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //βαζει περισσοτερες στηλες
        private void button2_Click(object sender, EventArgs e)
        {
           
            orange1.Visible =true; 
            orange2.Visible =true; 
            orange3.Visible =true; 
            orange4.Visible =true; 
            banana4.Visible =true;
            cherry4.Visible = true;
            seven4.Visible = true;
            grape4.Visible = true;
        }
    }
}
