using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___PA
{
    
    /// <summary>
    /// Primary form that the user is greeted with on application start-up.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Product Initialization
        /// <summary>
        /// Creates product object using default constructor.
        /// </summary>
        Product product = new Product();
        #endregion

        #region Form Initialization Methods
        /// <summary>
        /// Initializes the form upon start-up.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeProductsAndParts();
            RefreshGridViews();
        }
        /// <summary>
        /// Refreshes the parts and products tables.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGridViews();
        }
        /// <summary>
        /// A set of placeholder objects to populate the tables.
        /// </summary>
        public void InitializeProductsAndParts()
        {
            // Placeholder Part objects from the In-House child
            Inventory.AllParts.Add(new InHouse(1, "Premium Paint Color", 300.00m, 3, 1, 10, 123));
            Inventory.AllParts.Add(new InHouse(2, "Leather Interior", 2800.00m, 4, 2, 15, 124));
            Inventory.AllParts.Add(new InHouse(3, "Chrome Wheels", 700.00m, 7, 4, 111, 125));
            Inventory.AllParts.Add(new InHouse(4, "Summer Tires", 500.00m, 14, 4, 15, 126));
            Inventory.AllParts.Add(new InHouse(5, "Spare Tires", 125.00m, 5, 3, 20, 127));
            Inventory.AllParts.Add(new InHouse(6, "Extended Warranty", 4000.00m, 20, 10, 100, 128));
            // Placeholder Part objects from the Outsourced child
            Inventory.AllParts.Add(new Outsourced(7, "Window Tint", 200.00m, 40, 10, 50, "Robert and Son's Tint"));
            Inventory.AllParts.Add(new Outsourced(8, "Paint Protection", 1000.00m, 31, 3, 48, "Excel Detail"));
            // Placeholder Product objects
            Inventory.Products.Add(new Product(1, "Car", 27000.00m, 13, 2, 20));
            Inventory.Products.Add(new Product(2, "Crossover", 29000.00m, 21, 3, 35));
            Inventory.Products.Add(new Product(3, "SUV", 32000.00m, 11, 2, 25));
            Inventory.Products.Add(new Product(4, "Truck", 35000.00m, 12, 3, 30));
            // Placeholder parts associated with placeholder objects
            Inventory.LookupProduct(1).AddAssociatedPart(Inventory.LookupPart(2));
            Inventory.LookupProduct(1).AddAssociatedPart(Inventory.LookupPart(4));
            Inventory.LookupProduct(2).AddAssociatedPart(Inventory.LookupPart(3));
            Inventory.LookupProduct(2).AddAssociatedPart(Inventory.LookupPart(5));
            Inventory.LookupProduct(2).AddAssociatedPart(Inventory.LookupPart(6));
            Inventory.LookupProduct(3).AddAssociatedPart(Inventory.LookupPart(1));
            Inventory.LookupProduct(3).AddAssociatedPart(Inventory.LookupPart(3));
            Inventory.LookupProduct(3).AddAssociatedPart(Inventory.LookupPart(2));
            Inventory.LookupProduct(3).AddAssociatedPart(Inventory.LookupPart(4));
            Inventory.LookupProduct(4).AddAssociatedPart(Inventory.LookupPart(5));
        }
        #endregion

        #region Private UI Component Methods
        /// <summary>
        /// Button hides the Main Form while displaying the Add Parts Form.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void addPartButton_Click(object sender, EventArgs e)
        {
            //Hides the MainForm
            this.Hide();
            //Creates new instance of AddPartForm
            AddPartForm addPartForm = new AddPartForm();
            new AddPartForm().ShowDialog();
            //Shows the MainForm
            this.Show();
        }
        /// <summary>
        /// Button closes the application.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the MainForm
            this.Close();
        }
        /// <summary>
        /// Button hides the Main Form while displaying the Modify Parts Form.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            //Hides the MainForm
            this.Hide();
            //Condition set that selects the ModifyPartsForm based on whether the part is In-House or Outsourced
            if(partsTable.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inhousePart = (InHouse)partsTable.CurrentRow.DataBoundItem;
                new ModifyPartForm(inhousePart).ShowDialog();
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)partsTable.CurrentRow.DataBoundItem;
                new ModifyPartForm(outsourcedPart).ShowDialog();
            }
            //Shows the MainForm
            this.Show();
        }
        /// <summary>
        /// Button hides the Main Form while displaying the Add Products Form.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void addProductButton_Click(object sender, EventArgs e)
        {
            //Hides the MainForm
            this.Hide();
            //Creates new instance of AddProductForm
            new AddProductForm().ShowDialog();
            //Shows the MainForm
            this.Show();
        }
        /// <summary>
        /// Button hides the Main Form while displaying the Modify Products Form.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            //Hides the MainForm
            this.Hide();
            //Creates new instance of ModifyProductForm
            Product product = (Product)productsTable.CurrentRow.DataBoundItem; 
            new ModifyProductForm(product).ShowDialog();
            //Shows the MainForm
            this.Show();
        }
        /// <summary>
        /// Button that deletes table rows as seleted by the user.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void deletePartButton_Click(object sender, EventArgs e)
        {
            //Message box to get user confirmation on action
            DialogResult userConfirm = MessageBox.Show("Are you sure you want to delete the selected items?", "Delete", MessageBoxButtons.OKCancel);
            //Condition for if the user proceeds with the action
            if (userConfirm == DialogResult.OK)
            {
                //Iterates through the rows in partsTable
                foreach (DataGridViewRow row in partsTable.SelectedRows)
                {
                    //Deletes the selected row
                    partsTable.Rows.RemoveAt(row.Index);
                }
            }
                
        }
        /// <summary>
        /// Button that deletes table rows as seleted by the user.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            //Message box to get user confirmation on action
            DialogResult userConfirm = MessageBox.Show("Are you sure you want to delete the selected items?", "Delete", MessageBoxButtons.OKCancel);
            //Condition for if the user proceeds with the action
            if (userConfirm == DialogResult.OK)
            {
                //Stores vales in selected row in Product object
                Product product = (Product)productsTable.CurrentRow.DataBoundItem;
                //Condition that handles the user attempting to delete a product with associated parts
                if(product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has associated parts.  Remove assosicated parts prior to attempting to remove a product.");
                }
                //Condition that executes if the product has no associated parts 
                else
                {
                    //Iterates through the rows in productsTable
                    foreach (DataGridViewRow row in productsTable.SelectedRows)
                    {
                        //Deletes the selected row
                        productsTable.Rows.RemoveAt(row.Index);
                    }
                }
            }
            //Condition for the user not proceeding with the action
            else
            {
                return;
            }
        }
        /// <summary>
        /// Searches the partsTable for the entered partID
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            //condition to handle null input
            if (partsSearchBox.TextLength < 1)
            {
                return;
            }
            //Condition to query the part
            else
            {
                //Try block to handle possible exceptions
                try
                {
                    //Stores the value entered into the searchbox
                    Part query = Inventory.LookupPart(int.Parse(partsSearchBox.Text));
                    //Iterates through the table rows
                    foreach (DataGridViewRow row in partsTable.Rows)
                    {
                        //Stores row values in Part object
                        Part part = (Part)row.DataBoundItem;
                        //Condition matching the partID while also checking for null
                        if (part?.PartID == query.PartID)
                        {
                            //Selects the row if a match is found
                            row.Selected = true;
                            partsTable.CurrentCell = row.Cells[0];
                            return;
                        }
                        //Condition for if no match is found
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                //Catches potential exceptions
                catch
                {
                    
                }
            }
        }

        /// <summary>
        /// Searches the productsTable for the entered productID
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            //condition to handle null input
            if (productsSearchBox.TextLength < 1)
            {
                return;
            }
            //Condition to query the product
            else
            {
                //Try block to handle possible exceptions
                try
                {
                    //Stores the value entered into the searchbox
                    Product query = Inventory.LookupProduct(int.Parse(productsSearchBox.Text));
                    //Iterates through the table rows
                    foreach (DataGridViewRow row in productsTable.Rows)
                    {
                        //Stores row values in Product object
                        Product product = (Product)row.DataBoundItem;
                        //Condition matching the productID while also checking for null
                        if (product?.ProductID == query.ProductID)
                        {
                            //Selects the row if a match is found
                            row.Selected = true;
                            productsTable.CurrentCell = row.Cells[0];
                            return;
                        }
                        //Condition for if no match is found
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                //Catches potential exceptions
                catch
                {
                    
                }
            }
        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void partsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void productsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        // <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Public Helper Methods
        /// <summary>
        /// Refreshes the view of the tables
        /// </summary>
        public void RefreshGridViews()
        {
            partsTable.DataSource = Inventory.AllParts;
            partsTable.ClearSelection();

            productsTable.DataSource = Inventory.Products;
            productsTable.ClearSelection();
        }
        #endregion
    }
}
