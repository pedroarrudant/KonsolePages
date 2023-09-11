using Core.Elements;
using Core.Page;
using System.ComponentModel;
using Xunit;

namespace CoreTests.Tests
{
    public class ElementsTest
    {
        [Fact]
        public void ShouldCreateLabel()
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
        public void ShouldCreateConditionalStatement()
        {
            //Arrange
            var window = new Window();

            //Act
            window.GenerateWindow(x =>
                    x.Body.AddPageElement(Element.ConditionalStatement, "Teste"));

            //Assert
            Assert.True(window.Body.Elements.Count > 0);
        }
        
        [Fact]
        public void ShouldCreateOption()
        {
            //Arrange
            var window = new Window();
            var options = new OptionTestMenu();

            //Act
            window.GenerateWindow(x =>
                        x.Body.AddPageElement(Element.Option, options));

            //Assert
            Assert.True(window.Body.Elements.Count > 0);
        }

        [Fact]
        public void ShouldCreateLine()
        {
            //Arrange
            var window = new Window();

            //Act
            window.GenerateWindow(x =>
                        x.Body.AddPageElement(Element.Line));

            //Assert
            Assert.True(window.Body.Elements.Count > 0);
        }

        [Fact]
        public void ShouldCreateProgressBar()
        {
            //Arrange
            var window = new Window();

            //Act
            window.GenerateWindow(x =>
                        x.Body.AddPageElement(Element.ProgressBar));

            //Assert
            Assert.True(window.Body.Elements.Count > 0);
        }

        public enum OptionTestMenu
        {
            Option1 = 0,
            Option2 = 1,
            Option3 = 2,
        };
    }
}
