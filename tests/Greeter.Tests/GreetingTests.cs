using Greeter;

namespace Greeter.Tests;

public class GreetingTests
{
    [Fact]
    public void For_ReturnsGreetingWithName()
    {
        Assert.Equal("Hello, Ada!", Greeting.For("Ada"));
    }

    [Fact]
    public void Shout_ReturnsUpperCaseGreeting()
    {
        Assert.Equal("HELLO, ADA!", Greeting.Shout("Ada"));
    }
}