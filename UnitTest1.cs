namespace Testy_jednostkowe
{
    public class Rownanie_Kwadratowe_Test
    {       string Obliczenia(double a, double b, double c)
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
        //Theory
        [Theory]
        [InlineData(1, 1, 1, "Równanie nie ma pierwiastków rzeczywistych.")]
        [InlineData(1, -2, 1, "Równanie ma jeden pierwiastek rzeczywisty:\nx = 1")]
        [InlineData(2, -5, 2, "Równanie ma dwa pierwiastki rzeczywiste:\nx1 = 2\nx2 = 0,5")]
        public void Rownanie_Kwadratowe(double a, double b, double c, string expected)
        {
            // Act
            string result = Obliczenia(a, b, c);

            // Assert
            Assert.Equal(expected, result);
        }


    }

   
}
