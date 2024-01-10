// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.


string [] array = {"123", "hello", "23", "2345"};

//Console.WriteLine(array[0].Length);

string [] ChangedArray(string [] array) {

    int length = array.Length;
    int count = 0;

    for (int i = 0; i < length; i++) {
        if (array[i].Length <= 3) {
            count++;
            
        }
    }

    string [] resultArray = new string[count];

    int index = 0;

    for (int i = 0; i < length; i++) {
        if (array[i].Length <= 3) {
            resultArray[index] = array[i];
            index++;
        }
    }

    return resultArray;
}

void ShowArray(string [] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write("\"" + array[i] + "\"");

        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine();
}

string [] newArray = ChangedArray(array);

ShowArray(newArray);