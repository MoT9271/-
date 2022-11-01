using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var form3 = new Vihlop.Form3();
            var form2 = new Vihlop.Form2();
            form2.FullNameBox.Text = "aboba";
            form2.button1_Click(0, null);
            form3.button1_Click(0, null);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var form3 = new Vihlop.Form3();
            var form2 = new Vihlop.Form2();
            form2.FullNameBox.Text = "Киселев";
            form2.button1_Click(0, null);
            form3.textBox1.Text = "один";
            form3.button1_Click(0, null);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var form3 = new Vihlop.Form3();
            var form2 = new Vihlop.Form2();
            form2.FullNameBox.Text = "Киселев";
            form2.button1_Click(0, null);
            form3.textBox1.Text = "-1";
            form3.button1_Click(0, null);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var form3 = new Vihlop.Form3();
            var form2 = new Vihlop.Form2();
            form2.FullNameBox.Text = "Киселев";
            form2.button1_Click(0, null);
            form3.textBox1.Text = "1";
            form3.button1_Click(0, null);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var form3 = new Vihlop.Form3();
            var form2 = new Vihlop.Form2();
            form2.FullNameBox.Text = "Киселев";
            form2.button1_Click(0, null);
            form3.textBox1.Text = "100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            form3.button1_Click(0, null);
        }

    }
}
