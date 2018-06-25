using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WF_lab3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod4() //рассчет мат ожидания и дисперсии
        {
            Form1 test = new Form1();
            test.arr[0] = 2;
            test.arr[1] = 9;
            test.arr[2] = 26;
            test.arr[3] = 38;
            test.N = 4;
            string expected = "Мат ожидание: 18,75, Дисперсия: 266,25";
            test.First();
            Assert.AreEqual(expected, test.textBox2.Text);
        }

        [TestMethod]
        public void TestMethod44() //рассчет мат ожидания и дисперсии
        {
            Form1 test = new Form1();
            test.arr[0] = -20;
            test.arr[1] = 4;
            test.arr[2] = 600;
            test.arr[3] = -1502;
            test.N = 4;
            string expected = "Мат ожидание: -229,5, Дисперсия: 801913";
            test.First();
            Assert.AreEqual(expected, test.textBox2.Text);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Form1 test = new Form1();
            test.arr[0] = 1;
            test.arr[1] = 4;
            test.arr[2] = -5;
            test.arr[3] = 2;
            test.N = 4;
            string expected = "-5,  1,  2,  4";
            test.Second();
            Assert.AreEqual(expected, test.textBox2.Text);
        }
        [TestMethod]
        public void TestMethod11() //проверка на сортировку массива по возрастанию
        {
            Form1 test = new Form1();
            test.arr[0] = 100;
            test.arr[1] = -45;
            test.arr[2] = 11;
            test.arr[3] = -999;
            test.N = 4;
            string expected = "-999,  -45,  11,  100";
            test.Second();
            Assert.AreEqual(expected, test.textBox2.Text);
        }
        [TestMethod]
        public void TestMethod2() //проверка на кол-во чисел меньших и больших с1,с2
        {
            Form1 test = new Form1();
            test.arr[0] = 100;
            test.arr[1] = -45;
            test.arr[2] = 11;
            test.arr[3] = -999;
            test.N = 4;
            test.numericUpDown4.Value = -46;
            test.numericUpDown5.Value = 101;
            string expected = "Колличество: 3 Сумма: 66";
            test.Thrid();
            Assert.AreEqual(expected, test.textBox2.Text);
        }
        [TestMethod]
        public void TestMethod22() //проверка на кол-во чисел меньших и больших с1,с2
        {
            Form1 test = new Form1();
            test.arr[0] = 9;
            test.arr[1] = 5;
            test.arr[2] = 19;
            test.arr[3] = 4;
            test.N = 4;
            test.numericUpDown4.Value = 4;
            test.numericUpDown5.Value = 10;
            string expected = "Колличество: 2 Сумма: 14";
            test.Thrid();
            Assert.AreEqual(expected, test.textBox2.Text);
        }
        [TestMethod]
        public void TestMethod3() //нахождения кол-ва простых чисел методом пробных делений
        {
            Form1 test = new Form1();
            test.arr[0] = 9;
            test.arr[1] = 5;
            test.arr[2] = 19;
            test.arr[3] = 4;
            test.N = 4;
            string expected = "2";
            test.Four();
            Assert.AreEqual(expected, test.textBox2.Text);
        }
        [TestMethod]
        public void TestMethod33() //нахождения кол-ва простых чисел методом пробных делений
        {
            Form1 test = new Form1();
            test.arr[0] = 2;
            test.arr[1] = 9;
            test.arr[2] = 26;
            test.arr[3] = 38;
            test.N = 4;
            string expected = "1";
            test.Four();
            Assert.AreEqual(expected, test.textBox2.Text);
        }
    }
}
