using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        class Students
        {
            public string FIO { get; set; }
            public int age { get; set; }
            public string group { get; set; }
        }
        static void Main(string[] args)
        {
            Students first = new Students();
            first.FIO = "Разиков Зиеуддин Музафарович";
            first.age = 16;
            first.group = "10925-2";
            Students second = new Students();
            second.FIO = "Новиков Максим Вадимович";
            second.age = 17;
            first.group = "10925-2";
            Students third = new Students();
            third.FIO = "Бугай Алексей Анатольевич";
            third.age = 16;
            third.group = "10925-2";
            Console.WriteLine($"Студент: {first.FIO}, Возраст: {first.age}, Группа: {first.group} ");
            Console.WriteLine($"Студент: {second.FIO}, Возраст: {second.age}, Группа: {second.group} ");
            Console.WriteLine($"Студент: {third.FIO}, Возраст: {third.age}, Группа: {third.group} ");
        }
    }
}