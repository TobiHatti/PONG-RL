using SimleEntityEngine.Shapes;
using System;
using System.Globalization;

namespace SimleEntityEngine.Entities
{
    public abstract class Entity
    {
        private Shape shape;



        public abstract bool CollidesWith(Entity pEntity);

    }
}
