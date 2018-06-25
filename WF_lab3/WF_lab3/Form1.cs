using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace WF_lab3
{
    public partial class Form1 : Form
    {
        public int N, A, B;
        public int[] arr = new int[1000];
        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
            
        }

        private void button_gener(object sender, EventArgs e)
        {
            if ((int)numericUpDown2.Value > (int)numericUpDown3.Value)
            {
                MessageBox.Show("Не правильно введены границы значений"); //вывод сообщения об ошибке
                return;
            }
            textBox1.Text = null; //очищаем textBox1
            dataGridView1.Rows.Clear(); //очищаем dataGrid
            N = (int)numericUpDown1.Value; //сохраняем размер массива
            Random kek = new Random();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = kek.Next((int)numericUpDown2.Value, (int)numericUpDown3.Value + 1); //генерация массива в диапазоне от A до B
                dataGridView1.Rows.Add(i, arr[i]); //запись в datagrid
            }
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                textBox1.Text += Convert.ToString(arr[i]); //запись в textBox1
                if (i + 1 >= (int)numericUpDown1.Value)
                    break;
                textBox1.Text += ",  "; //разделение запятыми
            }
            button4.Enabled = true;

        }

        private void button_zpf1(object sender, EventArgs e)
        {
            textBox1.Text = null; //очистка textBox1
            dataGridView1.Rows.Clear(); //очистка datagrid
            OpenFileDialog my_open_FileDialog = new OpenFileDialog() //создание экземпляра диалога
            {
                InitialDirectory = "C:\\Users\\VAdiM\\Desktop", //стандартный путь
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*", //фильтр
                RestoreDirectory = true //запоминает где в прошлый раз закрыто было окно диалога
            };


            if (my_open_FileDialog.ShowDialog() == DialogResult.OK) //если открыто успешно - выполняем
            {
                try
                {
                    using (TextReader textReader = new StreamReader(my_open_FileDialog.FileName))
                    {
                        string P;
                        N = 0; //Обнуляем размер
                        for (;;)
                        {
                            P = textReader.ReadLine(); //получаем число из файла
                            if (P == null) //проверка на окончание
                                break;
                            arr[N] = Convert.ToInt32(P);
                            dataGridView1.Rows.Add(N, arr[N]); //запись в dataGrid
                            N++; //считаем размер массива
                        }
                        for (int O = 0; O < N; O++)
                        {
                            textBox1.Text += Convert.ToString(arr[O]); //запись в textBox1
                            if (O + 1 >= N)
                                break;
                            textBox1.Text += ",  "; //разделение запятыми
                        }
                        textReader.Close(); //закрытие потока 
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка: Выберите верный файл формата .txt с корректными данными"); //вывод сообщения об ошибке
                }
            }
        }



        private void button_schf1(object sender, EventArgs e)
        {
            SaveFileDialog my_save_FileDialog = new SaveFileDialog() //создание экземпляра диалога
            {
                FileName = ".txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" //фильтр
            };
            if (my_save_FileDialog.ShowDialog() == DialogResult.OK) //если открыто успешно
            {
                try
                {
                    using (TextWriter textWriter = new StreamWriter(my_save_FileDialog.FileName))
                    {
                        for (int i = 0; i < N; i++)
                            textWriter.WriteLine(arr[i]); //запись в файл
                        textWriter.Close(); //закрытие потока
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка: Выберите верный файл формата .txt"); //вывод сообщения об ошибке
                }

            }
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_rsch(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                First();
                return;
            }
            else if (radioButton2.Checked == true)
            {
                Second();
                return;
            }
            else if (radioButton3.Checked == true)
            {
                Thrid();
                return;
            }
            else if (radioButton4.Checked == true)
            {
                Four();
                return;
            }
        }
        public void First()//дисперсия и мат ожидание
        {
            double result = 0; //счетчик результата
            for (int i = 0; i <= N - 1; i++)
                result += arr[i];
            double Sr = result / N; //ожидание

            result = 0;
            for (int i = 0; i <= N - 1; i++)
                result += (arr[i] - Sr) * (arr[i] - Sr);
            double D = result / (N - 1); //дисперсия
            textBox2.Text = $"Мат ожидание: {Sr}, Дисперсия: {D:0.###}";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
        }

        public void Second()//сортировка
        {
            textBox2.Text = null;
            dataGridView1.Rows.Clear();
            Array.Sort(arr, 0, N);
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows.Add(i, arr[i]); //запись в datagrid
            }
            for (int i = 0; i < N; i++)
            {
                textBox2.Text += Convert.ToString(arr[i]); //запись в текст бокс
                if (i + 1 >= N)
                    break;
                textBox2.Text += ",  "; //разделение запятой

            }
        }
        public void Thrid()//сума и количество в диапазоне
        {
            textBox2.Text = null;
            int C1 = (int)numericUpDown4.Value;
            int C2 = (int)numericUpDown5.Value;
            if (C2 < C1)
            {
                MessageBox.Show("Не корректно введены либо C1, либо C2"); //вывод сообщения об ошибке
            }
            int summa = 0, kolvo = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > C1 && arr[i] < C2) //проверка на условие
                {
                    summa += arr[i];
                    kolvo++;
                }
            }
            textBox2.Text = $"Колличество: {kolvo} Сумма: {summa}"; //запись в окно textBox
        }
        public void Four()//нахождение простых чисел
        {
            textBox2.Text = null;
            int prostoe = 0;
            for (int k = 0; k < N; k++)
            {
                bool prost = true;
                for (int i = 2; i <= arr[k] / 2; i++) //метод пробных делений
                {
                    if (arr[k] % i == 0)
                    {
                        prost = false;
                        break;
                    }
                }
                if (prost)
                {
                    if (arr[k] != 1 && arr[k] != 0) //отсеивание  1 и 0
                        prostoe++;
                }
            }
            textBox2.Text = Convert.ToString(prostoe); //запись в окно textBox

        }
    }
}
