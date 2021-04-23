using System.Collections.Generic;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1_Task1()
        {
            List<object> res = ListFilterer.GetIntegersFromList(new List<object>() {1, 2, 'a', 'b'});
            List<object> answ = new List<object>() {1, 2};
            
            Assert.AreEqual(res, answ);
        }

        [Test]
        public void Test2_Task1()
        {
            List<object> res = ListFilterer.GetIntegersFromList(new List<object>() {1, 2, 'a', 'b', 0, 15});
            List<object> answ = new List<object>() {1, 2, 0, 15};
            
            Assert.AreEqual(res, answ);
        }
        
        [Test]
        public void Test3_Task1()
        {
            List<object> res = ListFilterer.GetIntegersFromList(new List<object>(){1,2,'a','b', "aasf",'1',"123",231});
            List<object> answ = new List<object>() {1, 2, 231};
            
            Assert.AreEqual(res, answ);
        }

        [Test]
        public void Test1_Task2()
        {
            char res = ListFilterer.FirstNonRepeatingLetter("stress");
            char answ = 't';
            
            Assert.AreEqual(res, answ);
        }
        
        [Test]
        public void Test2_Task2()
        {
            char res = ListFilterer.FirstNonRepeatingLetter("sTreSS");
            char answ = 'T';
            
            Assert.AreEqual(res, answ);
        }
        
        [Test]
        public void Test3_Task2()
        {
            char res = ListFilterer.FirstNonRepeatingLetter("abooba");
            char answ = '\0';
            
            Assert.AreEqual(res, answ);
        }

        [Test]
        public void Test1_Task3()
        {
            Assert.AreEqual(IntegersTests.DigitalRoot(16), 7);
        }
        
        [Test]
        public void Test2_Task3()
        {
            Assert.AreEqual(IntegersTests.DigitalRoot(942), 6);
        }
        
        [Test]
        public void Test3_Task3()
        {
            Assert.AreEqual(IntegersTests.DigitalRoot(493193), 2);
        }

        [Test]
        public void Test1_Task4()
        {
            List<int> arr = new List<int>() {1, 3, 6, 2, 2, 0, 4, 5};
            int target = 5;

            int res = IntegersTests.CountNumbersPairs(arr, target);
            Assert.AreEqual(res, 4);
        }

        [Test]
        public void Test2_Task4()
        {
            List<int> arr = new List<int>() {1, 3, 6, 2, 2, 0, 4, 5, 5, 4 ,2};
            int target = 7;

            int res = IntegersTests.CountNumbersPairs(arr, target);
            Assert.AreEqual(res, 9);
        }

        [Test]
        public void Task1_Task5()
        {
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string res = ListFilterer.OrderPeople(s);

            string answ =
                "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.AreEqual(res, answ);
        }
    }
}