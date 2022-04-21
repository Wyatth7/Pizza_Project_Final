﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza_Project.kiosk;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class OrderCreationPage : Form
    {
        private readonly Kiosk kiosk;

        private readonly string customerId;

        public OrderCreationPage(string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.kiosk = new Kiosk(this.customerId);
            this.dataGridView1.Columns.Add("itemName", "Cart Item");
            this.dataGridView1.Columns.Add("itemQuantity", "Quantity");
            this.dataGridView1.AutoSize = true;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            {
                editButton.Text = "Delete";
                editButton.UseColumnTextForButtonValue = true; //dont forget this line
                editButton.DefaultCellStyle.BackColor = Color.Red;
                editButton.DefaultCellStyle.ForeColor = Color.White;
                editButton.FlatStyle = FlatStyle.Flat;
                this.dataGridView1.Columns.Add(editButton);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var mainSelectionPage = new MainSelectionPage();
            this.Close();
            mainSelectionPage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void OrderCreationPage_Load(object sender, EventArgs e)
        {
            
            this.pictureBox3.ImageLocation = FilePath.GetPath(@"\\images\\full-pizza.jpeg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var buildPizzaForm = new BuildPizzaForm(kiosk.GetCart());
            buildPizzaForm.ShowDialog();
            DisplayGridItems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                System.Diagnostics.Debug.WriteLine(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                EditCartItem(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Refresh();
            }
        }

        private void EditCartItem(string itemName)
        {
            var cart = this.kiosk.GetCart();
            cart.RemoveItem(cart.GetItemId(itemName));
            DisplayGridItems();
        }

        private void DisplayGridItems()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            var (cartItems, cartTotal) = this.kiosk.GetCart().GetCartDetails();
            foreach (var el in cartItems)
            {
                this.dataGridView1.Rows.Add(el.Name, el.Quantity, "edit");
            }
        }
    }
}
