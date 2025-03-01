using Bunit;
using Xunit;

namespace Microsoft.Fast.Components.FluentUI.Tests.Card;

public class FluentCardTests : TestBase
{
    [Fact]
    public void FluentCard_Default()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCard>(parameters =>
        {
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCard_AdditionalCssClass()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCard>(parameters =>
        {
            parameters.Add(p => p.Class, "css-class");
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCard_AdditionalStyle()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCard>(parameters =>
        {
            parameters.Add(p => p.Style, "background-color: red");
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCard_AdditionalParameter()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCard>(parameters =>
        {
            parameters.AddUnmatched("additional-parameter-name", "additional-parameter-value");
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCard_AdditionalParameters()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCard>(parameters =>
        {
            parameters.AddUnmatched("additional-parameter1-name", "additional-parameter1-value");
            parameters.AddUnmatched("additional-parameter2-name", "additional-parameter2-value");
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }
}