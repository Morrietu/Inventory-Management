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
    /// Displays a form that allows the user to modify product information.
    /// </summary>
    public partial class ModifyProductForm : Form
    {
        #region Form Initialization Methods
        /// <summary>
        /// Constructor that initializes the form
        /// </summary>
        /// <param name="product"></param>
        public ModifyProductForm(Product product)
        {
            InitializeComponent();

            productIDTextBox.Text = Convert.ToString(product.ProductID);
            productNameTextBox.Text = product.Name;
            productInventoryTextBox.Text = Convert.ToString(product.InStock);
            productPriceTextBox.Text = Convert.ToString(product.Price);
            productMinTextBox.Text = Convert.ToString(product.Min);
            productMaxTextBox.Text = Convert.ToString(product.Max);

            allPartsTable.DataSource = Inventory.AllParts;
            associatedPartsTable.DataSource = product.AssociatedParts;
        }
        #endregion

        #region Private UI Methods
        /// <summary>
        /// Button that saves the product information entered by the user.
        /// </summary>
        /// <param name="sender">Default Arguement</param>
        /// <param name="e">Default Arguement</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Condition that checks fields for null values
            if (String.IsNullOrWhiteSpace(productIDTextBox.Text) || String.IsNullOrWhiteSpace(productNameTextBox.Text) || String.IsNullOrWhiteSpace(productPriceTextBox.Text) || String.IsNullOrWhiteSpace(productInventoryTextBox.Text) || String.IsNullOrWhiteSpace(productMinTextBox.Text) || String.IsNullOrWhiteSpace(productMaxTextBox.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }
            //Condition that checks fields for non-integer values
            if (int.Parse(productIDTextBox.Text).GetType() != typeof(int) || int.Parse(productInventoryTextBox.Text).GetType() != typeof(int) || int.Parse(productMinTextBox.Text).GetType() != typeof(int) || int.Parse(productMaxTextBox.Text).GetType() != typeof(int))
            {
                MessageBox.Show("Ensure fields that require integers contain integers.");
                return;
            }
            //Condition that checks the field for a non-decimal value
            if (decimal.Parse(productPriceTextBox.Text).GetType() != typeof(decimal))
            {
                MessageBox.Show("Ensure Price field entry is in decimal format. Example: 0.00.");
                return;
            }
            //Condition that handles the user entering an inventory count higher than the maximum
            if (int.Parse(productInventoryTextBox.Text) > int.Parse(productMaxTextBox.Text))
            {
                MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level.");
                return;
            }
            //Condition that handles the miniman stock being higher than the maximum stock
            if (int.Parse(productMinTextBox.Text) > int.Parse(productMaxTextBox.Text))
            {
                MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level.");
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
                    Inventory.UpdateProduct(int.Parse(productIDTextBox.Text), product);
                }
                //Catch block to handle any exceptions
                catch (Exception ex)
                {
                    MessageBox.Show($"A {ex} error occurred.");
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
        /// Adds the selected part values to the assocaited parts for the product
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void addProductButton_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(productIDTextBox.Text);
            int partID = Convert.ToInt32(allPartsTable.Rows[allPartsTable.CurrentCell.RowIndex].Cells[0].Value);
            Product product = Inventory.LookupProduct(productID);
            Part part = Inventory.LookupPart(partID);
            Inventory.UpdateProduct(productID, product);
            product.AddAssociatedPart(part);
            associatedPartsTable.DataSource = product.AssociatedParts;
        }
        /// <summary>
        /// Deletes the selected part from the associated parts for the product
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            //Try statement to catch deleting non-existent parts
            try
            {
                int partID = Convert.ToInt32(associatedPartsTable.Rows[associatedPartsTable.CurrentCell.RowIndex].Cells[0].Value);
             //   int cellIndex = (int)associatedPartsTable.SelectedRows[associatedPartsTable.CurrentCell.RowIndex].Cells[0].Value;
                //Message box to confirm user action
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.OKCancel);
                {
                    //Condition if the user proceeds
                    if (confirm == DialogResult.OK)
                    {
                        //Deletes the associated parts from the table
                        var rowIndex = associatedPartsTable.CurrentCell.RowIndex;
                        associatedPartsTable.Rows.RemoveAt(rowIndex);
                        //Part removed from product and added back into inventory
                        Inventory.incrementStock(partID);
                    }
                    else return;
                }
            }
            //Informs the user that there was no part to delete.
            catch (NullReferenceException)
            {
                MessageBox.Show("Cannot delete a part that doesn't exist.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a valid part."); //FIXIT: Won't delete selected part
            }
        }
        /// <summary>
        /// Searches the list of available parts
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            //Condition that handles no value
            if (partsSearchBox.TextLength < 1)
            {
                return;
            }
            //Condition if input is valid
            else
            {
                //Try block to contian any exceptions
                try
                {
                    //Iterates through the table
                    foreach (DataGridViewRow row in allPartsTable.Rows)
                    {
                        //Creates Part object and stores row values
                        Part part = (Part)row.DataBoundItem;
                        //Converts and stores search entry
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(partsSearchBox.Text));
                        //Condition to match partID entry with object partID
                        if (userEntry.PartID == part.PartID)
                        {
                            row.Selected = true;
                            allPartsTable.CurrentCell = row.Cells[0];
                            return;
                        }
                        //Condition for if no row is found
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
        private void ModifyProductForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void Form1Load(object sender, EventArgs e)
        {
            
        }
    }
    #endregion
}
