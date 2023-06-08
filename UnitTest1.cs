namespace Testy_jednostkowe
{
    public class Rownanie_Kwadratowe_Test
    {
        string Obliczenia(double a, double b, double c)
        {
            double dlt = b * b - 4 * a * c;

            if (dlt > 0)
            {
                double x1 = (-b + Math.Sqrt(dlt)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dlt)) / (2 * a);
                return $"Równanie ma dwa pierwiastki rzeczywiste:\nx1 = {x1}\nx2 = {x2}";
            }
            else if (dlt == 0)
            {
                double x = -b / (2 * a);
                return $"Równanie ma jeden pierwiastek rzeczywisty:\nx = {x}";
            }
            else
            {
                return "Równanie nie ma pierwiastków rzeczywistych.";
            }
        }
    }
}