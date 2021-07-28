using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___PA
{
    /// <summary>
    /// Stores parts associated with specific products.
    /// </summary>
    public class Product
    {
        #region Public BindingList
        /// <summary>
        /// A list that stores all parts associated with the product.
        /// </summary>
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        #endregion

        #region Public Properties
        /// <summary>
        /// Stores and retrieves the value for productID.
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// Stores and retrieves the value for name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Stores and retrieves the value for price.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Stores and retrieves the value for inStock.
        /// </summary>
        public int InStock { get; set; }
        /// <summary>
        /// Stores and retrieves the value for min.
        /// </summary>
        public int Min { get; set; }
        /// <summary>
        /// Stores and retrieves the value for max.
        /// </summary>
        public int Max { get; set; }
        #endregion

        #region ctor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Product()
        {

        }
        /// <summary>
        /// Overload Constructor
        /// </summary>
        /// <param name="productID">Sets the productID</param>
        /// <param name="name">Sets the name</param>
        /// <param name="price">Sets the price</param>
        /// <param name="inStock">Sets the inStock</param>
        /// <param name="max">Sets the max</param>
        /// <param name="min">Sets the min</param>
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Adds an associated part to the list.
        /// </summary>
        /// <param name="part">Object of the Part class</param>
        public void AddAssociatedPart(Part part)
        {
            foreach (Part index in AssociatedParts)
            {
                if (index.PartID == part.PartID)
                {
                    MessageBox.Show("That part is already associated with the selected product.");
                    return;
                }
            }
            AssociatedParts.Add(part);
            //Decrements the inStock variable by 1
            if (part.InStock > 0)
            {
                part.InStock -= 1;
            }
        }
        /// <summary>
        /// Removes an associated part from the list.
        /// </summary>
        /// <param name="partID">Variable of the Part class</param>
        /// <returns></returns>
        public bool RemoveAssociatedPart(int partID)
        {
            //sets the initial check value to false
            bool check = false;
            //interates through all objects the list 
            foreach (Part index in AssociatedParts)
            {
                //condition for finding equivalent partID
                if (index.PartID == partID)
                {
                    //if partID found, removes current object
                    AssociatedParts.Remove(index);
                    //check set to true
                    return check = true;
                }
                //default condition if no equivalent partID found
                else
                {
                    //check set to false
                    check = false;
                }
            }
            //condition for if part isn't found in list
            if (check == false)
            {
                //informs the user
                MessageBox.Show("No part by that ID was found.");
            }
            //returns the bool value
            return check;
        }
        /// <summary>
        /// Searches for an associated part from the list.
        /// </summary>
        /// <param name="partID">Variable of the Part class</param>
        /// <returns></returns>
        public Part LookupAssociatedPart(int partID)
        {
            //sets the initial check value to false
            bool check = false;

            //interates through all objects the list 
            foreach (Part index in AssociatedParts)
            {
                //condition for finding equivalent partID
                if (index.PartID == partID)
                {
                    //sets check to true
                    check = true;
                    //Returns the current object
                    return index;
                }
                //default condition if no equivalent partID found
                else
                {
                    //check set to false
                    check = false;
                }
            }
            //condition for if part isn't found in list
            if (check == false)
            {
                //informs the user
                MessageBox.Show("No part by that ID was found.");
            }
            //Returns null of equivalent partID not found
            return null;
        }
        #endregion
    }
}
