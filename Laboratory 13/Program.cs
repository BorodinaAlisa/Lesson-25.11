using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 13.1-2. Из класса банковский счет удалить методы, возвращающие значения полей номер счета и тип счета, заменить эти методы на свойства только для чтения.Добавить свойство для чтения и записи типа string для отображения поля держатель банковского счета. Изменить класс BankTransaction, созданный для хранений финансовых операций со счетом, - заменить методы доступа к данным на свойства для чтения. Добавить индексатор в класс банковский счет для получения доступа к любому объекту BankTransaction.");
            AccountBank account = new AccountBank(1234, AccountType.Current, "Alisa");
            Console.WriteLine(account);
            account.Deposit(300);
            account.Withdraw(546);
            BankTransaction transaction = account[0];
            Console.WriteLine(transaction.Amount);
            Console.WriteLine("Домашнее задание 13.1. В классе здания из домашнего задания 7.1 все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.");
            Building building = new Building(200, 55, 777, 5);
            Console.WriteLine(building);
            Console.WriteLine("Домашнее задание 13.2. Создать класс для нескольких зданий. Поле класса – массив на 10 зданий. В классе создать индексатор, возвращающий здание по его номеру.");
            BuildingCollection buildingCollection = new BuildingCollection();
            buildingCollection[0] = new Building(100, 30, 305, 4);
            buildingCollection[1] = new Building(50, 19, 190, 9);
            Building building2 = buildingCollection[0];
            Building building3 = buildingCollection[1];
            Console.WriteLine($"Здание 2: {building2}");
            Console.WriteLine($"Здание 3: {building3}"); ;
            Console.ReadKey();
        }
    }
}
