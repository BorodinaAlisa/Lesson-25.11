using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 14.1. Использование предопределенного условного атрибута для условного nвыполнения кода (указывает компиляторам, что при отсутствии символа условной компиляции, вызов метода или атрибут следует игнорировать). В классе банковский счет добавить метод DumpToScreen, который отображает детали банковского счета. Для выполнения этого метода использовать условный атрибут, зависящий от символа условной компиляции DEBUG_ACCOUNT. Протестировать метод DumpToScreen.");
            AccountBank account2 = new AccountBank(1234, AccountType.Current, "Alisa");
            Console.WriteLine(account2);
            account2.Deposit(1000);
            account2.DumpToScreen();
            Console.WriteLine("Упражнение 14.2. Создать пользовательский атрибут DeveloperInfoAttribute. Этот атрибут позволяет хранить в метаданных класса имя разработчика и, дополнительно, дату разработки класса. Атрибут должен позволять многократное использование. Использовать этот атрибут для записи имени разработчика класса рациональные числа (упражнение 12.2).");
            Type rationalType = typeof(Rational);
            DeveloperInfo2Attribute[] attributes = (DeveloperInfo2Attribute[])rationalType.GetCustomAttributes(typeof(DeveloperInfo2Attribute), true);
            foreach (DeveloperInfo2Attribute attribute1 in attributes)
            {
                Console.WriteLine($"Разработчик: {attribute1.DeveloperName1}");
                Console.WriteLine($"Дата: {attribute1.DevelopmentDate}");
            }
            Console.WriteLine("Домашнее задание 14.1. Создать пользовательский атрибут для класса из домашнего задания 13.1. Атрибут позволяет хранить в метаданных класса имя разработчика и название организации. Протестировать.");
            Building building = new Building(77, 17, 70, 7);
            Type buildingType = building.GetType();
            DeveloperInfoAttribute attribute = (DeveloperInfoAttribute)Attribute.GetCustomAttribute(buildingType, typeof(DeveloperInfoAttribute));
            if (attribute != null)
            {
                string developerName = attribute.DeveloperName;
                string organizationName = attribute.OrganizationName;
                Console.WriteLine($"Разработчик: {developerName}");
                Console.WriteLine($"Организация: {organizationName}");
            }
            Console.ReadKey();
        }
    }
}
