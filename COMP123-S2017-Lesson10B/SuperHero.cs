using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: This is the SuperHero class which inherits from the SuperHuman class and implements the IHasKarma Interface
 * Version: 0.3 - refactored - removed ITrainable interface and used override method
 */

namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public sealed class SuperHero : SuperHuman, IHasKarma
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;

        // PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the superhero class, takes one argument name
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma) : base(name)
        {
            this.Karma = karma;

        }

        public override void Train()
        {
            Console.WriteLine("Method not implemented");
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}