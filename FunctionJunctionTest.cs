using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FunctionJunctionDotNet
{
  public class FunctionJunctionTest
  {
    [Theory]
    [InlineData(1, 3, 3)]
    [InlineData(0, 3, 3)]
    [InlineData(10, 3, 10)]
    [InlineData(-1, -3, -1)]
    public void Max(int a, int b, int max)
    {
      Assert.Equal(max, FunctionJunction.Max(a, b));
    }

    [Theory]
    [InlineData(1, 3, 2, 3)]
    [InlineData(0, 3, -1, 3)]
    [InlineData(10, 3, 50, 50)]
    [InlineData(-10, -3, -1, -1)]

    public void MaxOfThree(int a, int b, int c, int max)
    {
      Assert.Equal(max, FunctionJunction.MaxOfThree(a, b, c));
    }

    [Theory]
    [InlineData(8, 11, 19)]
    [InlineData(4, 100, 104)]
    public void Sum(int a, int b, int sum)
    {
      Assert.Equal(sum, FunctionJunction.Sum(a, b));
    }


    [Theory]
    [InlineData(new int[] { 8, 11 }, 19)]
    [InlineData(new int[] { 4, 100 }, 104)]
    public void SumList(int[] numbers, int sum)
    {
      Assert.Equal(sum, FunctionJunction.SumList(numbers.ToList()));
    }




  }
}