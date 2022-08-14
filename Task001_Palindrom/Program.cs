
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


bool Palindrom(int number)
{
    int rvs_index=0;
    int index=4;
    int[] digits=new int[5];
    int[] rvs_digits=new int[5];
    int same=0;
    
    while (number>0)
    {
       digits[index]=number%10;
       rvs_digits[rvs_index]=number%10;
       number/=10;
       index--;
       rvs_index++;
    }
    
    for (int i=0;i<5;i++)
    {
        if (digits[i]==rvs_digits[i]) {same++;}
    }

    
    return same==5;
   
}


int n=Prompt("enter integer 5 digit 'N':  ");

while(n<10000||n>99999)  {n=Prompt("N must have 5 digits, enter  correct 'N':  ");}

if (Palindrom(n))
{
     Console.WriteLine("Your number is palindrom!");
}

else {Console.WriteLine("Your number is NOT palindrom!");}
