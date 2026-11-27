using Greeter;

namespace Greeter.Tests;

public class GreetingTests
{
    [Fact]
    public void For_ReturnsGreetingWithName()
    {
        Assert.Equal("Hello, Ada!", Greeting.For("Ada"));
    }
}