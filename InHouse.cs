using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___PA
{
    /// <summary>
    /// Inherits from the Part class to store information about in-house parts.
    /// </summary>
    public class InHouse : Part
    {
        #region Public Properties
        /// <summary>
        /// Stores and retrieves machineID variable.
        /// </summary>
        public int MachineID { get; set; }
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
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max) : base()
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="partID">Sets the partID</param>
        /// <param name="name">Sets the name</param>
        /// <param name="price">Sets the price</param>
        /// <param name="inStock">Sets the stock</param>
        /// <param name="max">Sets the max</param>
        /// <param name="min">Sets the min</param>
        /// <param name="machineID">Sets the machineID</param>
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) : base()
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
        #endregion
    }
}
