using Course.ModuloDeEstudo.Modulo6.CircleOrRectangle.Entities.Enum;

namespace Course.ModuloDeEstudo.Modulo6.CircleOrRectangle.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape (Color color)
        {
            Color = color;
        }

        public abstract double Area();// declarando que a operação será abstrata
    }
}
