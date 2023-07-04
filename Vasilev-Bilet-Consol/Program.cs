using System.Security.Cryptography.X509Certificates;
using Vasilev_Bilet3;
namespace MainProgram
{
    class Program  //Создатель - Васильев А.А.
    {
        static void Main()
        {
            Garage ga = new Garage("ООО УВУ", "г. Новосибирск");  //Внос информации о гараже
            ga.Show();

            Car c1 = new Car("Петровский И.И.","134138");  //Внос информации о машине
            ga.Cars.Add(c1);

            Car c2 = new Car("Чайковский З.В.", "134139");
            ga.Cars.Add(c2);

            Car c3 = new Car("Херувимов У.К.", "134140");
            ga.Cars.Add(c3);

            Car c4 = new Car("Бахчи И.А.", "134141");
            ga.Cars.Add(c4);

            foreach (Car c in ga.Cars)  //Вывод всех машин, содержащихся в гараже
            {
                c.Show();
            }

            Console.ReadKey();  //Удержание консольного приложения
        }
    }
}