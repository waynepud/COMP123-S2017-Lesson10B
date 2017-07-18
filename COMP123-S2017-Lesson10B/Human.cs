using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Name: Wayne Pud
 * Date: July 11, 2017
 * Description: This is the Abstract Human Class
 * Version: 0.2 - Added public abstract method displayskills
 */

namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the abstract human class
    /// </summary>
    public abstract class Human
    {
        //private instance variables (Fields)
        private string _name;

        //public properties
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// This is the main constructor for the human class
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        //constructors ----------
        public Human(string name)
        {
            this.Name = name;
        }


        //private methods

        //public methods

        //public abstract methods
        public abstract void DisplaySkills();
    }
}