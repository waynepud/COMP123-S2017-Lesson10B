using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 20, 2017
 * Description: This is an interface that defines malice property that must be implemented in any class that subscribes to it
 * Version: 0.1 - Created IHasMalice
 */

namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the IHasMalice interface
    /// </summary>
    public interface IHasMalice
    {
        // public properties
        int Malice { get; set; }

    }
}