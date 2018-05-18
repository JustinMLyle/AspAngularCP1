using AspAngularCP1.Models;
using Xunit;

namespace AspAngularCP1.Test
{
    public class ProductTests
    {
        [Fact]
        public void isAnAdmin()
        {

            // Arrange
            var p = new Admin { Name = "Test", IsAdmin = true };

            // Act
            p.IsAdmin = true;

            //Assert
            Assert.Equal("New Admin Check", p.IsAdmin);
        }

    }
}