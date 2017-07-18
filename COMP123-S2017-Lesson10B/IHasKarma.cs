using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: This is an interface that defines karma property that must be implemented in any class that subscribes to it
 * Version: 0.1 - Created IHasKarma
 */

namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the IHasKarma interface
    /// </summary>
    public interface IHasKarma
    {
        // PRIVATE INSTANCE VARIABLES --> INTERFACES CANNOT CONTAIN FIELDS (ONLY ACTS AS A CONTRACT BUT CANNOT DEFINE NEW VARIABLES)
        // PUBLIC PROPERTIES
        int Karma { get; set; }
    }
}