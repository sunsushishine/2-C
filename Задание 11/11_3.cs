using System;
using System.Collections.Generic;

namespace ConsoleCollectionPrimer2
{
    struct Client
    {
        public string Name;

        public Client(string Name)
        {
            this.Name = Name;
        }

        public void WriteClient()
        {
            Console.WriteLine("Фамилия: {0}", Name);
        }
    }

    class Program
    {
        static void Main()
        {
            Client cl;
            Queue<Client> interviewQueue = new Queue<Client>();

            Console.WriteLine("Введите начальный список фамилий в очереди (для завершения введите 'выход'):");

            while (true)
            {
                Console.Write("Фамилия клиента: ");
                string initialClientName = Console.ReadLine();

                if (initialClientName.ToLower() == "выход")
                {
                    break; // завершение ввода начального списка
                }

                cl = new Client(initialClientName);
                interviewQueue.Enqueue(cl);
            }

            while (true)
            {
                Console.WriteLine("\nСписок клиентов на собеседование:");

                foreach (Client client in interviewQueue)
                {
                    client.WriteClient();
                }

                Console.WriteLine("\nДобавление нового клиента в конец очереди:");
                Console.Write("Введите фамилию нового клиента (для завершения введите 'выход'): ");
                string newClientName = Console.ReadLine();

                if (newClientName.ToLower() == "выход")
                {
                    break; // завершение программы
                }

                cl = new Client(newClientName);
                interviewQueue.Enqueue(cl);

                Console.WriteLine("\nСписок клиентов после добавления:");

                foreach (Client client in interviewQueue)
                {
                    client.WriteClient();
                }

                Console.WriteLine("\nПроход первого клиента на собеседование:");

                if (interviewQueue.Count > 0)
                {
                    Client firstClient = interviewQueue.Dequeue();
                    Console.WriteLine("Клиент прошел собеседование:");
                    firstClient.WriteClient();
                }
                else
                {
                    Console.WriteLine("Очередь пуста.");
                }

                Console.WriteLine("\nОставшаяся очередь:");
            }
        }
    }
}
