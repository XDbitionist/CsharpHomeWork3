/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число, чтобы посмотреть таблицу кубов чисел от 1 до заданного числа(включительно): ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int length = cube.Length;
    for (int i = 0; i < length; i++)
    {
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 1; j < count; j++)
    {
        Console.Write(array[j] + "; ");
    }

}
int[] mass = new int[cube+1];
Cube(mass);
PrintArray(mass);