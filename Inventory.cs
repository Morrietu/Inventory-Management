using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___PA
{
    /// <summary>
    /// Stores and manipulates items in inventory lists.
    /// </summary>
    public class Inventory
    {
        #region Form
        /// <summary>
        /// Instantiates MainForm
        /// </summary>
        MainForm mainForm = new MainForm();
        #endregion

        #region Public BindingLists
        /// <summary>
        /// Stores all products in a static list.
        /// </summary>
        public static BindingList<Product> Products = new BindingList<Product>();
        /// <summary>
        /// Stores all parts in a static list.
        /// </summary>
        public static BindingList<Part> AllParts = new BindingList<Part>();
        #endregion

        #region Public Part Methods
        /// <summary>
        /// Adds a part to the list.
        /// </summary>
        /// <param name="part">Object of the Part class</param>
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        /// <summary>
        /// Deletes a part from the list
        /// </summary>
        /// <param name="part">Object of the Part class</param>
        /// <returns></returns>
        public static bool DeletePart(Part part)
        {
            //sets the initial check value to false
            bool check = false;
            //interates through all objects the list 
            foreach (Part index in AllParts)
            {
                //condition for finding equivalent partID
                if (part.PartID == index.PartID)
                {
                    //if partID found, removes current object
                    AllParts.Remove(index);
                    //check set to true
                    check = true;
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
        /// Searches for a part in the list
        /// </summary>
        /// <param name="partID">Variable of the Part class</param>
        /// <returns></returns>
        public static Part LookupPart(int partID)
        {
            //sets the initial check value to false
            bool check = false;

            //interates through all objects the list 
            foreach (Part index in AllParts)
            {
                //condition for finding equivalent partID
                if (partID == index.PartID)
                {
                    //check set to true
                    check = true;
                    //returns the object after finding equivalent partID
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
            //if no equivalent partID found, returns  null
            return null;
        }
        /// <summary>
        /// Updates a part in the list
        /// </summary>
        /// <param name="partID">Variable of the Part class</param>
        /// <param name="part">Object of the Part class</param>
        public static void UpdatePart(int partID, Part part)
        {
            //sets the initial check value to false
            bool check = false;
            //interates through all objects the list 
            foreach (Part index in AllParts)
            {
                //condition for finding equivalent partID
                if (index.PartID == partID)
                {
                    //check set to true
                    check = true;
                    AllParts.Remove(index);
                    AllParts.Add(part);
                    return;
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
        }
        #endregion

        #region Public Product Methods
        /// <summary>
        /// Adds a product to the list.
        /// </summary>
        /// <param name="product">Object of the Product class</param>
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        /// <summary>
        /// Removes a product from the list.
        /// </summary>
        /// <param name="productID">Variable of the Product class</param>
        /// <returns></returns>
        public static bool RemoveProduct(int productID)
        {
            //sets the initial check value to false
            bool check = false;
            //interates through all objects the list 
            foreach (Product index in Products)
            {
                //condition for finding equivalent productID
                if (productID == index.ProductID)
                {
                    //if productID found, removes current object
                    Products.Remove(index);
                    //check set to true
                    check = true;
                }
                //default condition if no equivalent productID found
                else
                {
                    //check set to false
                    check = false;
                }
            }
            //condition for if product isn't found in list
            if (check == false)
            {
                //informs the user
                MessageBox.Show("No product by that ID was found.");
            }
            //returns the bool value
            return check;
        }
        /// <summary>
        /// Searches for a product in the list.
        /// </summary>
        /// <param name="productID">Variable of the Product class</param>
        /// <returns></returns>
        public static Product LookupProduct(int productID)
        {
            //sets the initial check value to false
            bool check = false;

            //interates through all objects the list 
            foreach (Product index in Products)
            {
                //condition for finding equivalent productID
                if (index.ProductID == productID)
                {
                    //check set to true
                    check = true;
                    //returns the object after finding equivalent productID
                    return index;
                }
                //default condition if no equivalent productID found
                else
                {
                    //check set to false
                    check = false;
                }
            }
            //condition for if product isn't found in list
            if (check == false)
            {
                //informs the user
                MessageBox.Show("No product by that ID was found.");
            }
            //if no equivalent productID found, returns  null
            return null;
        }
        /// <summary>
        /// Updates a product in the list.
        /// </summary>
        /// <param name="productID">Variable of the Product class</param>
        /// <param name="product">Object of the Product class</param>
        public static void UpdateProduct(int productID, Product product)
        {
            //sets the initial check value to false
            bool check = false;
            //interates through all objects the list 
            foreach (Product index in Products)
            {
                //condition for finding equivalent productID
                if (index.ProductID == productID)
                {
                    //check set to true
                    check = true;
                    //if equivalent productID found, sets the new values for current object
                    index.Name = product.Name;
                    index.Price = product.Price;
                    index.InStock = product.InStock;
                    index.Min = product.Min;
                    index.Max = product.Max;
                    return;
                }
                //default condition if no equivalent productID found
                else
                {
                    //check set to false
                    check = false;
                }
            }
            //condition for if product isn't found in list
            if (check == false)
            {
                //informs the user
                MessageBox.Show("No product by that ID was found.");
            }
        }
        #endregion

        #region Public Helper Methods
        /// <summary>
        /// Increments the value of inStock for the selected object
        /// </summary>
        /// <param name="cellIndex"></param>
        public static void incrementStock(int cellIndex)
        {
            //interates through all objects the list 
            foreach (Part index in AllParts)
            {
                //condition for finding equivalent partID
                if (cellIndex == index.PartID)
                {
                    //Increments the inStock value
                        index.InStock += 1;
                }
            }
        }
        #endregion
    }
}
