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
    /// Displays a form that allows the user to enter product information.
    /// </summary>
    public partial class AddProductForm : Form
    {
        #region Form Initialization Methods
        /// <summary>
        /// Creates new Product object
        /// </summary>
        Product product = new Product();
        /// <summary>
        /// Constructor that initializes the form
        /// </summary>
        public AddProductForm()
        {
            InitializeComponent();
            allPartsTable.DataSource = Inventory.AllParts;
            associatedPartsTable.DataSource = product.AssociatedParts; 
        }
        #endregion

        #region Private UI Methods
        /// <summary>
        /// Button that saves the product information entered by the user.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Condition that checks fields for null values
            if (String.IsNullOrWhiteSpace(productIDTextBox.Text) || String.IsNullOrWhiteSpace(productNameTextBox.Text) || String.IsNullOrWhiteSpace(productPriceTextBox.Text) || String.IsNullOrWhiteSpace(productInventoryTextBox.Text) || String.IsNullOrWhiteSpace(productMinTextBox.Text) || String.IsNullOrWhiteSpace(productMaxTextBox.Text))
            {
                MessageBox.Show("Fields cannot be empty");
                return;
            }
            //Condition that checks fields for non-integer values
            if (int.Parse(productIDTextBox.Text).GetType() != typeof(int) || int.Parse(productInventoryTextBox.Text).GetType() != typeof(int) || int.Parse(productMinTextBox.Text).GetType() != typeof(int) || int.Parse(productMaxTextBox.Text).GetType() != typeof(int))
            {
                MessageBox.Show("Ensure fields that require integers contain integers");
                return;
            }
            //Condition that checks the field for a non-decimal value
            if (decimal.Parse(productPriceTextBox.Text).GetType() != typeof(decimal))
            {
                MessageBox.Show("Ensure Price field entry is in decimal format. Example: 0.00");
                return;
            }
            //Condition that handles the user entering an inventory count higher than the maximum
            if (int.Parse(productInventoryTextBox.Text) > int.Parse(productMaxTextBox.Text))
            {
                MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level");
                return;
            }
            //Condition that handles the miniman stock being higher than the maximum stock
            if (int.Parse(productMinTextBox.Text) > int.Parse(productMaxTextBox.Text))
            {
                MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level");
                return;
            }
            //Condition that modifies the product if data is valid
            else
            {
                //Try block to contian any exceptions
                try
                {
                    //Creates instance of the Product class
                    Product product = new Product(int.Parse(productIDTextBox.Text), productNameTextBox.Text, decimal.Parse(productPriceTextBox.Text), int.Parse(productInventoryTextBox.Text), int.Parse(productMinTextBox.Text), int.Parse(productMaxTextBox.Text));
                    //Try block to contian any exceptions
                    try
                    {
                        //Iterates through the associatedPartsTable
                        foreach (DataGridViewRow row in associatedPartsTable.Rows)
                        {
                            //Stores row value in Part object
                            Part associatedPart = (Part)row.DataBoundItem;
                            //Passes the Part object into method call
                            product.AssociatedParts.Add(associatedPart);
                        }
                    }
                    //Catch block to handle any exceptions
                    catch
                    {

                    }
                    //Adds the Product object
                    Inventory.AddProduct(product);
                }
                //Catch block to handle any exceptions
                catch (Exception ex)
                {
                    MessageBox.Show($"A {ex} error occured.");
                    throw;
                }
                //Closes the form
                this.Close();
            }
        }
        /// <summary>
        /// Button that closes that form without saving any information.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Adds the selected part to the assocaited parts for the product
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void addProductButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)allPartsTable.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(part);
        }
        /// <summary>
        /// Deletes the selected part from the associated parts for the product
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            //Message box to confirm user action
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this Product?", "Delete", MessageBoxButtons.OKCancel);
            //Condition if the user proceeds
            if (confirm == DialogResult.OK)
            {
                //Iterates through the associatedPartsTable
                foreach (DataGridViewRow row in associatedPartsTable.SelectedRows)
                {
                    //Removes the selected row from the table
                    associatedPartsTable.Rows.RemoveAt(row.Index);
                }
            }
        }
        /// <summary>
        /// Searches for the part in the list of available parts
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            //Condition to handle a null entry
            if (partsSearchBox.TextLength < 1)
            {
                return;
            }
            //Condition for a valid entry
            else
            {
                //Try block to contian any exceptions
                try
                {
                    //Iterates through the table
                    foreach (DataGridViewRow row in allPartsTable.Rows)
                    {
                        //Stores the row values into Part object
                        Part part = (Part)row.DataBoundItem;
                        //Converts and stores the user entry into the Part object
                        Part match = Inventory.LookupPart(Convert.ToInt32(partsSearchBox.Text));
                        //Condition the matches the value while checking for null
                        if (part?.PartID == match.PartID)
                        {
                            row.Selected = true;
                            allPartsTable.CurrentCell = row.Cells[0];
                            return;
                        }
                        //Condition if no matching rows are found
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                //Catch block to handle any exceptions
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
        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
