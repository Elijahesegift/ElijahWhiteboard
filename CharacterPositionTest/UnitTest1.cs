using Microsoft.VisualStudio.TestTools.UnitTesting;

using CharacterPosition;

namespace CharacterPositionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetCharacterPosition_SDZoo_a()
        {
            Assert.AreEqual(2, CharacterPosition.Program.GetCharacterPosition("San Diego Zoo", 'a'));
        }
        [TestMethod]
        public void GetCharacterPosition_SDZoo_S()
        {
            Assert.AreEqual(1, CharacterPosition.Program.GetCharacterPosition("San Diego Zoo", 'S'));
        }
        [TestMethod]
        public void GetCharacterPosition_SDZoo_l()
        {
            Assert.AreEqual(0, CharacterPosition.Program.GetCharacterPosition("San Diego Zoo", 'l'));
        }
        [TestMethod]
        public void GetCharacterPosition_SDZoo_o()
        {
            Assert.AreEqual(9, CharacterPosition.Program.GetCharacterPosition("San Diego Zoo", 'o'));
        }
    }
}