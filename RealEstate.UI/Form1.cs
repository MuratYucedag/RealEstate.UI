using RealEstate.DataAccessLayer.ConnectionUrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLConnectionUrl s = new SQLConnectionUrl();
            //label1.Text = s.ConnectionURL();
            s.ConnectionURL();
            s.sayi1 = 20;
        }
    }
}
