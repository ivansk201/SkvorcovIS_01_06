using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkvrcovIS_PR32_1;
using System;
using System.Runtime.Remoting.Messaging;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QualityMethod()
        {
            Product product = new Product("NameProduct", 100, 20);
            double quality = product.Quality();
            Assert.AreEqual(5.00, Math.Round(quality, 2));
        }
        [TestMethod]
        public void QualityMethod2forproverkapotomkaklassa()
        {
            int curYear = DateTime.Now.Year;
            ExtendProduct extendProduct = new ExtendProduct("NameExProduct", 150, 30, curYear - 2);
            double quality = extendProduct.Quality();
            double exQuality = 5.00 + 0.5 * 2;
            Assert.AreEqual(exQuality,Math.Round(quality,2));
        }
        [TestMethod]
        public void QualityMethodProverkaKlassPotomkaEsliRaznitsyaVDvaGoda()
        {
            int curYear = DateTime.Now.Year;
            ExtendProduct extendProduct = new ExtendProduct("NameExProduct", 200, 50, curYear - 4);
            double quality = extendProduct.Quality();
            double exQuality = 4 + 1.3 * 4;
            Assert.AreEqual(exQuality, Math.Round(quality, 2));
        }
    }
}
