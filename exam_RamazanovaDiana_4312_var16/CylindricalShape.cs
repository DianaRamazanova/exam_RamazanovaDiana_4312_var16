// Класс "Прямой цилиндр"
public class CylindricalShape
{
    public Ellipse BaseEllipse { get; set; }
    public double Height { get; set; }

    public CylindricalShape(Ellipse baseEllipse, double height)
    {
        BaseEllipse = baseEllipse;
        Height = height;
    }

    public bool IsPointInsideCylinder(CylindricalShape shape)
    {
        double x = shape.BaseEllipse.Radius1;
        double y = shape.BaseEllipse.Radius2;
        double z = shape.Height / 2;

        if ((x * x) / (shape.BaseEllipse.Radius1 * shape.BaseEllipse.Radius1) + (y * y) / (shape.BaseEllipse.Radius2 * shape.BaseEllipse.Radius2) <= 1)
        {
            if (z >= -shape.Height / 2 && z <= shape.Height / 2)
            {
                return true;
            }
        }

        return false; 
    }


}
