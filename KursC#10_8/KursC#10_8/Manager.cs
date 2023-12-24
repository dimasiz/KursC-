using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursC_10_8
{
    internal class Manager: Сonsultant , IChanging
    {
        public Client AddClient()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string secondName = Console.ReadLine();

            Console.WriteLine("Введите Отчество:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите номер телефона:");
            string number = Console.ReadLine();

            Console.WriteLine("Введите номер паспорта: ");
            string numberOfPasprot = Console.ReadLine();

            DateTime data = DateTime.Now;

            Client client = new Client(name, secondName, lastName, number, numberOfPasprot, data , null, null); ;
            return client;
        }

        
        

        public Client Changed(Client client)
        {
            Console.WriteLine("1 - Имя\n2 - Фамилия\n3 - Оттчество\n4 - Номер Телефона\n5 - Паспортные данные\n6 - Некаких изменений");
            Console.WriteLine("Выберите что изменить:");
            byte comand = byte.Parse(Console.ReadLine());

            switch (comand)
            {
                case 1:
                    Console.WriteLine("Введите новое имя:");
                    string newName = Console.ReadLine();
                    client.Name = newName;
                    client.TimeChange = DateTime.Now;
                    client.DataChange = "Имя";
                    client.ChangedData = "Менаджер";
                    break;

                case 2:
                    Console.WriteLine("Введите новую фамилию:");
                    string newSecondName = Console.ReadLine();
                    client.SecondName = newSecondName;
                    client.TimeChange = DateTime.Now;
                    client.DataChange = "Фамилия";
                    client.ChangedData = "Менаджер";
                    break;

                case 3:
                    Console.WriteLine("Введите новое Отчество:");
                    string newLastName = Console.ReadLine();
                    client.LastName = newLastName;
                    client.TimeChange = DateTime.Now;
                    client.DataChange = "Оттчество";
                    client.ChangedData = "Менаджер";
                    break;

                case 4:
                    Console.WriteLine("Введите Новый номер телефона:");
                    string newNumber = Console.ReadLine();
                    client.Number = newNumber;
                    client.TimeChange = DateTime.Now;
                    client.DataChange = "Номер телефона";
                    client.ChangedData = "Менаджер";
                    break;

                case 5:
                    Console.WriteLine("Введите Новые Паспортные данные:");
                    string newNumberPaspotr = Console.ReadLine();
                    client.NumberOfPasport = newNumberPaspotr;
                    client.TimeChange = DateTime.Now;
                    client.DataChange = "Паспортные данные";
                    client.ChangedData = "Менаджер";
                    break;

                case 6:
                    break;



            }
            return client;
            

        }
    }
}
