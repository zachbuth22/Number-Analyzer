using Unit_Testing;

namespace UnitTests;

public class UnitTest1
{
    //fact =single test
    [Fact]
    public void TwoNumbersAddedWillSum()
    {
        //Arrange
        Arithmetic sut = new Arithmetic();

        //Act
        int result = sut.Adder(2, 3);

        //Assert
        Assert.Equal(5, result);
    }

    //theory is multiple tests
    [Theory]
    [InlineData(1,1,0)]
    [InlineData(4,2,2)]
    [InlineData(10,-2,12)]
    [InlineData(-4,-5, 1)]
    public void TwoNumbersSubbedWillDifference(int num1, int num2, int difference)
    {
        //Arrange
        Arithmetic sut = new Arithmetic();

        //Act
        int result = sut.Subber(num1, num2);

        //Assert
        Assert.Equal(difference, result);
    }


    //setup tests for multiply and divide (2 tests)
    //multiple use cases
    //Account for 0


    //once all tests are setup, then create the actual methods
    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(3, 0, 0)]
    [InlineData(5, -2, 10)]

    public void TwoNumbersMultipliedWillTotal(int num 1, int num2, int total)
    {
        //Arrange
        Arithmetic sut = new Arithmetic();

        //Act
        int result = sut.Multi(num1, num2).
        //Assert
        Assert.Equal(total, result);
    }

    [Theory]

    public void TwoNumbersDividedWillQuotient(double num1, double num2, double quotient)
    {

    }

