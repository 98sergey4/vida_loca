using System;
using System.Windows.Forms;

namespace kvadratnoye_lab2_tp
{
    public partial class Form1 : Form
    {
        public double a, b, c, D, result1,result2; //поля

        private void textBox1_TextChanged(object sender, EventArgs e) //событие для обработки правильности ввода
        {
            TextBox thisTextBox = (sender as TextBox);//создание экземпляра textBox и определение его как sender
            double number;
            if (thisTextBox.Text == "" ||thisTextBox.Text=="-"|| thisTextBox.Text == "+")
                return;
            if (!double.TryParse(thisTextBox.Text, out number)) //проверка на правильность ввода
            {
                thisTextBox.Text = "";
                MessageBox.Show("Вводить можно только корректные данные(цифры от 0 до 9 и символы '+', '-')");
                return;
            }
        }

        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("US"); //меняем глобализацию
            InitializeComponent();

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //событие для обработки правильности ввода
        {
            TextBox thisTextBox = (sender as TextBox);
            if (e.KeyChar == '+' || e.KeyChar == '-' || ((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == 8 || e.KeyChar == '.')
            {
                if ((e.KeyChar == '.' && thisTextBox.Text.LastIndexOf('.')!=-1)||((thisTextBox.Text.IndexOf('-') == 0 || thisTextBox.Text.IndexOf('+') == 0)&& e.KeyChar == '.' && thisTextBox.SelectionStart==1))
                {
                    e.Handled = true; //проверка на правильность вввода точки
                    return;
                }
              

                if (thisTextBox.Text.Length >= 10 && e.KeyChar != 8) //проверка на макс кол-во символов
                {
                    e.Handled = true;
                    return;
                }
                 
                if (thisTextBox.SelectionStart == 0 && (thisTextBox.Text.LastIndexOf('+') != -1 || thisTextBox.Text.LastIndexOf('-') != -1 || e.KeyChar == '.')) //проверка на ввод запятой после символов + или -
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '+' && (thisTextBox.SelectionStart != 0 || (thisTextBox.Text.LastIndexOf('+') != -1 || thisTextBox.Text.LastIndexOf('-') != -1))) //проверка на правильность ввода символа +
                {
                    e.Handled = true;
                    return;
                    }

                if (e.KeyChar == '-' && (thisTextBox.SelectionStart != 0 || (thisTextBox.Text.LastIndexOf('-') != -1 || thisTextBox.Text.LastIndexOf('+') != -1))) //проверка на правильность ввода символа -
                {
                    e.Handled = true;
                    return;
                }

            }
                else
                {
                e.Handled = true; // все остальные символы - запрещаем
            }
        }

        public void Button_result(object sender, EventArgs e) //кнопка для подсчета результата
        {
            Kvadratnoye Obraz = new Kvadratnoye(); //создание объкта класса
            if (textBox1.Text == "" || textBox1.Text == "-" || textBox1.Text == "+") //проверка на правильность ввода
            {
                MessageBox.Show("Вы не ввели первое число");
                return;
            }
            if (textBox2.Text == "" || textBox2.Text == "-" || textBox2.Text == "+")//проверка на правильность ввода
            { 
                MessageBox.Show("Вы не ввели второе число");
                return;
            }
            if (textBox3.Text == "" || textBox3.Text == "-" || textBox3.Text == "+")//проверка на правильность ввода
            { 
                MessageBox.Show("Вы не ввели третье число");
                return;
            }
            if (textBox1.Text=="0") //проверка на правильность ввода
            {
                MessageBox.Show("Первое число не может быть нулем");
                return;
            }
            a = Convert.ToDouble(textBox1.Text); //берем первое число
            b = Convert.ToDouble(textBox2.Text);//берем второе число
            c = Convert.ToDouble(textBox3.Text);//берем третье число

            D = b * b - 4 * a * c; //считаем дискриминант
            if (radio_button_obrabotchik.Checked) //если установлено - из обработчика
            {
                if (D < 0)
                {
                    MessageBox.Show("Корней нет. Дискриминант меньше 0"); //проверка дискриминанта
                }
                else
                {
                    result1 = (-b + Math.Sqrt(D)) / (2 * a);
                    result2 = (-b - Math.Sqrt(D)) / (2 * a); //рассчет результатов
                    textBox5.Text = result1.ToString("F3");
                    textBox6.Text = result2.ToString("F3"); //запись результатов в окно textBox
                    return;
                }
            }
            if (radio_button_form_method.Checked) //если установлено - из метода формы
            {
                GetResult(); //вызов метода
                return;
            }
            if (radio_button_class_method.Checked) //если установлено - из метода класса
            {
                Obraz.GetResult_Class(a, b, c, D, ref result1, ref result2); //вызов метода класса
                textBox5.Text = result1.ToString("F3"); //запись результатов
                textBox6.Text = result2.ToString("F3");
                return;
            }
        }

        private void Button_Clear(object sender, EventArgs e)//кнопка для очистки данных
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null; //очистка данных
            textBox5.Text = null;
            textBox6.Text = null;
        }

        public void GetResult() //метод расчета результатов в методе класса
        {
            if (D < 0) //если дискриминант меньше 0
            {
                MessageBox.Show("Корней нет. Дискриминант меньше 0");
            }
            else
            {
                result1 = (-b + Math.Sqrt(D)) / (2 * a);//расчет результатов
                result2 = (-b - Math.Sqrt(D)) / (2 * a);
                textBox5.Text = result1.ToString("F3"); 
                textBox6.Text = result2.ToString("F3");//запись результатов
            }
        }
    }

    public class Kvadratnoye //класс для нахождения корней
    {
        public void GetResult_Class (double a, double b, double c, double D, ref double result1, ref double result2) //метод для нахождения корней в классе
        {
            if (D < 0)
            {
                MessageBox.Show("Корней нет. Дискриминант меньше 0"); //проверка на дискриминант меньше 0
            }
            else
            {
                result1 = (-b + Math.Sqrt(D)) / (2 * a); //находим результат
                result2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
        }
    }
}
