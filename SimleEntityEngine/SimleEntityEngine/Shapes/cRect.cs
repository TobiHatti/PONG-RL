using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SimleEntityEngine.Shapes
{
    class Rect : Shape
    {
        private Point position;
        private Size size;
        private Boolean centered;

        public Rect(Point pPosition, Size pSize, Boolean pCentered = false)
        {
            position = pPosition;
            size = pSize;
            centered = pCentered;
        }

        public Rect(Int32 pPoxX, Int32 pPosY, Int32 pWidth, Int32 pHeight, Boolean pCentered = false) : 
            this(new Point(pPoxX, pPosY), new Size(pWidth, pHeight), pCentered) { }

        public bool Contains(Point pPoint)
        {
            if(centered)
            {
                
            }
            else
            {
               
            }
        }

        public bool Contains(Int32 pPosX, Int32 pPosY)
            => Contains(new Point(pPosX, pPosY));
    }
}
