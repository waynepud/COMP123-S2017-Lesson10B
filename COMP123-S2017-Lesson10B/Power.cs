using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 18, 2017
 * Description: Demo for lesson 9
 * Version: 0.1 - Added overloaded
 */
namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the power class which will be used as a data type
    /// </summary>
    public class Power
    {
        //Public properties
        public string Name { get; set; }
        public int Rank { get; set; }

        //Constructors

        /// <summary>
        /// This is the main constructor for the power class.
        /// It takes two arguments - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

        // Public overloaded operators
        /// <summary>
        /// This method overloads the > for power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank is greater than rhs.Rank</returns>
        public static bool operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank);
        }

        /// <summary>
        /// This method overloads the < for power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank is less than rhs.Rank</returns>
        public static bool operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank);
        }
    }
}