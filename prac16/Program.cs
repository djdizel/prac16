using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(42);                  
        list.Add("Hello");             
        list.Add(true);                
        list.Add(3.14);                
        list.Add(-10);                 
        list.Add(-2.718);              
        Output("Список элементов:", list);
        Console.WriteLine($"\nКоличество элементов: {list.Count}");
        list.Insert(1, "NewString");
        Output("\nПосле вставки второго элемента:", list);
        if (list.Contains(42))
        {
            list.Remove(42);  
        }
        Output("\nПосле удаления положительного числа:", list);
        list.Reverse();
        Output("\nПосле реверса списка:", list);
        string[] stringArray = { "apple", "banana", "cherry" };
        list.AddRange(stringArray);
        Output("\nПосле добавления строкового массива:", list);
    }
    static void Output(string message, ArrayList list)
    {
        Console.WriteLine(message);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}