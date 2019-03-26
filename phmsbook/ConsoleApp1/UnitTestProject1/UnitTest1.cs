using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            void Create1(int x, int y)//加法
            {
                int z = x + y;
                Console.WriteLine(x + "+" + y + "=" + z);
            }
            void Create2(int x, int y)//减法
            {
                int z = x + y;
                Console.WriteLine(z + "-" + y + "=" + x);
            }
           void Create3(int x, int y)//乘法
            {
                int z = x * y;
                Console.WriteLine(x + "*" + y + "=" + z);
            }
            void Create4(int x, int y)//除法
            {
                int z = x * y;
                Console.WriteLine(z + "/" + y + "=" + x);
            }

        }
    }
}
