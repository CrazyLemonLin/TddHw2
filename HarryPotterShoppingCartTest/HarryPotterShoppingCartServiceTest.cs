using FluentAssertions;
using HarryPotterShoppingCart;
using NUnit.Framework;
using System.Collections.Generic;

namespace HarryPotterShoppingCartTest
{
    [TestFixture]
    public class HarryPotterShoppingCartServiceTest
    {
        private HarryPotterShoppingCartService _target;

        [OneTimeSetUp]
        public void SetUpFixtrue()
        {
            _target = new HarryPotterShoppingCartService();
        }

        [Test]
        public void CheckOutTest_只買了第一集1本_結帳價格應為100()
        {
            //arrange
            List<FantasyNovel> shoppingList = new List<FantasyNovel> {
                GetNovel(1)
            };
            var expected = 100;
            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckOutTest_只買了第一集第二集各1本_結帳價格應為190()
        {
            //arrange
            List<FantasyNovel> shoppingList = new List<FantasyNovel> {
               GetNovel(1),GetNovel(2)
            };
            var expected = 190;
            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckOutTest_只買了一二三集各1本_結帳價格應為270()
        {
            //arrange
            List<FantasyNovel> shoppingList = new List<FantasyNovel> {
            GetNovel(1),   GetNovel(2),   GetNovel(3)
            };
            var expected = 270;
            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckOutTest_只買了一二三四集各1本_結帳價格應為320()
        {
            //arrange
            List<FantasyNovel> shoppingList = new List<FantasyNovel> {
            GetNovel(1),   GetNovel(2),   GetNovel(3), GetNovel(4)
            };
            var expected = 320;
            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckOutTest_只買了一二三四五集各1本_結帳價格應為375()
        {
            //arrange
            List<FantasyNovel> shoppingList = new List<FantasyNovel> {
            GetNovel(1),   GetNovel(2),   GetNovel(3), GetNovel(4), GetNovel(5)
            };
            var expected = 375;
            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckOutTest_一二集各1本_三集2本_結帳價格應為370()
        {
            //arrange
            var shoppingList = new List<FantasyNovel> {
                GetNovel(1),GetNovel(2),GetNovel(3),GetNovel(3)
            };
            var expected = 370;

            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckOutTest_一集1本_二三集各2本_結帳價格應為460()
        {
            //arrange
            var shoppingList = new List<FantasyNovel> {
                GetNovel(1),GetNovel(2),GetNovel(2),GetNovel(3),GetNovel(3)
            };
            var expected = 460;

            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckOutTest_買兩套_結帳價格應為750()
        {
            //arrange
            var shoppingList = new List<FantasyNovel> {
                 GetNovel(1),   GetNovel(2),   GetNovel(3), GetNovel(4), GetNovel(5),
                  GetNovel(1),   GetNovel(2),   GetNovel(3), GetNovel(4), GetNovel(5)
            };
            var expected = 750;

            //act
            var result = _target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }

        private FantasyNovel GetNovel(int id)
        {
            return new FantasyNovel
            {
                Id = id,
                Name = $"HarryPotterBook{id}",
                UnitPrice = 100
            };
        }
    }
}