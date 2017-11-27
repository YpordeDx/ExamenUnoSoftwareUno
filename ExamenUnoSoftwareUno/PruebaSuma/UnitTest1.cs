using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppParaPruebaIngSoftware;

namespace PruebaSuma
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarPromedio()
        {
            Operation operation = new Operation();
            float xpectedR = 13.40F;
            float actualR;
            actualR = operation.promedioNotas(10,11.2F,19);
            Assert.AreEqual(xpectedR,actualR);
        }

        [TestMethod]
        public void VerificarPromedioNeg()
        {
            Operation operation = new Operation();
            float xpectedR = -1F;
            float actualR;
            actualR = operation.promedioNotas(10, -11, -9);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioStrg()
        {
            Operation operation = new Operation();
            float xpectedR = -2;
            float actualR;
            actualR = operation.promedioNotas(float.Parse("s"), float.Parse("p"), float.Parse("o"));
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioVacio()
        {
            Operation operation = new Operation();
            float xpectedR = -2;
            float actualR;
            actualR = operation.promedioNotas(float.Parse(null), float.Parse(null), float.Parse(null));
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioVeinte()
        {
            Operation operation = new Operation();
            float xpectedR = 20F;
            float actualR;
            actualR = operation.promedioNotas(20,20,20);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioCeros()
        {
            Operation operation = new Operation();
            float xpectedR = 0F;
            float actualR;
            actualR = operation.promedioNotas(0,0,0);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioNegI()
        {
            Operation operation = new Operation();
            float xpectedR = -1;
            float actualR;
            actualR = operation.promedioNotas(-1,0,12);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioNegC()
        {
            Operation operation = new Operation();
            float xpectedR = -1;
            float actualR;
            actualR = operation.promedioNotas(10,-1,20);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioNegD()
        {
            Operation operation = new Operation();
            float xpectedR = 13.40F;
            float actualR;
            actualR = operation.promedioNotas(20,20,-1);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void VerificarPromedioDC()
        {
            Operation operation = new Operation();
            float xpectedR = 12.07F;
            float actualR;
            actualR = operation.promedioNotas(7.2F,20,9);
            Assert.AreEqual(xpectedR, actualR);
        }


        [TestMethod]
        public void pasaMateriaVeinte()
        {
            Operation operation = new Operation();
            string xpectedR = "G";
            string actualR;
            actualR = operation.pasaMateria(20);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaCero()
        {
            Operation operation = new Operation();
            string xpectedR = "P";
            string actualR;
            actualR = operation.pasaMateria(0);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaDoce()
        {
            Operation operation = new Operation();
            string xpectedR = "S";
            string actualR;
            actualR = operation.pasaMateria(12.25F);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaCatorce()
        {
            Operation operation = new Operation();
            string xpectedR = "G";
            string actualR;
            actualR = operation.pasaMateria(14);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaDecimalP()
        {
            Operation operation = new Operation();
            string xpectedR = "P";
            string actualR;
            actualR = operation.pasaMateria(11.99F);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaString()
        {
            Operation operation = new Operation();
            string xpectedR = "N";
            string actualR;
            actualR = operation.pasaMateria(float.Parse("Hola"));
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaDecimalNulo()
        {
            Operation operation = new Operation();
            string xpectedR = "V";
            string actualR;
            actualR = operation.pasaMateria(float.Parse(null));
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaDecimalS()
        {
            Operation operation = new Operation();
            string xpectedR = "S";
            string actualR;
            actualR = operation.pasaMateria(13.9F);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaDecimalG()
        {
            Operation operation = new Operation();
            string xpectedR = "G";
            string actualR;
            actualR = operation.pasaMateria(14.10F);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaNegativo()
        {
            Operation operation = new Operation();
            string xpectedR = "N";
            string actualR;
            actualR = operation.pasaMateria(-3);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaMateriaSimbolos()
        {
            Operation operation = new Operation();
            string xpectedR = "N";
            string actualR;
            actualR = operation.pasaMateria(float.Parse("*"));
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreTres()
        {
            Operation operation = new Operation();
            string xpectedR = "Pasa";
            string actualR;
            actualR = operation.pasaSemestre("G", "G", "G");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreDos()
        {
            Operation operation = new Operation();
            string xpectedR = "Pasa";
            string actualR;
            actualR = operation.pasaSemestre("G", "G", "P");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreUno()
        {
            Operation operation = new Operation();
            string xpectedR = "No Pasa";
            string actualR;
            actualR = operation.pasaSemestre("G", "P", "P");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreSup()
        {
            Operation operation = new Operation();
            string xpectedR = "Supletorio";
            string actualR;
            actualR = operation.pasaSemestre("G", "S", "S");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreNega()
        {
            Operation operation = new Operation();
            string xpectedR = "Entrada No Valida";
            string actualR;
            actualR = operation.pasaSemestre("N", "S", "P");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreNegaDos()
        {
            Operation operation = new Operation();
            string xpectedR = "Entrada No Valida";
            string actualR;
            actualR = operation.pasaSemestre("N", "N", "P");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreNegaTres()
        {
            Operation operation = new Operation();
            string xpectedR = "Entrada No Valida";
            string actualR;
            actualR = operation.pasaSemestre("N", "N", "N");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreNegaDer()
        {
            Operation operation = new Operation();
            string xpectedR = "Entrada No Valida";
            string actualR;
            actualR = operation.pasaSemestre("G", "G", "N");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreNegaCenter()
        {
            Operation operation = new Operation();
            string xpectedR = "Entrada No Valida";
            string actualR;
            actualR = operation.pasaSemestre("G", "N", "G");
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void pasaSemestreNegaPierde()
        {
            Operation operation = new Operation();
            string xpectedR = "Entrada No Valida";
            string actualR;
            actualR = operation.pasaSemestre("P", "N", "P");
            Assert.AreEqual(xpectedR, actualR);
        }
    }
}
