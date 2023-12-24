using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection.Metadata;

namespace KursC_10_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            
            bool flag = true;
            byte command;

            List<Client> clients = new List<Client>();

            Found:
            Console.WriteLine("Выберите аккаунт входа\n1 - Консультант 2 - Менеджер\n0 - Выход из приложения");
            byte chooseCommand = byte.Parse(Console.ReadLine());
            if (chooseCommand == 1)
            {
                
                Сonsultant consultant = new Сonsultant();

                while (flag)
                {
                    Console.WriteLine("1 - посмотреть список клиентов\n2 - Изменение параметров\n0 - Выход");
                    command = byte.Parse(Console.ReadLine());
                    switch (command)
                    {
                        case 0:
                            goto Found;
                            break;

                        case 1:
                            consultant.WatchList(clients);
                            break;

                        case 2:
                            Console.WriteLine("Введите индекс клиента");
                            int clientId = int.Parse(Console.ReadLine());

                            if (clientId >= clients.Count)
                            {
                                Console.WriteLine("Неверный Id");


                            }
                            else
                            {
                                consultant.ChangedNumber(clients[clientId]);
                            }
                            break;

                    }
                }
            }
            else if (chooseCommand == 2)
            {
                Manager manager = new Manager();
                while (flag)
                {
                Console.WriteLine("1 - добавить клиента\n2 - посмотреть список клиентов\n3 - Изменение параметров\n0 - Выход");
                command = byte.Parse(Console.ReadLine());

                
                    switch (command)
                    {
                        case 0:
                            goto Found;
                            break;

                        case 1:
                            
                            Client client = manager.AddClient();
                            clients.Add(client);
                            break;


                        case 2:
                            manager.WatchList(clients);
                            break;

                        case 3:
                            Console.WriteLine("Введите индекс клиента");
                            int clientId = int.Parse(Console.ReadLine());

                            if (clientId >= clients.Count)
                            {
                                Console.WriteLine("Неверный Id");


                            }
                            else
                            {
                                manager.Changed(clients[clientId]);
                            }
                            break;
                    }

                }
            }
            else if(chooseCommand == 0) 
            {
                flag = false;
            }
        }
           
    }
    
}