using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 20, 2017
 * Description: This is the AntiHero class AND IMPLEMENTS BOTH THE IHasKarma and IHasMalice
 * Version: 0.1 - created the antihero class
 */

namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the antihero class
    /// </summary>
    public class AntiHero : SuperHuman, IHasKarma, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;
        private int _malice;

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

        /// <summary>
        /// This is the main constructor
        /// It takes three arguments - name (string) - karma (int) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        /// <param name="malice"></param>
        // CONSTRUCTORS
        public AntiHero(string name, int karma, int malice) : base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }


        // PRIVATE METHODS

        // PUBLIC METHODS

    }
}