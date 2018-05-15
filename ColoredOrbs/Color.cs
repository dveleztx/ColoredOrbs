using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredOrbs
{
    internal class Color
    {
        // Instance Variables
        int blue;
        int green;
        int red;
        int alpha;

        // Constructors
        public Color(int blue, int green, int red)
        {
            this.blue = blue;
            this.green = green;
            this.red = red;
            this.alpha = 255;
        }

        public Color (int blue, int green, int red, int alpha)
        {
            this.blue = blue;
            this.green = green;
            this.red = red;
            this.alpha = alpha;
        }

        // Getters
        public int GetBlue()
        {
            return blue;
        }

        public int GetGreen()
        {
            return green;
        }

        public int GetRed()
        {
            return red;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        public float GetGrayScale()
        {
            return (float)(blue + green + red) / 3;
        }

        // Setters
        public void SetBlue (int blue)
        {
            this.blue = blue;
        }

        public void SetGreen (int green)
        {
            this.green = green;
        }

        public void SetRed (int red)
        {
            this.red = red;
        }

        public void SetAlpha (int alpha)
        {
            this.alpha = alpha;
        }
    }
}
