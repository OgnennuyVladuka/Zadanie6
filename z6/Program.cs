namespace z6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения для первого массива через пробел:");
            string input1 = Console.ReadLine();
            string[] mas1 = input1.Split(' ');
            Console.WriteLine("Введите значения для второго массива через пробел:");
            string input2 = Console.ReadLine();
            string[] mas2 = input2.Split(' ');
            if (mas1.Length == mas2.Length)
            {
                int[] mas11 = new int[mas1.Length];
                int[] mas22 = new int[mas2.Length];
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas11[i] = Convert.ToInt32(mas1[i]);
                }
                for (int i = 0; i < mas2.Length; i++)
                {
                    mas22[i] = Convert.ToInt32(mas2[i]);
                }
                int[] mas3 = new int[mas1.Length];
                Console.WriteLine("Результат:");
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas3[i] = mas11[i] * mas22[i];
                    Console.Write(mas3[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка, длинны введённых массивов чисел не равны.\r\n" +
                    "Перезапустите программу.");
            }
        }
    }
}