using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace KursC_10_8
{
    internal class Сonsultant: IChangedNumber
    {
        public List<Client> CreateList()
        {
            return new List<Client>();
        }

      

        public void WatchList(List<Client> clients)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                Console.Write($"{i+1} ");
                
                Console.WriteLine($"Имя:{clients[i].Name}, Фамилия:{clients[i].SecondName},Оттчество:{clients[i].LastName}, Номер телефона +375{clients[i].Number},Номер Паспорта:{clients[i].NumberOfPasport} \nВремя последний изменений:{clients[i].TimeChange}\nИзмененения:{clients[i].DataChange}\nКто изменил:{clients[i].ChangedData}");
            }
        }


        public void WatchInfo(Client client)
        {
            Console.InputEncoding = Encoding.GetEncoding("utf-16");
            Console.OutputEncoding = Encoding.GetEncoding("utf-16");

            Console.WriteLine($"Имя:{client.Name}, Фамилия:{client.SecondName},Оттчество:{client.LastName}, Номер телефона +375{client.Number},Номер Паспорта:{client.NumberOfPasport}");
        }
        public Client ChangedNumber(Client client)
        {
            string number = string.Empty;
            while (number == string.Empty)
            {
                Console.WriteLine("Введите новый номер клиента");
                number = Console.ReadLine();
                client.TimeChange = DateTime.Now;
                client.DataChange = "Номер";
                client.ChangedData = "Консультант";
                client.Number = number;

            }
            return client;
        }


    }
}
