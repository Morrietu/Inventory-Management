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
    /// Displays form that allows the user to enter part information.
    /// </summary>
    public partial class AddPartForm : Form
    {
        #region Form Initialization Methods
        /// <summary>
        /// Initialized the form
        /// </summary>
        public AddPartForm()
        {
            InitializeComponent();
            inHouseRadioButton.Checked = true;
        }
        #endregion

        #region Private UI Methods
        /// <summary>
        /// Button that saves the part information entered by the user.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Condition that handles the minimum being higher than the maximum 
            if(int.Parse(maxTextBox.Text) < int.Parse(minTextBox.Text))
            {
                return;
            }
            //Condition for selecting the inHouse radio button
            if (inHouseRadioButton.Checked)
            {
                //Creates instance of the InHouse class
                InHouse inHouse = new InHouse(int.Parse(partIDTextBox.Text), nameTextBox.Text, decimal.Parse(priceCostTextBox.Text), int.Parse(inventoryTextBox.Text), int.Parse(minTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(sourceDependentTextBox.Text));
                //Condition that handles the user not entering a value
                if (String.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                //Condition that handles a discrepancy in the partID
                if (int.Parse(partIDTextBox.Text) != inHouse.PartID)
                {
                    MessageBox.Show("Cannot alter Product's ID.");
                    return;

                }
                //Condition that handles the user entering an inventory count higher than the maximum
                if (int.Parse(inventoryTextBox.Text) > int.Parse(maxTextBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level.");
                    return;
                }
                //Condition that handles the miniman stock being higher than the maximum stock
                if (int.Parse(minTextBox.Text) > int.Parse(maxTextBox.Text))
                {
                    MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level.");
                    return;
                }
                //Condition that adds the part if data is valid
                else
                {
                    Inventory.AddPart(inHouse);
                }
            }
            //Condition for selecting the outSourced radio button
            else
            {
                //Creates instance of the Outsourced class
                Outsourced outSourced = new Outsourced(int.Parse(partIDTextBox.Text), nameTextBox.Text, decimal.Parse(priceCostTextBox.Text), int.Parse(inventoryTextBox.Text), int.Parse(minTextBox.Text), int.Parse(maxTextBox.Text), sourceDependentTextBox.Text);
                //Condition that handles the user not entering a value
                if (String.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                //Condition that handles a discrepancy in the productID
                if (int.Parse(partIDTextBox.Text) != outSourced.PartID)
                {
                    MessageBox.Show("Cannot alter Product's ID.");
                    return;

                }
                //Condition that handles the user entering an inventory count higher than the maximum
                if (int.Parse(inventoryTextBox.Text) > int.Parse(maxTextBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level.");
                    return;
                }
                //Condition that handles the miniman stock being higher than the maximum stock
                if (int.Parse(minTextBox.Text) > int.Parse(maxTextBox.Text))
                {
                    MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level.");
                    return;
                }
                //Condition that adds the part if data is valid
                else
                {
                    Inventory.AddPart(outSourced);
                }
            }
            //Closes the form
            this.Close();
        }

        /// <summary>
        /// Button that closes that form without saving any information.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sourceDependentLabel.Text = "Machine ID";
        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sourceDependentLabel.Text = "Company Name";
        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void sourceDependentLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Default
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
