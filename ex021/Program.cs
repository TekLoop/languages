// вид 1, ничего не возвращают ничего не принимаают

void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();

//вид 2 что то принимает но ничего не возвращет

void Method2(string msg)
{
Console.WriteLine (msg);
}

//Method2("текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine (msg);
        i ++;
    }
}

//Method21("текст ", 4);
//Method21(count: 3, msg: "text"); //можно указать к какому именно аргументу прикрепляем и тогда не обязательно по порядку

// Вид 3, ничего не принимает но что-то возвращает, поэтому методу нужно присвоить тип переменной

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3(); //в методе произошла работа, значение положилось в арг year и его можно выводить
Console.WriteLine(year);

// Вид 4 Методы которые что-то принимают и что-то возвращают

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4 (int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// string res = Method4(7, "Qwerty  ");
// Console.WriteLine (res);

//  пример с циклом for выведем таблицу умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine ();
// }

// дан текст, задача: пробелы заменить черточками, маленькие "к" заменить на "К", большие "С" заменить на "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char OldValue, char NewValue)
// {
//     string result = string.Empty;

//     int lenght = text.Length;
//     for(int i = 0; i < lenght; i++)
//     {
//         if (text[i] == OldValue)
//         result += NewValue;
//         else
//         result += text[i];
//     }

//     return result;
// }

// string newtext = Replace(text, 'к', 'К');
// Console.WriteLine (newtext);
// Console.WriteLine ();
// newtext = Replace(newtext, ' ', '_');
// Console.WriteLine (newtext);


int [] arr = {1, 1, 4, 3, 2, 6, 7, 9, 9};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array) // сортировка массива от большего к меньшему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = array[i];
        int pos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < min)
            {
                min = array[j];
                pos = j;
            }
        }
        array [pos] = array [i];
        array [i] = min;
    }
}

void SelectionSortB (int[] array) // сортировка массива от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int max = array[i];
        int pos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
                pos = j;
            }
        }
        array [pos] = array [i];
        array [i] = max;
    }
}

PrintArray (arr);
SelectionSortB (arr);
PrintArray (arr);
SelectionSort (arr);
PrintArray (arr);