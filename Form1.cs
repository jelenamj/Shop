using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string queryItem = "SELECT * FROM item;";
            UsefulMethods.LoadTable(queryItem, dgvItem);

            string queryStore = "SELECT * FROM store;";
            UsefulMethods.LoadTable(queryStore, dgvStore);

            string queryInventory = "SELECT * FROM inventory;";
            UsefulMethods.LoadTable(queryInventory, dgvInventory);

        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            var store = new Store();
            store.Name = txtStoreName.Text;
            store.Address = txtAddress.Text;
            store.City = txtCity.Text;
            Controller.AddStore(store);

            string queryStore = "SELECT * FROM store;";
            UsefulMethods.LoadTable(queryStore, dgvStore);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Name = txtItem.Text;
            item.UnitOfItem = txtUnit.Text;
            Controller.AddItem(item);
            string query = "SELECT * FROM item;";

            UsefulMethods.LoadTable(query, dgvItem);
        }

        private void btnAddtoInventory_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory();
            inventory.Store_Name = txtInventoryStore.Text;
            inventory.Item_Name = txtInventoryItem.Text;
            inventory.Quantity = txtInventoryQuantity.Text;
            Controller.AddToInventory(inventory);

            string queryInventory = "SELECT * FROM inventory;";
            UsefulMethods.LoadTable(queryInventory, dgvInventory);
        }
    }
}
