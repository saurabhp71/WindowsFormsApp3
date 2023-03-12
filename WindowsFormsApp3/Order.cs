using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmOrder : Form
    {
        public frmOrder(string type, string menu, string price)
        {
            InitializeComponent();
            
            this.Text = type;
            txtbxMenuName.Text = menu;
            txtbxMenuPrice.Text = price;

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
