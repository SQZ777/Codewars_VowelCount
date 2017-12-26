using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_VowelCount
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_a_Should_Be_1()
        {
            Assert.AreEqual(1, Kata.GetVowelCount("a"));
        }

        [TestMethod]
        public void Input_aabba_Should_Be_3()
        {
            Assert.AreEqual(3, Kata.GetVowelCount("aabba"));
        }

        [TestMethod]
        public void Input_AaAaAa_Should_Be_3()
        {
            Assert.AreEqual(3, Kata.GetVowelCount("AaAaAa"));
        }

        [TestMethod]
        public void Input_bbb_Should_Be_0()
        {
            Assert.AreEqual(0, Kata.GetVowelCount("bbb"));
        }

        [TestMethod]
        public void Input_e_Should_Be_1()
        {
            Assert.AreEqual(1, Kata.GetVowelCount("e"));
        }

        [TestMethod]
        public void Input_ae_Should_Be_2()
        {
            Assert.AreEqual(2, Kata.GetVowelCount("ae"));
        }

        [TestMethod]
        public void Input_eeee_Should_Be_4()
        {
            Assert.AreEqual(4, Kata.GetVowelCount("eeee"));
        }

        [TestMethod]
        public void Input_i_Should_Be_1()
        {
            Assert.AreEqual(1, Kata.GetVowelCount("i"));
        }

        [TestMethod]
        public void Input_iaia_Should_Be_4()
        {
            Assert.AreEqual(4, Kata.GetVowelCount("iaia"));
        }

        [TestMethod]
        public void Input_o_Should_Be_1()
        {
            Assert.AreEqual(1, Kata.GetVowelCount("o"));
        }

        [TestMethod]
        public void Input_ooo_Should_Be_3()
        {
            Assert.AreEqual(3, Kata.GetVowelCount("ooo"));
        }

        [TestMethod]
        public void Input_u_Should_Be_1()
        {
            Assert.AreEqual(1, Kata.GetVowelCount("u"));
        }

        [TestMethod]
        public void Input_uaioe_Should_Be_5()
        {
            Assert.AreEqual(5, Kata.GetVowelCount("uaioe"));
        }


    }
}
