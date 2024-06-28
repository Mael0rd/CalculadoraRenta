using CalculadoraSalarialExamen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        private CalculadoraSalarial calculadoraSalarial;

        [TestInitialize]
        public void Setup()
        {
            calculadoraSalarial = new CalculadoraSalarial();
        }

        [TestMethod]
        public void SinHijosSinEsposa()
        {
            decimal salarioBruto = 1350000;
            int hijos = 0;
            bool esposa = false;

            decimal re = 1153105;
            decimal ro = calculadoraSalarial.CalcularSalarioNeto(salarioBruto, hijos, esposa);

            Assert.AreEqual(re, ro);
        }

        [TestMethod]
        public void Con2HijosSinEsposa()
        {
            decimal salarioBruto = 1350000;
            int hijos = 2;
            bool esposa = false;

            decimal re = 1156325;
            decimal ro = calculadoraSalarial.CalcularSalarioNeto(salarioBruto, hijos, esposa);

            Assert.AreEqual(re, ro);
        }

        [TestMethod]
        public void SinHijosConEsposa()
        {
            decimal salarioBruto = 1350000;
            int hijos = 0;
            bool esposa = true;

            decimal re = 1155535;
            decimal ro = calculadoraSalarial.CalcularSalarioNeto(salarioBruto, hijos, esposa);

            Assert.AreEqual(re, ro);
        }

        [TestMethod]
        public void Con2HijosConEsposa()
        {
            decimal salarioBruto = 1350000;
            int hijos = 2;
            bool esposa = true;

            decimal re = 1158755;
            decimal ro = calculadoraSalarial.CalcularSalarioNeto(salarioBruto, hijos, esposa);

            Assert.AreEqual(re, ro);
        }
    }
}
