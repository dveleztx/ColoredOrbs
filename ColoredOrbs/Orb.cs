using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredOrbs
{
    internal class Orb
    {
        // Instance Variables
        Color color;
        int size;
        int timesThrown;

        // Constructors
        public Orb(Color color, int size)
        {
            this.color = color;
            this.size = size;
            this.timesThrown = timesThrown;
        }

        public Orb (Color color, int size, int timesThrown)
        {
            this.color = color;
            this.size = size;
            this.timesThrown = timesThrown;
        }

        // Getters
        public int GetSize()
        {
            return size;
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }

        public Color GetColor()
        {
            return color;
        }

        // Setters
        public void SetSize (int size)
        {
            this.size = size;
        }

        public void SetTimesThrown (int timesThrown)
        {
            this.timesThrown = timesThrown;
        }

        // Method
        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                ++timesThrown;
            }
        }
    }
}
