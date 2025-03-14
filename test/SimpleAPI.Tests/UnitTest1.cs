using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValueController controller = new ValueController();

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Les Jackson", returnValue.Value);
    }

}
