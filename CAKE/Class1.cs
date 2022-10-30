namespace CAKE
{
    internal class Cake
    {
        bool isListenning = true;
        int posicion = 3;
        int lockPosicion = 9;
        int window = 0;
        CakeCreate cake = new CakeCreate();
        private void cursor(CakeCreate cake)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow & posicion > 3)
            {
                posicion--;
            }
            else if (key.Key == ConsoleKey.DownArrow & posicion < lockPosicion)
            {
                posicion++;
            }

            else if (window == 0 & key.Key == ConsoleKey.Enter & posicion == 3)
            {
                window = 1;
                lockPosicion = 6;
                posicion = 3;
            }
            else if (window == 0 & key.Key == ConsoleKey.Enter & posicion == 4)
            {
                window = 2;
                lockPosicion = 5;
                posicion = 3;
            }
            else if (window == 0 & key.Key == ConsoleKey.Enter & posicion == 5)
            {
                window = 3;
                lockPosicion = 7;
                posicion = 3;
            }
            else if (window == 0 & key.Key == ConsoleKey.Enter & posicion == 6)
            {
                window = 4;
                lockPosicion = 6;
                posicion = 3;
            }
            else if (window == 0 & key.Key == ConsoleKey.Enter & posicion == 7)
            {
                window = 5;
                lockPosicion = 7;
                posicion = 3;
            }
            else if (window == 0 & key.Key == ConsoleKey.Enter & posicion == 8)
            {
                window = 6;
                lockPosicion = 5;
                posicion = 3;
            }
            else if (window == 0 & key.Key == ConsoleKey.Enter & posicion == 9)
            {
                window = 7;
                lockPosicion = 3;
                posicion = 3;
            }


            else if (window == 1 & posicion == 3 & key.Key == ConsoleKey.Enter)
            {
                cake.form = "круг";
                cake.coastForm = 500;
                posicion = 3;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 1 & posicion == 4 & key.Key == ConsoleKey.Enter)
            {
                cake.form = "квадрат";
                cake.coastForm = 500;
                posicion = 3;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 1 & posicion == 5 & key.Key == ConsoleKey.Enter)
            {
                cake.form = "прямоугольник";
                cake.coastForm = 500;
                posicion = 3;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 1 & posicion == 6 & key.Key == ConsoleKey.Enter)
            {
                cake.form = "сердечкo";
                cake.coastForm = 700;
                posicion = 3;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 2 & posicion == 3 & key.Key == ConsoleKey.Enter)
            {
                cake.size = "маленький";
                cake.coastSize = 800;
                posicion = 4;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 2 & posicion == 4 & key.Key == ConsoleKey.Enter)
            {
                cake.size = "средний";
                cake.coastSize = 1300;
                posicion = 4;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 2 & posicion == 5 & key.Key == ConsoleKey.Enter)
            {
                cake.size = "большой";
                cake.coastSize = 2000;
                posicion = 4;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 3 & posicion == 3 & key.Key == ConsoleKey.Enter)
            {
                cake.vkus = "ванильный";
                cake.coastVkus = 100;
                posicion = 5;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 3 & posicion == 4 & key.Key == ConsoleKey.Enter)
            {
                cake.vkus = "шоколадный";
                cake.coastVkus = 100;
                posicion = 5;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 3 & posicion == 5 & key.Key == ConsoleKey.Enter)
            {
                cake.vkus = "крамельный";
                cake.coastVkus = 200;
                posicion = 5;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 3 & posicion == 6 & key.Key == ConsoleKey.Enter)
            {
                cake.vkus = "ягодный";
                cake.coastVkus = 250;
                posicion = 5;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 3 & posicion == 7 & key.Key == ConsoleKey.Enter)
            {
                cake.vkus = "кокосовый";
                cake.coastVkus = 300;
                posicion = 5;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 4 & posicion == 3 & key.Key == ConsoleKey.Enter)
            {
                cake.kolvo = "1 корж";
                cake.coastKolvo = 100;
                posicion = 6;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 4 & posicion == 4 & key.Key == ConsoleKey.Enter)
            {
                cake.kolvo = "2 корж";
                cake.coastKolvo = 200;
                posicion = 6;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 4 & posicion == 5 & key.Key == ConsoleKey.Enter)
            {
                cake.kolvo = "3 корж";
                cake.coastKolvo = 300;
                posicion = 6;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 4 & posicion == 6 & key.Key == ConsoleKey.Enter)
            {
                cake.kolvo = "4 корж";
                cake.coastKolvo = 400;
                posicion = 6;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 5 & posicion == 3 & key.Key == ConsoleKey.Enter)
            {
                cake.glaz = "шоколад";
                cake.coastGlaz = 100;
                posicion = 7;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 5 & posicion == 4 & key.Key == ConsoleKey.Enter)
            {
                cake.glaz = "крем";
                cake.coastGlaz = 100;
                posicion = 7;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 5 & posicion == 5 & key.Key == ConsoleKey.Enter)
            {
                cake.glaz = "бизе";
                cake.coastGlaz = 150;
                posicion = 7;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 5 & posicion == 6 & key.Key == ConsoleKey.Enter)
            {
                cake.glaz = "драже";
                cake.coastGlaz = 200;
                posicion = 7;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 5 & posicion == 7 & key.Key == ConsoleKey.Enter)
            {
                cake.glaz = "ягоды";
                cake.coastGlaz = 200;
                posicion = 7;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 6 & posicion == 3 & key.Key == ConsoleKey.Enter)
            {
                cake.dec = "шоколадный";
                cake.coastDec = 100;
                posicion = 8;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 6 & posicion == 4 & key.Key == ConsoleKey.Enter)
            {
                cake.dec = "кремовый";
                cake.coastDec = 100;
                posicion = 8;
                lockPosicion = 9;
                window = 0;
            }
            else if (window == 6 & posicion == 5 & key.Key == ConsoleKey.Enter)
            {
                cake.dec = "ягодный";
                cake.coastDec = 150;
                posicion = 8;
                lockPosicion = 9;
                window = 0;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                posicion = 3;
                lockPosicion = 9;
                window = 0;
            }
        }
        public void Menu(CakeCreate cake)
        {
            int Coast01 = cake.coastForm + cake.coastSize + cake.coastVkus + cake.coastKolvo + cake.coastGlaz + cake.coastDec;
            string Info01 = cake.form + ", " + cake.size + ", " + cake.vkus + ", " + cake.kolvo + ", " + cake.glaz + ", " + cake.dec;
            if (window == 0)
            {
                Console.WriteLine("Заказ тортов в магазине ДЯДЯ ВАНЯ \n" +
                    "Выберите параметр торта \n" +
                    "----------------------- \n" +
                    "  Форма торта\n" +
                    "  Размер торта\n" +
                    "  Вкус коржей\n" +
                    "  Количество коржей\n" +
                    "  Глазурь\n" +
                    "  Декор\n" +
                    "  Конец заказа\n");
                Console.WriteLine("Цена: ");
                Console.SetCursorPosition(6, 11);
                Console.WriteLine(Coast01);
                Console.WriteLine("Состав: " + Info01);


            }
            else if (window == 1)
            {
                Console.WriteLine("Заказ тортов в магазине ДЯДЯ ВАНЯ \n" +
                    "Выберите параметр торта \n" +
                    "----------------------- \n" +
                    "  круг - 500\n" +
                    "  квадрат - 500\n" +
                    "  прямоугольник - 500\n" +
                    "  сердечкo - 700\n");
            }
            else if (window == 2)
            {
                Console.WriteLine("Заказ тортов в магазине ДЯДЯ ВАНЯ \n" +
                    "Выберите параметр торта \n" +
                    "----------------------- \n" +
                    "  маленький - 800\n" +
                    "  средний - 1300\n" +
                    "  большой  - 2000\n");
            }
            else if (window == 3)
            {
                Console.WriteLine("Заказ тортов в магазине ДЯДЯ ВАНЯ \n" +
                    "Выберите параметр торта \n" +
                    "----------------------- \n" +
                    "  ванильный - 100\n" +
                    "  шоколадный - 100\n" +
                    "  крамельный  - 200\n" +
                    "  ягодный - 250\n" +
                    "  кокосовый - 300\n");
            }
            else if (window == 4)
            {
                Console.WriteLine("Заказ тортов в магазине ДЯДЯ ВАНЯ \n" +
                    "Выберите параметр торта \n" +
                    "----------------------- \n" +
                    "  1 корж - 100\n" +
                    "  2 коржа - 200\n" +
                    "  3 коржа - 300\n" +
                    "  4 коржа - 400\n");
            }
            else if (window == 5)
            {
                Console.WriteLine("Заказ тортов в магазине ДЯДЯ ВАНЯ \n" +
                    "Выберите параметр торта \n" +
                    "----------------------- \n" +
                    "  шоколад- 100\n" +
                    "  крем - 100\n" +
                    "  бизе - 150\n" +
                    "  драже - 200\n" +
                    "  ягоды - 200\n");
            }
            else if (window == 6)
            {
                Console.WriteLine("Заказ тортов в магазине ДЯДЯ ВАНЯ \n" +
                    "Выберите параметр торта \n" +
                    "----------------------- \n" +
                    "  шоколадная - 100\n" +
                    "  кремомая - 100\n" +
                    "  ягодная - 150\n");
            }
            else if (window == 7)
            {
                Console.WriteLine("Ваш заказ сохранён, чтобы сделать ещё один нажмите ESC, чтобы выйти нажмите Enter");
                File.AppendAllText("C:\\Users\\vanya\\Desktop\\ШАРАГА (1)\\С#\\5.CAKE\\ЗАКАЗ.txt", "\nЦена:  " + Convert.ToString(Coast01));
                File.AppendAllText("C:\\Users\\vanya\\Desktop\\ШАРАГА (1)\\С#\\5.CAKE\\ЗАКАЗ.txt", "\nСостав:  " + Info01);
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (window == 7 & key1.Key == ConsoleKey.Enter)
                {
                    isListenning = false;
                }
            }
        }

        public void Main()
        {
            Menu(cake);
            Console.SetCursorPosition(0, posicion);
            Console.WriteLine("->");
            while (isListenning == true)
            {
                cursor(cake);
                Console.Clear();
                Menu(cake);
                Console.SetCursorPosition(0, posicion);
                Console.WriteLine("->");

            }
        }
    }
}
