using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо рядок і розбиваємо його на числа
            string[] numbersStr = txt_source_array.Text.Split(' ');
            double[] numbers = new double[numbersStr.Length];
            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers[i] = Convert.ToDouble(numbersStr[i]);
            }

            // Розрахунок добутку елементів масиву з парними номерами
            double product = 1;
            for (int i = 0; i < numbers.Length; i += 2)
            {
                product *= numbers[i];
            }
            txt_multiplication.Text = product.ToString();

            // Розрахунок суми елементів масиву, розташованих між першим і останнім нульовими елементами
            int firstZeroIndex = Array.IndexOf(numbers, 0);
            int lastZeroIndex = Array.LastIndexOf(numbers, 0);
            double sum = 0;
            if (firstZeroIndex != -1 && lastZeroIndex != -1)
            {
                for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
                {
                    sum += numbers[i];
                }
            }
            txt_sum_elements.Text = sum.ToString();

            // Перетворення масиву
            // Створюємо два допоміжні масиви для додатніх та від'ємних елементів
            double[] positiveNumbers = new double[numbers.Length];
            double[] negativeNumbers = new double[numbers.Length];
            int positiveIndex = 0;
            int negativeIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0 || numbers[i] == 0)
                {
                    positiveNumbers[positiveIndex] = numbers[i];
                    positiveIndex++;
                }
                else
                {
                    negativeNumbers[negativeIndex] = numbers[i];
                    negativeIndex++;
                }
            }

            // Об'єднуємо допоміжні масиви в один
            for (int i = 0; i < positiveIndex; i++)
            {
                numbers[i] = positiveNumbers[i];
            }
            for (int i = 0; i < negativeIndex; i++)
            {
                numbers[positiveIndex + i] = negativeNumbers[i];
            }

            // Виводимо результат
            txt_sorted_array.Text = string.Join("  ", numbers);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // отримуємо розміри масиву від користувача
            int rows = int.Parse(txt_rows.Text);
            int cols = int.Parse(txt_cols.Text);

            // створюємо масив та заповнюємо його випадковими числами
            int[,] array = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                }
            }

            // виводимо масив у textBox
            txt_array.Text = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    txt_array.Text += array[i, j] + "\t";
                }
                txt_array.Text += Environment.NewLine;
            }

            // перевіряємо наявність парних чисел у верхньому лівому або нижньому лівому куті
            bool hasEvenNumbers = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i == 0 || i == rows - 1) && j == 0 && array[i, j] % 2 == 0)
                    {
                        hasEvenNumbers = true;
                        break;
                    }
                }
                if (hasEvenNumbers)
                {
                    break;
                }
            }

            // виводимо результат перевірки наявності парних чисел
            if (hasEvenNumbers)
            {
                txt_result1.Text = "";
                txt_result1.Text += "У верхньому лівому або нижньому лівому куті є парні числа" + Environment.NewLine;
            }
            else
            {
                txt_result1.Text = "";
                txt_result1.Text += "У верхньому лівому або нижньому лівому куті немає парних чисел" + Environment.NewLine;
            }

            // перевіряємо наявність чисел, що закінчуються нулем, у верхньому правому або нижньому правому куті
            bool hasNumbersEndingWithZero = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i == 0 || i == rows - 1) && j == cols - 1 && array[i, j] % 10 == 0)
                    {
                        hasNumbersEndingWithZero = true;
                        break;
                    }
                }
                if (hasNumbersEndingWithZero)
                {
                    break;
                }
            }
            // виводимо результат перевірки наявності чисел, що закінчуються нулем
            if (hasNumbersEndingWithZero)
            {
                txt_result2.Text = "";
                txt_result2.Text += "У верхньому правому або нижньому правому куті є числа, що закінчуються нулем";
            }
            else
            {
                txt_result2.Text = "";
                txt_result2.Text += "У верхньому правому або нижньому правому куті немає чисел, що закінчуються нулем";
            }
        }
    }
}
