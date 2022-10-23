// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] arrayint = { };
Console.WriteLine("Введите числа разделённые любым знаком");
int[] arr = Array.ConvertAll(
        FilterStringOutDig(Console.ReadLine()).Split(" "),
        int.Parse);
int result = PositiveNum(arr); 
Console.WriteLine($"Введено чисел больше 0: {result} ");  


// Метод, который убирает из строки все символы, кроме чисел и заменяет их пробелом.
string FilterStringOutDig(string inputstring)
{
    int parsenum;
    bool checkchar = true; // нужно для проверки на двойные символы

    for (int i = 0; i < inputstring.Length; i++) // На выходе должна получиться строка, где всё, что отлично от цифры, заменено пробелами
    {
        if (int.TryParse(Convert.ToString(inputstring[i]), out parsenum)
        || inputstring[i] == '-' && int.TryParse(Convert.ToString(inputstring[i + 1]), out parsenum))
         {
            checkchar = false;
        }
        else 
            
            if (checkchar) 
            {
                inputstring = inputstring.Remove(i, 1);
                checkchar = true;
                i--;
            }
            else
            {
                inputstring = inputstring.Remove(i, 1);
                inputstring = inputstring.Insert(i, " ");
                checkchar = true;
            }
        }
    if (checkchar) inputstring = inputstring.Remove(inputstring.Length - 1, 1); 
    return inputstring;
}

// Метод, который находит количество чисел больше 0
int PositiveNum (int[] array) 
   {
    int count = 0;

   for (int i = 0; i < array.Length; i++)
   {
        if (array[i] > 0) count++;
    }
return count;
   }