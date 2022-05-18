using Herenca_Interface.Model.Enums;

namespace Herenca_Interface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
