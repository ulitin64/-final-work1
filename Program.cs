/*
Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
*/

string[] array1 = new string[5] { "123", "23", "hello", "word", "res" };
string[] array2 = new string[array1.Length];

void SecondArrayWinthlF(string[] array1, string[array2])
{
    int count = 0;
    for (int = 0, i < array1.Length, i++)
    {
        if (array1[1].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
    
}

}
SecondArrayWinthlF(array1, array2);
PrintArray(array2);