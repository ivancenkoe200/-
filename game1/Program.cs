namespace game1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы просыпаетесь в комнате.");
            Console.Write("Введите имя вашего персонажа: ");
            string playerName = Console.ReadLine();

            bool foundArtifact1 = false;
            bool foundArtifact2 = false;
            bool foundArtifact3 = false;
            bool statueActivated = false;
            bool keyObtained = false;
            bool lockPicked = false;

            while (!lockPicked)
            {
                Console.WriteLine("\nЧто вы хотите сделать?");
                Console.WriteLine("1. Открыть дверь");
                Console.WriteLine("2. Заглянуть под кровать");
                Console.WriteLine("3. Открыть ящик в углу комнаты");
                Console.WriteLine("4. Открыть вентиляцию");
                Console.WriteLine("5. Взглянуть на тумбочку");
                Console.WriteLine("6. Взглянуть на статую рядом с дверью");
                Console.Write("Выберите действие (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (lockPicked)
                        {
                            Console.WriteLine($"{playerName}, вы успешно сбежали!");
                        }
                        else
                        {
                            Console.WriteLine("Дверь закрыта. Вам нужно открыть ящик и найти отмычку.");
                        }
                        break;
                    case "2":
                        if (!foundArtifact1)
                        {
                            Console.WriteLine($"{playerName}, вы нашли первый артефакт под кроватью!");
                            foundArtifact1 = true;
                        }
                        else
                        {
                            Console.WriteLine($"{playerName}, под кроватью больше ничего нет.");
                        }
                        break;
                    case "3":
                        if (keyObtained)
                        {
                            Console.WriteLine($"{playerName}, вы открыли ящик и нашли отмычку от двери!");
                            lockPicked = true;
                        }
                        else
                        {
                            Console.WriteLine("Сначала активируйте статую, чтобы получить ключ от ящика.");
                        }
                        break;
                    case "4":
                        if (!foundArtifact2)
                        {
                            Console.WriteLine("Вы открываете вентиляцию. Пытаетесь три раза.");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine("Открываете вентиляцию...");
                            }
                            Console.WriteLine($"{playerName}, вы нашли второй артефакт в вентиляции!");
                            foundArtifact2 = true;
                        }
                        else
                        {
                            Console.WriteLine($"{playerName}, в вентиляции больше ничего нет.");
                        }
                        break;
                    case "5":
                        if (!foundArtifact3)
                        {
                            Console.WriteLine($"{playerName}, вы нашли третий артефакт на тумбочке!");
                            foundArtifact3 = true;
                        }
                        else
                        {
                            Console.WriteLine($"{playerName}, на тумбочке больше ничего нет.");
                        }
                        break;
                    case "6":
                        if (foundArtifact1 && foundArtifact2 && foundArtifact3 && !statueActivated)
                        {
                            Console.WriteLine($"{playerName}, вы активировали статую тремя артефактами и получили ключ от ящика!");
                            keyObtained = true;
                            statueActivated = true;
                        }
                        else if (statueActivated)
                        {
                            Console.WriteLine($"{playerName}, статуя уже активирована.");
                        }
                        else
                        {
                            Console.WriteLine($"{playerName}, вам не хватает артефактов для активации статуи.");
                        }
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите действие от 1 до 6.");
                        break;
                }
            }
        }
     
        
    }
}     // CS1022  