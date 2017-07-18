using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 11, 2017
 * Description: This is the SuperHuman class that extends the human class
 * Version: 0.6 - added stub method (stub = not implemented method) displayskills to conform to human abstract superclass
 */
namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instance variables(field)
        private List<Power> _powers;


        //Public properties
        public List<Power> Powers
        {
            get
            {
                return this._powers; //this returns a reference
            }
        }


        //Constructors

        /// <summary>
        /// This is the main constructors for the SuperHuman class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name) : base(name)
        {
            this._initialize();
        }


        //Private methods

        /// <summary>
        /// This method intitialzes, instantiates and assigns values to the property
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>(); //creates an empty list
        }

        /// <summary>
        /// This private method returns the index of the power name in the power list
        /// if not found, returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns>returns the index of the power list by name</returns>
        private int _getPowerIndex(string name)
        {
            int index = 0;

            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }

                index++;

                if (this.Powers.Count == index)
                {
                    index = -1; //this means that we did not find the power in the list
                }               
            }
            return index;
        }

        /// <summary>
        /// This method adds a power to the Power List.
        /// It takes two parameters - name(string) - rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        //Public methods

        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        /// <summary>
        /// This method displays each of the powers stored in the powers list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Rank);
            }
        }
        // public overriden methods
        /// <summary>
        /// Overriden the built in ToStringMethod
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "=========================================\n";
            outputString += "SuperHuman Name: " + this.Name + "\n";
            outputString += "=========================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " | Rank: " + power.Rank + "\n";
            }

            outputString += "=========================================\n";

            return outputString;
        }

        /// <summary>
        /// This is the displayskills method, needs to be implemented
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not implemented");
        }

    }
}