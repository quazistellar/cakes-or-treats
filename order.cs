using CookieCakesFiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cookiescakesfiles
{
    internal class menu1
    {
        public string title { get; set; }
        public int price { get; set; }
    }
    internal class order
    {
        private static int totalPrice = 0;
        private static string zakaz;
       
        public static void MainMenu()
        {
          

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(">> * kОНДИТЕРСКАЯ СOSMOCAKEs * <<");
            Console.ResetColor();
            Console.WriteLine("------------------------------");
            Console.WriteLine("  Выберите параметры тортика: ");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржиков");
            Console.WriteLine("  Количество коржиков");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Цена: " + totalPrice);
            Console.WriteLine("Ваш заказ: " + zakaz);
            int pos = ArrowsMenu.Show(3, 3, 9);
      

            switch (pos)
                {
                case 3:
                    menushka1(); 
                    break;
                case 4:
                    menushka2(); 
                    break;
                case 5:
                    menushka3();
                    break;
                case 6:
                    menushka4(); 
                    break;
                case 7:
                    menushka5(); 
                    break;
                case 8:
                    menushka6(); 
                    break;
                case 9:
                    endoforder();
                    break;
                default:
                    Console.WriteLine("Вы завершили работу с программой!");
                    break;

            }
        }

        public static void menushka1()

        {
           

            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("------------------");

            menu1 krug = new menu1();
            krug.title = "  Круг";
            krug.price = 500;


            menu1 kvadrat = new menu1();
            kvadrat.title = "  Квадрат";
            kvadrat.price = 600;

            menu1 serdechko = new menu1();
            serdechko.title = "  Сердечко";
            serdechko.price = 800;

            List<menu1> menuList = new List<menu1>();
            menuList.Add(krug);
            menuList.Add(kvadrat);
            menuList.Add(serdechko);



            foreach (menu1 menuItem in menuList)
            {
                Console.WriteLine(menuItem.title + " - " + menuItem.price);
            }

            int pos = ArrowsMenu.Show(3, 3, menuList.Count + 2);
          

            if (pos >= 3 && pos < 3 + menuList.Count)
            {
                menu1 selectedMenuItem = menuList[pos - 3];
                totalPrice += selectedMenuItem.price;
                zakaz += selectedMenuItem.title + " - " + selectedMenuItem.price + ";";

            }
       
            MainMenu();
         
        }

        public static void menushka3()
        {
            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("------------------");

            menu1 berry = new menu1();
            berry.title = "  Ягодный";
            berry.price = 150;


            menu1 choc = new menu1();
            choc.title = "  Шоколадный";
            choc.price = 200;

            menu1 vanilla = new menu1();
            vanilla.title = "  Ванильный";
            vanilla.price = 100;

            List<menu1> menuList = new List<menu1>();
            menuList.Add(berry);
            menuList.Add(choc);
            menuList.Add(vanilla);


            foreach (menu1 menuItem in menuList)
            {
                Console.WriteLine(menuItem.title + " - " + menuItem.price);
            }
            int pos = ArrowsMenu.Show(3, 3, menuList.Count + 2);

            if (pos >= 3 && pos < 3 + menuList.Count)
            {
                menu1 selectedMenuItem = menuList[pos - 3];
                totalPrice += selectedMenuItem.price;
                zakaz += selectedMenuItem.title + " - " + selectedMenuItem.price + ";";

            }


            MainMenu();
        }

        public static void menushka2()
        {
            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("------------------");

            menu1 little = new menu1();
            little.title = "  Маленький (15 см - диаметр, 7 порций)";
            little.price = 900;


            menu1 tudasuda = new menu1();
            tudasuda.title = "  Обычный (17 см - диаметр, 9 порций)";
            tudasuda.price = 1100;

            menu1 big = new menu1();
            big.title = "  Большой (21 см - диаметр, 12 порций)";
            big.price = 1300;

            List<menu1> menuList = new List<menu1>();
            menuList.Add(little);
            menuList.Add(tudasuda);
            menuList.Add(big);


            foreach (menu1 menuItem in menuList)
            {
                Console.WriteLine(menuItem.title + " - " + menuItem.price);
            }
            int pos = ArrowsMenu.Show(3, 3, menuList.Count + 2);

            if (pos >= 3 && pos < 3 + menuList.Count)
            {
                menu1 selectedMenuItem = menuList[pos - 3];
                totalPrice += selectedMenuItem.price;
                zakaz += selectedMenuItem.title + " - " + selectedMenuItem.price + ";";

            }


            MainMenu();
        }

        public static void menushka4()
        {
            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("------------------");

            menu1 ones = new menu1();
            ones.title = "  1 коржик";
            ones.price = 100;


            menu1 twice = new menu1();
            twice.title = "  2 коржика";
            twice.price = 200;

            menu1 third = new menu1();
            third.title = "  3 коржика";
            third.price = 300;

            List<menu1> menuList = new List<menu1>();
            menuList.Add(ones);
            menuList.Add(twice);
            menuList.Add(third);


            foreach (menu1 menuItem in menuList)
            {
                Console.WriteLine(menuItem.title + " - " + menuItem.price);
            }
            int pos = ArrowsMenu.Show(3, 3, menuList.Count + 2);

            if (pos >= 3 && pos < 3 + menuList.Count)
            {
                menu1 selectedMenuItem = menuList[pos - 3];
                totalPrice += selectedMenuItem.price;
                zakaz += selectedMenuItem.title + " - " + selectedMenuItem.price + ";";
            }


            MainMenu();
        }

        public static void menushka5()
        {
           
            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("------------------");

            menu1 chocolate = new menu1();
            chocolate.title = "  Шоколадная";
            chocolate.price = 200;


            menu1 berries = new menu1();
            berries.title = "  Ягодная";
            berries.price = 250;

            menu1 cre = new menu1();
            cre.title = "  Кремовая";
            cre.price = 150;

            List<menu1> menuList = new List<menu1>();
            menuList.Add(chocolate);
            menuList.Add(berries);
            menuList.Add(cre);


            foreach (menu1 menuItem in menuList)
            {
                Console.WriteLine(menuItem.title + " - " + menuItem.price);
            }
            int pos = ArrowsMenu.Show(3, 3, menuList.Count + 2);

            if (pos >= 3 && pos < 3 + menuList.Count)
            {
                menu1 selectedMenuItem = menuList[pos - 3];
                totalPrice += selectedMenuItem.price;
                zakaz += selectedMenuItem.title + " - " + selectedMenuItem.price + ";";

            }

            MainMenu();
        }

        public static void menushka6()
        {
            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("------------------");

            menu1 stars = new menu1();
            stars.title = "  Звездочки";
            stars.price = 200;


            menu1 berri = new menu1();
            berri.title = "  Ягоды";
            berri.price = 250;

            menu1 drazhe = new menu1();
            drazhe.title = "  Драже";
            drazhe.price = 150;

            List<menu1> menuList = new List<menu1>();
            menuList.Add(stars);
            menuList.Add(berri);
            menuList.Add(drazhe);


            foreach (menu1 menuItem in menuList)
            {
                Console.WriteLine(menuItem.title + " - " + menuItem.price);
            }
            int pos = ArrowsMenu.Show(3, 3, menuList.Count + 2);

          

            if (pos >= 3 && pos < 3 + menuList.Count)
            {
                menu1 selectedMenuItem = menuList[pos - 3];
                totalPrice += selectedMenuItem.price;
                zakaz += selectedMenuItem.title + " - " + selectedMenuItem.price + ";";

            }

            MainMenu();
        }

      
        private static void endoforder()
        {
            Console.Clear();
            DateTime d = DateTime.Now;
            string txt = "\n" + " " + "Заказ от " + d+"\n"+ "Цена: " + totalPrice+"\n"+ "Содержимое заказа: " + zakaz;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\История заказов.txt";

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
                File.WriteAllText(path, txt);
            }
            else
            {
                File.AppendAllText(path, txt);
            }

            Console.WriteLine("Спасибо за заказ, странник! Чтобы сделать ещё один, нажмите клавишу Escape, чтобы выйти из программы - нажмите Z");
            totalPrice = 0;
            zakaz = "";
    

            while (true) 
            {
                ConsoleKeyInfo key;

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu();
                    break;
                }
                if (key.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    Console.WriteLine("Вы завершили работу с программой!");
                    break;

                }
            } 

        }
    }
}