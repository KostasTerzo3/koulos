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
        //win=μεταβλητη για το αν ο χρηστης εχει κερδισει 
        //coin=τα κερματα που εχει πονταρει ο παιχτης
        //coins=τα συνολικα κερματα που εχουν δωθει απο τους παιχτες
        //wincoins=τα coins που εχω δωθει στους παιχτες
        int coin,coins,wincoins=0;
        // int win=1;
        bool flag;
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
            label4.Text = coin.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (banana1.Visible == true)
            {
                banana1.Visible = false;
            }
            else if (banana1.Visible == false)
            {
                banana1.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            flag = false;
           // timer1.Enabled = false;
           // timer2.Enabled = false;
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

        //κουμπι play
        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            timer1.Enabled = true;
            timer2.Enabled = true;

            Random r = new Random();
            int interval1 = r.Next(250,500) ;
            timer1.Interval = interval1;

            int interval2 = r.Next(3000,7000);
            label5.Text=(((interval2/1000).ToString()+" δευτερολεπτα χι χι"));

            
            
            /*coin= 5;
            coins = coins + coin;
            wincoins = wincoins + coins;
            label2.Text = coins.ToString();
       */
        }
    }
}
