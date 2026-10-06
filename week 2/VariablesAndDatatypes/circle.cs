namespace VariablesAndDatatypes
{
    public class Circle
    {
        public const double PI = 3.14;

        public double Area(double radius)
        {
            return PI * radius * radius;
        }

        public double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}
