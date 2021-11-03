using System;
using Xunit;
using CRUSModels;

namespace RRTest
{
    public class UnitTest1

    
    {
        [Fact]
        public void CityShouldHaveValidData()
        {//arrange
        Customer _customerTest = new Customer();
        string name = "her";

        //Act
        _customerTest.Name = name;

        //Assert
        Assert.NotNull(_customerTest.Name);
        Assert.Equal(_customerTest.Name, name);

        
        }

        

//will test if property gives exception if given invalid data
    [Theory]
    [InlineData("dadada")]
    [InlineData("freadad")]
    [InlineData("dafafda")]
    [InlineData("uapd")]
    [InlineData("weraedf")]
    [InlineData("babadfea")]
        public void CityShouldFailiWithInvalidData(string p_input)
        
        {            
            Customer _customerTest = new Customer();

            //throw MethodAccessException will only pass if the code you did will give some sort of an exception.
            
            Assert.Throws<Exception>(() => _customerTest.Name = p_input); 


        }
    }
}
