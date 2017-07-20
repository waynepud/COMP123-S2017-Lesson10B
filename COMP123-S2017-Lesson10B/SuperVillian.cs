using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: This is the SuperHero class which inherits from the SuperHuman class and implements the IHasMalice Interface
 * Version: 0.2 - added constructor to SuperVillain class
 */

namespace COMP123_S2017_Lesson10B
{
    public class SuperVillian : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }

        //CONSTRUCTORS
        public SuperVillian(string name, int malice) : base(name)
        {
            this.Malice = malice;
        }

        //public methods
        //public void Train()
        //{
        //    Console.WriteLine("Method not implemented");
        //}
    }
}