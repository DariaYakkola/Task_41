Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
  Console.Write("Введите элемент массива: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
  if (array[i] > 0)
  {
    count+=1;
  }
}
Console.WriteLine($" В массиве [ {String.Join(" ", (array))} ] количество элементов больше 0 будет {count}");
