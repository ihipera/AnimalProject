/* The Animal class
 * contains the fiels, constructor and method that defines an animal
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
   public class Animal
    {
        //fields, also called private data methods
        private string type;
        private string name;
        private int legs;

        // constructor -- assigns initial values no return type
        public Animal(string type, string name, int legs)
        {
            // right hand side is value passed in
            this.type = type;
            this.name = name;
            this.legs = legs;
        }
        // user defined method
        public string ListDetails()
        {
            return ("I am a " + type + ", my name is " + name + " and I have " + legs + " legs.");
        }

    }
}
