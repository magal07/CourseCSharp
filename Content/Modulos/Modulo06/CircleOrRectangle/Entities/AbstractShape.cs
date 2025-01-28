using Course.Model.Enum;

using Course.ModuloDeEstudo.Modulo6.CircleOrRectangle.Entities;

namespace Course.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color{ get; set; }

        public abstract double Area();
    }
}
