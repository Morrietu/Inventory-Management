using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___PA
{
    /// <summary>
    /// Inherits from the Part class to store information about outsourced parts.
    /// </summary>
    public class Outsourced : Part
    {
        #region Public Properties
        /// <summary>
        /// Stores and retrieves companyName variable.
        /// </summary>
        public string CompanyName { get; set; }
        #endregion

        #region ctor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="partID">Sets the partID</param>
        /// <param name="name">Sets the name</param>
        /// <param name="price">Sets the price</param>
        /// <param name="inStock">Sets the stock</param>
        /// <param name="max">Sets the max</param>
        /// <param name="min">Sets the min</param>
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max) : base()
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="partID">Sets the partID</param>
        /// <param name="name">Sets the name</param>
        /// <param name="price">Sets the price</param>
        /// <param name="inStock">Sets the stock</param>
        /// <param name="max">Sets the max</param>
        /// <param name="min">Sets the min</param>
        /// <param name="companyName">Sets the companyName</param>
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName) : base()
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
        #endregion
    }
}
