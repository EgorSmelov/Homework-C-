Random rnd = new Random();

int[] array = new int[8];
{
    for (int i = 0; i < 8; i++)
    {
      for (int j = 0; j < 8; j++)
      {
        array[i] = rnd.Next(10, 99);
        if(array[i] == array[j])
        {
          array[i] += 1;
        }
      }
    }
}


int[,,] arr = new int[2, 2, 2];
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = array[count];
                Console.WriteLine("{3} = arr[{0},{1},{2}]", i, j, k, arr[i, j, k]);
                count ++;
            }
        }
    }
}

