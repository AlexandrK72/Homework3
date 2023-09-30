using System;
using System.Globalization;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        if (number > 9999 && number < 100000) 
        {
            
           int result = number % 10 * 10000 + number /10 % 10 * 1000 + number / 100 % 10 * 100 + number /1000 % 10 * 10 + number/10000;

            if (number == result)
            {
               
               return true;
               
            }
             
            return false;
           
        }
        
        Console.WriteLine($"Число не пятизначное");
        return false ;

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 1221;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}