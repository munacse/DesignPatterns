
namespace DesignPattern
{
    public class ShapeCreatorFacade
    {
        private IShape _circle;
        private IShape _rectangle;
        private IShape _square;

        public ShapeCreatorFacade()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }
    }
}
