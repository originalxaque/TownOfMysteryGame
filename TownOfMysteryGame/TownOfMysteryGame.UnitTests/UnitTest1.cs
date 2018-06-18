using NUnit.Framework;

namespace TownOfMysteryGame.UnitTests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void GetName_GotName_ReturnsName()
        {
            // Arrange
            var game = new Game();

            // Act
            var result = game.GetName(null);

            // Assert
            Assert.That(result, Is.NotNull);
        }

        [Test]
        public void GameEnd_IsGameOver_ReturnsTrue()
        {
            var game = new GameTests();
            var result = game.GameEnd();
            Assert.That(result, Is.True);
        }
    }

    [TestFixture]
    public class InventoryTests
    {
        [Test]
        public void CheckWeight_CanPickup_ReturnsTrue()
        {
            var inventory = new Inventory();
            var result = inventory.CheckWeight();
            Assert.That(result, Is.True);
        }
    }

    [TestFixture]
    public class MapTests
    {
        [Test]
        public void CheckMap_CanGoTo_ReturnsTrue()
        {
            var map = new Map();
            var result = map.CheckMap();
            Assert.That(result, Is.True);
        }
    }

    [TestFixture]
    public class InputTests
    {
        [Test]
        public void ValidateInput_IsValid_ReturnsTrue()
        {
            var input = new Input();
            var result = input.ValidateInput();
            Assert.That(result, Is.True);
        }
    }
}
