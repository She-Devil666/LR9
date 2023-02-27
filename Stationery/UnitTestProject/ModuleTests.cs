using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Stationery;

namespace UnitTestProject
{
    [TestClass]
    public class ModuleTests
    {
        [TestMethod]
        public void LoginTest1()
        {
            string login = "artkar";
            string paswword = "12345";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest2()
        {
            string login = "artkar";
            string paswword = "123456";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest3()
        {
            string login = "anluko";
            string paswword = "12345";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest4()
        {
            string login = "anluko";
            string paswword = "123456";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest5()
        {
            string login = "elina";
            string paswword = "12345";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest6()
        {
            string login = "zaid";
            string paswword = "12345";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest7()
        {
            string login = "naimo";
            string paswword = "543218";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest8()
        {
            string login = "siherche";
            string paswword = "19470";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest9()
        {
            string login = "bulka";
            string paswword = "anluko";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void LoginTest10()
        {
            string login = "sobaka";
            string paswword = "1234";
            TestMethods test = new TestMethods();
            bool access = test.logintest(login, paswword);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest1()
        {
            string login = "anluko";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "anluko@gmail.com";
            string name = "anluko";
            string surname = "anluko";
            string phone = "89959821621";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest2()
        {
            string login = "view";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "view@gmail.com";
            string name = "view";
            string surname = "view";
            string phone = "84845845385348";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest3()
        {
            string login = "five";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "five@gmail.com";
            string name = "five";
            string surname = "five";
            string phone = "8345678967";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest4()
        {
            string login = "sewenteen";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "sewenteen@gmail.com";
            string name = "sewenteen";
            string surname = "sewenteen";
            string phone = "834567890";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest5()
        {
            string login = "banana";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "banana@gmail.com";
            string name = "banana";
            string surname = "banana";
            string phone = "456789897654";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest6()
        {
            string login = "apple";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "apple@gmail.com";
            string name = "apple";
            string surname = "apple";
            string phone = "845678990651";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest7()
        {
            string login = "cucumber";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "cucumber@gmail.com";
            string name = "cucumber";
            string surname = "cucumber";
            string phone = "84567890987";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest8()
        {
            string login = "sport";
            string paswword = "123456";
            string paswword2 = "123456";
            string email = "sport@gmail.com";
            string name = "sport";
            string surname = "sport";
            string phone = "845678878654";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest9()
        {
            string login = "5678765456";
            string paswword = "1";
            string paswword2 = "123456";
            string email = "hfdalkhrko@gmail.com";
            string name = "hfdalkhrko";
            string surname = "hfdalkhrko";
            string phone = "84567876543";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void SigningTest10()
        {
            string login = "zdcvgbhn";
            string paswword = "123";
            string paswword2 = "123456";
            string email = "zdcvgbhn@gmail.com";
            string name = "zdcvgbhn";
            string surname = "zdcvgbhn";
            string phone = "45678765437";
            TestMethods test = new TestMethods();
            bool access = test.signingtest(login, paswword, paswword2, name, surname, email, phone);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest1()
        {
            string number = "1212121";
            string date = "0923";
            string cvc = "532";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTes2t()
        {
            string number = "12121212121212127536467567541";
            string date = "09.23";
            string cvc = "567";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest3()
        {
            string number = "1212121212121212";
            string date = "09.23";
            string cvc = "567";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest4()
        {
            string number = "1212121212121212";
            string date = "0923567356735674";
            string cvc = "567";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest5()
        {
            string number = "1212121212121212";
            string date = "09.23";
            string cvc = "567236545568623";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest6()
        {
            string number = "1212121212121212823586787564";
            string date = "09.23";
            string cvc = "5675326785678674";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest7()
        {
            string number = "121212";
            string date = "09.23";
            string cvc = "5";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest8()
        {
            string number = "1212121";
            string date = "09.237637876523";
            string cvc = "5677565367357";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest9()
        {
            string number = "121212121";
            string date = "09/fsgkfgk23";
            string cvc = "5679875";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }

        [TestMethod]
        public void buyTest10()
        {
            string number = "121212121";
            string date = "0923";
            string cvc = "567";
            TestMethods test = new TestMethods();
            bool access = test.buytest(number, date, cvc);
            Assert.IsTrue(access);
        }
    }
}
