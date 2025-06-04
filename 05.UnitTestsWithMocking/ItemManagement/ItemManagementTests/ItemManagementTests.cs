using NUnit.Framework;
using Moq;
using ItemManagementApp.Services;
using ItemManagementLib.Repositories;
using ItemManagementLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace ItemManagement.Tests
{
    [TestFixture]
    public class ItemServiceTests
    {
        private Mock<IItemRepository> _mockRepository;
        private ItemService _itemService;

        [SetUp]
        public void Setup()
        {
            // Arrange: Create a mock instance of IItemRepository
           _mockRepository = new Mock<IItemRepository>();

            // Instantiate ItemService with the mocked repository
            _itemService = new ItemService(_mockRepository.Object);
            

        }

        [Test]
        public void AddItem_ShouldCallAddItemOnRepository()
        {
            // Act: Call AddItem on the service
            
            _itemService.AddItem("New Item");

            // Assert: Verify that AddItem was called on the repository
            _mockRepository.Verify(repo => repo.AddItem(It.IsAny<Item>()), Times.Once);

        }

        [Test]
        public void GetAllItems_ShouldReturnAllItems()
        {
            var items = new List<Item>() 
            {
              new Item {Id = 1, Name = "Item 1"},
              new Item {Id = 2, Name = "Item 2"}
            };

            _mockRepository.Setup(repo => repo.GetAllItems()).Returns(items);

            var result = _itemService.GetAllItems();

            Assert.That(result.Count(), Is.EqualTo(items.Count));
            CollectionAssert.AreEquivalent(items, result);

        }

        [Test]
        public void UpdateItem_ShouldCallUpdateItemOnRepository()
        {
            var existingItem = new Item { Id = 1, Name = "Old item" };
            _mockRepository.Setup(repo => repo.GetItemById(1)).Returns(existingItem);

            _itemService.UpdateItem(1, "New item");
            _mockRepository.Verify(repo => repo.UpdateItem(It.Is<Item>(i=>i.Id == 1 && i.Name == "New item" )), Times.Once);


        }

        [Test]
        public void DeleteItem_ShouldCallDeleteItemOnRepository()
        {
            _itemService.DeleteItem(1);
            _mockRepository.Verify(repo => repo.DeleteItem(1), Times.Once);

        }

        [Test]
        public void ValidateItemName_WhenNameIsValid_ShouldReturnTrue()
        {
            var result = _itemService.ValidateItemName("ValidName");

            Assert.That(result, Is.True);
        }

        [Test]
        public void ValidateItemName_WhenNameIsTooLong_ShouldReturnFalse()
        {
            var result = _itemService.ValidateItemName("ValidNameIsTooLong");

            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateItemName_WhenNameIsEmpty_ShouldReturnFalse()
        {
            var result = _itemService.ValidateItemName("");

            Assert.IsFalse(result);
        }

        [Test]
        public void GetItemById_ShouldReturnCorrectItem()
        {
            var item = new Item { Id = 5, Name = "Test Item" };

            _mockRepository.Setup(repo => repo.GetItemById(5)).Returns(item);

            var result = _itemService.GetItemById(5);

            Assert.AreEqual(item, result);
            
        }

        [Test]
        public void GetItemById_ShouldReturnItemNotFound()
        {
            // Arrange
            int nonExistentId = 999;
            _mockRepository.Setup(repo => repo.GetItemById(nonExistentId)).Returns((Item)null);

            // Act
            var result = _itemService.GetItemById(nonExistentId);

            // Assert
            Assert.IsNull(result);
        }

        [TestCase("valid")]
        [TestCase("1234555587")]
        public void ValidateItemName_WithValidName_ReturnsTrue(string name) 
        {
            var result = _itemService.ValidateItemName(name);
            Assert.That(result, Is.True);
        
        }

        [TestCase("validvalidvalid")]
        [TestCase("1234123123555587")]
        [TestCase(null)]
        [TestCase("")]
        public void ValidateItemName_WithInvalidName_ReturnsFalse(string name)
        {
            var result = _itemService.ValidateItemName(name);
            Assert.That(result, Is.False);

        }
    }
}
