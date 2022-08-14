/*

Задача 2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

https://zaochnik.com/spravochnik/matematika/vektory/rasstojanie-mezhdu-tochkami/
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


double dist3D(int[]A, int[] B)
{
       return Math.Sqrt(Math.Pow(A[0]-B[0],2)+Math.Pow(A[1]-B[1],2)+Math.Pow(A[2]-B[2],2));    

}


int[] pointA=new int[3];
int[] pointB=new int[3];


pointA[0]=Prompt("enter x of point A:");
pointA[1]=Prompt("enter y of point A:");
pointA[2]=Prompt("enter z of point A:");
pointB[0]=Prompt("enter x of point B:");
pointB[1]=Prompt("enter y of point B:");
pointB[2]=Prompt("enter z of point B:");



Console.WriteLine($"Distance between point A and point B in 3D space is:  {dist3D(pointA, pointB)}");
;
