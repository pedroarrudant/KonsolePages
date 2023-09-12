
using Core.Elements;
using Core.Page;

namespace CoreTests.Tests
{
    public class WindowTests
    {
        [Fact]
        public void ShouldCreateANewWindow_Success()
        {
            //Arrange
            var window = new Window();

            //Act
            window.GenerateWindow(x =>
                    x.Header.AddPageElement(Element.Label, "Teste"));

            //Assert
            Assert.NotNull(window);
        }

        [Fact]
        public void ShouldCreateHeader()
        {
            //Arrange
            var window = new Window();

            //Act
            window.GenerateWindow(x =>
                    x.Header.AddPageElement(Element.Label, "Teste"));

            //Assert
            Assert.True(window.Header.Elements.Count > 0);
        }

        [Fact]
        public void ShouldCreateBody()
        {
            //Arrange
            var window = new Window();

            //Act
            window.GenerateWindow(x =>
                    x.Body.AddPageElement(Element.Label, "Teste"));

            //Assert
            Assert.True(window.Body.Elements.Count > 0);
        }

        [Fact]
        public void ShouldCreateFooter()
        {
            //Arrange
            var window = new Window();

            //Act
            window.GenerateWindow(x =>
                    x.Footer.AddPageElement(Element.Label, "Teste"));

            //Assert
            Assert.True(window.Footer.Elements.Count > 0);
        }

    }
}