using FluentAssertions;
using HarryPotterShoppingCart.Models;
using Xunit;

namespace HarryPotterShoppingCart.Tests
{


    public class ShoppingCartServiceTests
    {
        private readonly ShoppingCartService _target;

        public ShoppingCartServiceTests()
        {
            this._target = new ShoppingCartService();
        }

        [Theory]
        [MemberData(nameof(TestDataSource.TestData), MemberType = typeof(TestDataSource))]
        public void CalculateTest_購買HerryPotter書籍優惠價格計算(ShoppingCartEntity shoppingCart, decimal expected)
        {
            //// Arrange
            decimal actual = 0m;

            //// Act
            actual = this._target.Calculate(shoppingCart);

            //// Assert
            actual.Should().Be(expected);
        }
    }
}