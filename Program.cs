/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньшек либо равна 3 символа. Первоначальный массив можно ввести с клавеатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.

Примеры
["Hello", "2", "world", ":)"] -> ["2", ":)']
["1234", "1567", "-2", "computer sciense"] -> ["2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] array = { "Hello", "2", "world", ":)"};
string[] secondArray(string[] array)
{
    string[] arrayB = new string[0];  //Создаем новый пустой массив
    int j = 0; // индекс элементов нового массива
    for (int i = 0; i < array.Length; i++)
    {            
        if (array[i].Length <= 3) // ищет в массиве строки, длина которых меньшек либо равна 3 символа
        {          
             //Мы используем Array.Resize для замены большого массива на меньший.                    
            Array.Resize(ref arrayB, arrayB.Length + 1);   // ref передаем аргумент по ссылке  
            //увеличиваем длину массива во время выполнения                                 
            arrayB[j] = array[i]; //передаем значения найденных элементов из старого в новый массив
            j++;  //переходим к следующему элементу массива          
        }    
    }    
         return arrayB;
}
void PrintArray(string[] array, string[] arrayB)
{   
        Console.Write('[');
        Console.Write(string.Join($", ", array, 0, array.Length));
        Console.Write(']'+ " -> "+'[' );
        Console.Write(string.Join($", ", arrayB, 0, arrayB.Length)); //выдаем на монитор новый массив
        Console.Write(']');
}
PrintArray(array, secondArray(array)); //Вывод массива