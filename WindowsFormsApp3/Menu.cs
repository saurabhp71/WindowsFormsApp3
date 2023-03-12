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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Type = cmbbxType.Text;
            string Menu = cmbbxMenu.Text;
            string Price = txtbxPrice.Text;

            frmOrder Order = new frmOrder(Type, Menu, Price);
            Order.Show();
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxMenu.Items.Clear();
            if(cmbbxType.Text == "Maharastrian")
            {
                cmbbxMenu.Items.Add("Bhaji");
                cmbbxMenu.Items.Add("Vada Pav");
                cmbbxMenu.Items.Add("Misal");
                cmbbxMenu.Items.Add("Pav Bhaji");
            }
            if(cmbbxType.Text == "Gujarati")
            {
                cmbbxMenu.Items.Add("Khakara");
                cmbbxMenu.Items.Add("Thepala");
                cmbbxMenu.Items.Add("Fapada-Jalebi");
                cmbbxMenu.Items.Add("Gathiya");
            }
            if(cmbbxType.Text == "South Indian")
            {
                cmbbxMenu.Items.Add("Masala Dosa");
                cmbbxMenu.Items.Add("Upama");
                cmbbxMenu.Items.Add("Idali");
                cmbbxMenu.Items.Add("Uttapa");

            }
        }

        private void cmbbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MenuName = cmbbxMenu.SelectedItem.ToString();
            if ( MenuName== "Bhaji")
            {
                txtbxPrice.Text = "25";
            }
            if (MenuName == "Vada Pav")
            {
                txtbxPrice.Text = "20";
            }
            if (MenuName == "Misal")
            {
                txtbxPrice.Text = "80";
            }
            if (MenuName == "Pav Bhaji")
            {
                txtbxPrice.Text = "90";
            }
            if (MenuName == "Khakara")
            {
                txtbxPrice.Text = "100";
            }
            if (MenuName == "Thepala")
            {
                txtbxPrice.Text = "60";
            }
            if (MenuName == "Fapada-Jalebi")
            {
                txtbxPrice.Text = "200";
            }
            if (MenuName == "Gathiya")
            {
                txtbxPrice.Text = "180";
            }
            if (MenuName == "Masala Dosa")
            {
                txtbxPrice.Text = "150";
            }
            if (MenuName == "Upama")
            {
                txtbxPrice.Text = "30";
            }
            if (MenuName == "Idali")
            {
                txtbxPrice.Text = "35";
            }
            if (MenuName == "Uttapa")
            {
                txtbxPrice.Text = "60";
            }

        }
    }
}
