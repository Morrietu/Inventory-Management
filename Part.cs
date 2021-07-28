using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___PA
{
    /// <summary>
    /// Abstract class to store parts when inherited by a child class.
    /// </summary>
    public abstract class Part
    {
        #region Public Properties
        /// <summary>
        /// Stores and retrieves the partID value.
        /// </summary>
        public int PartID { get; set; }
        /// <summary>
        /// Stores and retrieves the name value.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Stores and retrieves the price value.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Stores and retrieves the inStock value.
        /// </summary>
        public int InStock { get; set; }
        /// <summary>
        /// Stores and retrieves the min value.
        /// </summary>
        public int Min { get; set; }
        /// <summary>
        /// Stores and retrieves the max value.
        /// </summary>
        public int Max { get; set; }
        #endregion

        #region ctor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Part()
        {
           
        }
        #endregion
    }
}
