/*

Задача 3

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


List<int> CubesList(int N)
{
    int index=1;

    List<int> result=new List<int>();
    while (index<=N)
    {
       result.Add((int)Math.Pow(index,3));
       index++;
    }

    return result;
   
}


int n=Prompt("enter integer 'N':  ");

while(n<1)  {n=Prompt("N cannot be less than 1, enter integer 'N':  ");}

List<int> answer=new List<int>();
answer=CubesList(n);

Console.Write("Cubes list of natural numbers between 1 and N is:  ");
for(int i=0;i<answer.Count;i++)
{
    if(i==answer.Count-1) Console.Write($"{answer[i]}.");
    else {Console.Write($"{answer[i]}, ");}
    
}

