int[] array = {13, 29, 37, 49, 13, 64, 37, 85};

int n = array.Length;
int find = 13;

int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
      Console.WriteLine(index);
      break;
  }

  index++;
}