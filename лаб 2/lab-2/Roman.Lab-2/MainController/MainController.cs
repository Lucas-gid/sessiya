using System;
using MainController._2_nd_lb_classes;
using MainController._2_nd_lb_classes.Point_and_Figure;

namespace MainController
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] examples = { "Adress", "Rectangle", "Book", "Point and Figure", "User", "Converter", "Employee", "Invoice" };
            while (true)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Перечень заданий");
                for (int i = 0; i < examples.Length; i++)
                    Console.WriteLine((i + 1) + ". " + examples[i]);
                Console.WriteLine(new string('-', 30));
                Console.Write("Введите номер задания: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('-', 30));
                switch (n)
                {
                    case 1:
                        #region 1-е Задание
                        Adress MyAdress = new Adress(93105, "Ukraine", "Troeschina", "Kommunalnaya", 29, 22);
                        MyAdress.ShowInfo();
                        #endregion
                        break;
                    case 2:
                        #region 2-е Задание
                        Rectangle MyRectangle = new Rectangle(3587.426, 11.21);

                        Console.WriteLine($"Perimeter: {MyRectangle.Perimeter}");
                        Console.WriteLine($"Area: {MyRectangle.Area}");
                        #endregion
                        break;
                    case 3:
                        #region 3-е Задание
                        Book MyBook = new Book(
                            new Title("Полное руководство по C# 4.0"),
                            new Author("Герберт Шилдт"),
                            new Content("Руководство по программированию"));

                        MyBook.Show();
                        #endregion
                        break;
                    case 4:
                        #region 4-е Задание
                        Figure figure = new Figure(
                            new Point(2, 9, "A"),
                            new Point(4, 6, "B"),
                            new Point(24, 22, "C"),
                            new Point(38, 47, "D"),
                            new Point(-251, 74, "E"));
                        figure.Perimeter();
                        #endregion
                        break;
                    case 5:
                        #region 5-е Задание
                        User MyUser = new User("Desktop", "Roman", "Vasilevich", 18, "06.09.2020");
                        MyUser.ShowInfo();
                        #endregion
                        break;
                    case 6:
                        #region 6-е Задание
                        Converter converter = new Converter(10, 10, 10, 28);
                        converter.ValueConverter();
                        #endregion
                        break;
                    case 7:
                        #region 7-е Задание
                        Employee employee = new Employee("Артур", "Пупкин");
                        employee.GetInfo();
                        #endregion
                        break;
                    case 8:
                        #region 8-е Задание
                        Invoice invoice = new Invoice(16847, "Roman", "IBM");
                        invoice.Price();
                        #endregion
                        break;
                    default:
                        Console.WriteLine("Введите другую цифру");
                        return;
                }
                Console.WriteLine(new string('-', 30));
                Console.Write(
                    $"Для продолжения нажмите ENTER\n" +
                    $"Для выхода введите -Q или -q \n--> ");
                string quit = Console.ReadLine();
                if (quit == "Q" || quit == "q")
                    break;
            }

        }
    }
}
