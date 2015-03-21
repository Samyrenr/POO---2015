using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using poo_paint;

namespace Teste01Poo
{
    [TestClass]
    public class TesteRetangulo
    {
        [TestMethod]
        public void testaimprime()
        {
            Retangulo r1 = new Retangulo(5, 6, 7, 8);
            Assert.AreEqual("retangulo[x:5,y:6,l:7,a:8]", r1.imprime());

            Retangulo r2 = new Retangulo(5, 5, 10, 200);
            Assert.AreEqual("retangulo[x:5,y:5,l:10,a:200]", r2.imprime());
        }
    }
}
