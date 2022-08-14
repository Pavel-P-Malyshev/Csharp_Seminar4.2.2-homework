


//ввод набора чисел с консоли строкой
int[] ParseArray(string message)
{
Console.WriteLine(message);
string[] nums = Console.ReadLine().Split(new char[] { ',' });
int[] intArray = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    intArray[i] = int.Parse(nums[i]);
}
 return intArray;

}


/*
Внешний цикл начинает работу со второго элемента массива. 
Запоминаем значение второго элемента массива. 
Во внутреннем цикле сравниваем каждый предыдущий элемент массива с текущим и, 
при необходимости, меняем их местами до тех пор, пока не дойдем до начала цикла
 или пока не встретится элемент менее текущего. В результате массив отсортируется по возрастанию.
*/

int[] InsertionSort(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int j = i;
        while (j > 0 && result[j - 1] > array[i])
        {
            result[j] = result[j - 1];
            j--;
        }
        result[j] = array[i];
    }
    return result;
}



int[] input=ParseArray("Введите через запятую целые числа и нажмите Enter");
int[] output=InsertionSort(input);

Console.WriteLine("список, cортированный методом вставки : ");
for (int i=0;i<output.Length;i++)
{
   if(i==output.Length-1) Console.Write($"{output[i]}.");
    else {Console.Write($"{output[i]},");}
}

    
