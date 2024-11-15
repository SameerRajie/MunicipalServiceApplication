using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    internal class Validation
    {
        //---------------------------------------------------------------------------------------------------------------------------------
        public Validation() { }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that a choice was made on the combo box
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Boolean ChoiceMade(int index)
        {
            if (index < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that a string value is not empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Boolean NotEmpty(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that all of the inputs match the requirements
        /// </summary>
        /// <param name="location"></param>
        /// <param name="categoryIndex"></param>
        /// <param name="description"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Boolean ValidState(string location, int categoryIndex, string description, byte[] data)
        {
            // Check if the location, category, and description are valid
            if (NotEmpty(location) && ChoiceMade(categoryIndex) && NotEmpty(description))
            {
                // Check if data is not null and has a length greater than 0
                if (data == null || data.Length == 0)
                {
                    // If no file is attached, treat it as invalid
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }//---------------------------------------------------------------------------------------------------------------------------------
    
    //--------------------------------------------------End of Code------------------------------------------------------------
}
