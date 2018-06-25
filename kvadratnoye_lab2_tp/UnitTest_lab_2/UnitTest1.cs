using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kvadratnoye_lab2_tp;
namespace UnitTest_lab_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //дискриминант больше 0
        {   
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "-4";
            test.textBox2.Text = "5";
            test.textBox3.Text = "-1";
            double expected = 1.000;
            test.result1 = 0;
            test.Button_result(this,e);
            Assert.AreEqual(expected, test.result2);
            expected = 0.25;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod11()//дискриминант больше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "4.21";
            test.textBox2.Text = "10";
            test.textBox3.Text = "-5.075";
            double expected = -2.805;
            test.result1 = 0;
            test.Button_result(this, e);
            test.result1 = Math.Round(test.result1, 3);
            test.result2 = Math.Round(test.result2, 3);
            Assert.AreEqual(expected, test.result2);
            expected = 0.430;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod111()//дискриминант больше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "7";
            test.textBox2.Text = "-20.2";
            test.textBox3.Text = "-12";
            double expected = -0.506;
            test.result1 = 0;
            test.Button_result(this, e);
            test.result1 = Math.Round(test.result1, 3);
            test.result2 = Math.Round(test.result2, 3);
            Assert.AreEqual(expected, test.result2);
            expected = 3.391;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod2()//дискриминант равен 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "1";   
            test.textBox2.Text = "-4";
            test.textBox3.Text = "4";
            double expected = 2.000;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 2.000;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod22()//дискриминант равен 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "1";
            test.textBox2.Text = "-6";
            test.textBox3.Text = "9";
            double expected = 3.000;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 3.000;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod222()//дискриминант равен 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "1";
            test.textBox2.Text = "12";
            test.textBox3.Text = "36";
            double expected = -6.000;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = -6.000;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod3()//дискриминант меньше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "24";
            test.textBox2.Text = "1";
            test.textBox3.Text = "36";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 0;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod33()//дискриминант меньше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "42.214";
            test.textBox2.Text = "1.5";
            test.textBox3.Text = "36";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 0;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod333()//дискриминант меньше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "-42.214";
            test.textBox2.Text = "1.5";
            test.textBox3.Text = "-36";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 0;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod4()//дискриминант меньше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "sa";
            test.textBox2.Text = "ew";
            test.textBox3.Text = "qw";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 0;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod44()//дискриминант меньше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "23";
            test.textBox2.Text = "-";
            test.textBox3.Text = "4";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 0;
            Assert.AreEqual(expected, test.result1);
        }

        [TestMethod]
        public void TestMethod444()//дискриминант меньше 0
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "+4";
            test.textBox2.Text = "-,";
            test.textBox3.Text = "4";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.AreEqual(expected, test.result2);
            expected = 0;
            Assert.AreEqual(expected, test.result1);
        }
    }
}
