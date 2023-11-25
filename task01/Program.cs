// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void PrintArray(string [] arr)
{
    Console.Write('[');
    for (int index = 0; index < arr.Length; index++)
    {
        if (index < arr.Length-1)
        {
            Console.Write($"{arr[index]}, ");
        }
        else
        {
            Console.Write($"{arr[index]}");
        }
            
    }
    Console.WriteLine(']');
}

string [] arrayStart = {"Hello", "2", "world", ":-)"};
string [] arrayResult = new string [arrayStart.Length];
int j = 0;

// int countArrayStart = arrayStart.Length;
// Console.WriteLine(countArrayStart);
// Console.WriteLine(arrayStart[0]);
for (int i = 0; i < arrayStart.Length; i++)
    // for (int j = 0; j < arrayResult.Length; j++)
    {
        if (arrayStart[i].Length < 4)
        {
            arrayResult[j] = arrayStart[i];
            //Console.Write('[' + arrayResult[j] + ']');
            j++;
        }
            // Console.WriteLine(j);
    }
if 
PrintArray(arrayStart);
PrintArray(arrayResult);




// Console.WriteLine(arrayResult.Length);
// for (int p = 0; p < arrayResult.Length; p++)
// {
//     Console.WriteLine(arrayResult[p]);
// }

//     if (countWord < 3)
//         arrayResult[j] = arrayStart[i];
//         j +=1;
//     i+=1;
// while (p < arrayResult().Length)
//     Console.WriteLine(arrayResult[p]);


// string a = "hello";
// Console.WriteLine(a.Length);

// string a = "dsfsdf";
// int b = a.Length;
// Console.WriteLine(b);
// for (int i = 0; i < arrayStart.Length; i++)


