/*Author: Cody Martin
 Class: CTEC 135 Week 5
 Task: Programming Assignment 5

 Unit testing for MyMathConsoleApp class MyMath1

 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyMathConsoleApp;

namespace MyMath1.UnitTests
{
    [TestFixture]
    public class MyMath1Tests
    {
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            Assert.AreEqual(200, MyMathConsoleApp.MyMath1.Add(101, 99));

        }
        [Test]
        public void Add_SumOutsideByteRange_ReturnIncorrectSum()
        {
            Assert.AreEqual(302, MyMathConsoleApp.MyMath1.Add(101, 201));
        }



    }


}
