// Задача: Написать программу, которая из имеющегося массива 
// строк формирует массив из строк, длина которых меньше либо
// равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.



int CountElements(string[] array, int numberOfItems)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= numberOfItems)
      {
         count++;
      }
   }
   return count;
}

string[] ResultArray(string[] array, int count, int numberOfItems)
{
   string[] result = new string[count];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= numberOfItems)
      {
         result[result.Length - count] = array[i];
         count--;
      }
   }
   return result;
}

void PrintArray(string[] array)
{
   Console.Write("[");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"\"{array[i]}\"");
      if (i != array.Length - 1)
      {
         Console.Write(", ");
      }
   }
   Console.Write("]");
}

void PrintResArray(string[] firstArray, string[] finalArray)
{
   PrintArray(firstArray);
   Console.Write(" -> ");
   PrintArray(finalArray);
   Console.WriteLine();
}

string[] arrayFirst = { "hello", "2", "world", ":-)" };
// string[] arrayFirst = { "1234", "1567", "-2", "computer science" };
// string[] arrayFirst = { "Russia", "Denmark", "Kazan" };
int numberOfItems = 3;
int countFirst = CountElements(arrayFirst, numberOfItems);
string[] resultFirst = ResultArray(arrayFirst, countFirst, numberOfItems);
PrintResArray(arrayFirst, resultFirst);