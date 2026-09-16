public class Circle
{
    private double radius;
    public Circle()
    {
        radius = 0;
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public double GetArea()
    {
        return 3.14159 * radius * radius;
    }
    public double GetDiameter()
    {
        return radius * 2;
    }
    public double GetCircumference()
    {
        return 2 * 3.14159 * radius;
    }
}