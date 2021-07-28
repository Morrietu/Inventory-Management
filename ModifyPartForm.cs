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
    public partial class ModifyPartForm : Form
    {
        #region Form Initialization Methods
        /// <summary>
        /// Initializes the form
        /// </summary>
        public ModifyPartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor for In-House objects
        /// </summary>
        /// <param name="inhouse">Object of the InHouse class</param>
        public ModifyPartForm(InHouse inhouse)
        {
            InitializeComponent();

            partIDTextBox.Text = Convert.ToString(inhouse.PartID);
            nameTextBox.Text = inhouse.Name;
            inventoryTextBox.Text = Convert.ToString(inhouse.InStock);
            priceCostTextBox.Text = Convert.ToString(inhouse.Price);
            minTextBox.Text = Convert.ToString(inhouse.Min);
            maxTextBox.Text = Convert.ToString(inhouse.Max);
            sourceDependentTextBox.Text = Convert.ToString(inhouse.MachineID);
            sourceDependentLabel.Text = "Machine ID";
            inHouseRadioButton.Checked = true;
        }
        /// <summary>
        /// Constructor for Outsourced objects
        /// </summary>
        /// <param name="outsourced">Object of the Outsourced class</</param>
        public ModifyPartForm(Outsourced outsourced)
        {
            InitializeComponent();

            partIDTextBox.Text = Convert.ToString(outsourced.PartID);
            nameTextBox.Text = outsourced.Name;
            inventoryTextBox.Text = Convert.ToString(outsourced.InStock);
            priceCostTextBox.Text = Convert.ToString(outsourced.Price);
            minTextBox.Text = Convert.ToString(outsourced.Min);
            maxTextBox.Text = Convert.ToString(outsourced.Max);
            sourceDependentTextBox.Text = Convert.ToString(outsourced.CompanyName);
            sourceDependentLabel.Text = "Company Name";
            outsourcedRadioButton.Checked = true;
        }
        #endregion

        #region Private UI Events
        /// <summary>
        /// Button that saves the part information entered by the user.
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Condition for selecting the inHouse radio button
            if (inHouseRadioButton.Checked)
            {
                inHouseRadioButton.Checked = true;
                //Following two lines attempt to parse a string to a integer
                int machineID;
                bool success = Int32.TryParse(sourceDependentTextBox.Text, out machineID);
                //Condition that handles a failed attempt to parse to an integer
                if (success != true)
                {
                    MessageBox.Show("Value must be an integer.");
                    return;
                }
                //Condition that checks fields for null values
                if (String.IsNullOrWhiteSpace(partIDTextBox.Text) || String.IsNullOrWhiteSpace(nameTextBox.Text) || String.IsNullOrWhiteSpace(priceCostTextBox.Text) || String.IsNullOrWhiteSpace(inventoryTextBox.Text) || String.IsNullOrWhiteSpace(minTextBox.Text) || String.IsNullOrWhiteSpace(maxTextBox.Text))
                {
                    MessageBox.Show("Fields cannot be empty.");
                    return;
                }
                //Condition that checks fields for non-integer values
                if (int.Parse(partIDTextBox.Text).GetType() != typeof(int) || int.Parse(inventoryTextBox.Text).GetType() != typeof(int) || int.Parse(minTextBox.Text).GetType() != typeof(int) || int.Parse(maxTextBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Ensure fields that require integers contain integers.");
                    return;
                }
                //Condition that checks the field for a non-decimal value
                if (decimal.Parse(priceCostTextBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Ensure Price field entry is in decimal format. Example: 0.00.");
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
                //Condition that modifies the part if data is valid
                else
                {
                    //Try block to contian any exceptions
                    try
                    {
                        //Creates instance of the InHouse class
                        var inHouse = new InHouse(int.Parse(partIDTextBox.Text), nameTextBox.Text, decimal.Parse(priceCostTextBox.Text), int.Parse(inventoryTextBox.Text), int.Parse(minTextBox.Text), int.Parse(maxTextBox.Text), machineID);
                        //Passes the inHouse object into the method call
                        Inventory.UpdatePart(int.Parse(partIDTextBox.Text), inHouse);
                    }
                    //Catch block to handle any exceptions
                    catch(Exception ex)
                    {
                        MessageBox.Show($"A {ex} error occured.");
                        throw; 
                    }
                    //Closes the application
                    this.Close();
                }
            }
            //Condition for selecting the outSourced radio button
            else
            {
                outsourcedRadioButton.Checked = true;
                //Condition that checks fields for null values
                if (String.IsNullOrWhiteSpace(partIDTextBox.Text) || String.IsNullOrWhiteSpace(nameTextBox.Text) || String.IsNullOrWhiteSpace(priceCostTextBox.Text) || String.IsNullOrWhiteSpace(inventoryTextBox.Text) || String.IsNullOrWhiteSpace(minTextBox.Text) || String.IsNullOrWhiteSpace(maxTextBox.Text) || String.IsNullOrWhiteSpace(sourceDependentTextBox.Text))
                {
                    MessageBox.Show("Fields cannot be empty.");
                    return;
                }
                //Condition that checks fields for non-integer values
                if (int.Parse(partIDTextBox.Text).GetType() != typeof(int) || int.Parse(inventoryTextBox.Text).GetType() != typeof(int) || int.Parse(maxTextBox.Text).GetType() != typeof(int) || int.Parse(minTextBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Ensure fields that require integers contain integers.");
                    return;
                }
                //Condition that checks the field for a non-decimal value
                if (decimal.Parse(priceCostTextBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Ensure Price field entry is in decimal format. Example: 0.00.");
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
                //Condition that modifies the part if data is valid
                else
                {
                    //Try block to contian any exceptions
                    try
                    {
                        var outSourced = new Outsourced(int.Parse(partIDTextBox.Text), nameTextBox.Text, decimal.Parse(priceCostTextBox.Text), int.Parse(inventoryTextBox.Text), int.Parse(minTextBox.Text), int.Parse(maxTextBox.Text), sourceDependentTextBox.Text); 
                        Inventory.UpdatePart(int.Parse(partIDTextBox.Text), outSourced);
                    }
                    //Catch block to handle any exceptions
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A {ex} error occured.");
                        throw;
                    }
                    //Closes the application
                    this.Close();

                }
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
        /// Sets the label text for InHouse objects
        /// </summary>
        /// <param name="sender">Default arguement</param>
        /// <param name="e">Default arguement</param>
        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sourceDependentLabel.Text = "Machine ID";
        }
        /// <summary>
        /// Sets the label text for Outsourced objects
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
        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
