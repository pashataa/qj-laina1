using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на оценките на първият ученик: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int A = 0; A < n; A++)
            {
                arr[A] = double.Parse(Console.ReadLine());
            }
            int i = 0;
            double sum = 0;
            float average = 0.0F;

            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            average = (float)sum / arr.Length;

            Console.WriteLine("срочната оценка е: " + average);


            Console.Write("Въведете броя на оценките на втория ученик: ");
            int n1 = int.Parse(Console.ReadLine());
            double[] arr1 = new double[n1];
            for (int A1 = 0; A1 < n1; A1++)
            {
                arr1[A1] = double.Parse(Console.ReadLine());
            }
            int i2 = 0;
            double sum1 = 0;
            float average1 = 0.0F;

            for (i2 = 0; i2 < arr1.Length; i2++)
            {
                sum1 += arr1[i2];
            }

            average1 = (float)sum1 / arr1.Length;

            Console.WriteLine("срочната оценка е: " + average1);
            Console.Write("Въведете броя на оценките на третия ученик: ");
            int n2 = int.Parse(Console.ReadLine());
            double[] arr2 = new double[n2];
            for (int A2 = 0; A2 < n2; A2++)
            {
                arr2[A2] = double.Parse(Console.ReadLine());
            }
            int i3 = 0;
            double sum2 = 0;
            float average2 = 0.0F;

            for (i3 = 0; i3 < arr2.Length; i3++)
            {
                sum2 += arr2[i3];
            }

            average2 = (float)sum2 / arr2.Length;

            Console.WriteLine("срочната оценка е: " + average2);
            Console.Write("Въведете броя на оценките на четвъртия ученик: ");
            int n3 = int.Parse(Console.ReadLine());
            double[] arr3 = new double[n3];
            for (int A3 = 0; A3 < n3; A3++)
            {
                arr3[A3] = double.Parse(Console.ReadLine());
            }
            int i4 = 0;
            double sum3 = 0;
            float average3 = 0.0F;

            for (i4 = 0; i4 < arr3.Length; i4++)
            {
                sum3 += arr3[i4];
            }

            average3 = (float)sum3 / arr3.Length;

            Console.WriteLine("срочната оценка е: " + average3);
            Console.Write("Въведете броя на оценките на петия ученик: ");
            int n4 = int.Parse(Console.ReadLine());
            double[] arr4 = new double[n4];
            for (int A4 = 0; A4 < n4; A4++)
            {
                arr4[A4] = double.Parse(Console.ReadLine());
            }
            int i5 = 0;
            double sum4 = 0;
            float average4 = 0.0F;

            for (i5 = 0; i5 < arr4.Length; i5++)
            {
                sum4 += arr4[i5];
            }

            average4 = (float)sum4 / arr4.Length;

            Console.WriteLine("Срочната оценка е: " + average4);
            double lolaverage = average + average1 + average2 + average3 + average4;
            double katcqlo = lolaverage / 5;
            Console.WriteLine("");
            Console.WriteLine("Средният успех на класа е: " + katcqlo);
        }
    }
}
