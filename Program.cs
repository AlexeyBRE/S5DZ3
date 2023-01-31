// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] num = {3,7,22,2,78};
int max=0;
int min=0;
for(var i=0;i<num.Length;i++)
{
if(num[i]>max)
{
    max=num[i];
}
else if(num[i]<=num[i])
{
    min=num[i];
}
}
string mas = string.Join(" ", num);
Console.Write(mas);
Console.WriteLine($"->{max-min}");
