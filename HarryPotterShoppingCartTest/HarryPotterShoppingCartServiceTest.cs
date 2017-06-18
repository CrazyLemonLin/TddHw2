using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using FluentAssertions;
using HarryPotterShoppingCart;
using System.Collections.Generic;

namespace HarryPotterShoppingCartTest
{
    [TestFixture]
    public class HarryPotterShoppingCartServiceTest
    {
       [Test]
       public void CheckOutTest_只買了第一集1本_結帳價格應為100()
        {
            //arrange
            var target = new HarryPotterShoppingCartService();
            List<FantasyNovel> shoppingList = new List<FantasyNovel> {
                new FantasyNovel
                {
                    Id =1,
                    Name="HarryPotterBook1",
                    UnitPrice=100
                }
            };
            var expected = 100;
            //act
            int result = target.CheckOut(shoppingList);

            //assert
            result.Should().Be(expected);
        }
    }
}
