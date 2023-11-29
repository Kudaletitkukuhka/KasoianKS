void PrintArray(string[] array)
{
     System.Console.Write("{");
     for (int i = 0; i < array.Length; i++)
     {
          System.Console.Write($"{array[i]}, ");
     }
     System.Console.Write("\b\b}");
     System.Console.WriteLine();
}

string[] NewArray(int size)
{
     string[] array = new string[size];
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = Convert.ToString(Console.ReadLine());
     }
     return array;
}

string[] CheckFor3(string[] array)
{
     int size = 0;
     for (int k = 0; k < array.Length; k++)
     {
          if (array[k].Length<=3) size++;
     }
     string[] resulArray = new string[size];
     int i = 0;
     int j = 0;
     while(i<array.Length)
     {
          if (array[i].Length<=3)
          {
               resulArray[j] = array[i];
               i++;
               j++;
          }
          else i++;
     }
     return resulArray;
}

System.Console.WriteLine("Нажмите Enter, если хотите ввести массив вручную.\nВведите Y и нажмите Enter, если хотите использовать встроенный массив.");
string a = Convert.ToString(Console.ReadLine());
if(a == "Y" || a == "y") 
{
     string [] defArray = new string[4] {"002df0","2glss","jfj","345"};
     PrintArray(defArray);
     System.Console.Write("Массив с элементами длиной в 3 символа и меньше: ");
     PrintArray(CheckFor3(defArray));
}
else 
{
     System.Console.Write("Количество элементов в вашем массиве:\t");;
     int size = Convert.ToInt32(Console.ReadLine());
     string[] userArray = NewArray(size);
     System.Console.Write("Вы ввели массив: ");
     PrintArray(userArray);
     System.Console.Write("Массив с элементами длиной не больше 3 символов: ");
     PrintArray(CheckFor3(userArray));
}
