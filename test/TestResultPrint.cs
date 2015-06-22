using System;
using Xunit;

using TextMatch.Services;

namespace test
{
    public class TestResultPrint
    {
		[Fact]
		public void NullInputArrayReturnEmptyString()
		{
			var res = new int[0];
			var printer = new ResultPrint();
			Assert.Equal(String.Empty, printer.PrintResult(res));
		}
		
		[Fact]
		public void EmptyInputArrayReturnEmptyString()
		{
			var res = new int[0];
			var printer = new ResultPrint();
			Assert.Equal(String.Empty, printer.PrintResult(res));
		}
		
		[Fact]
		public void OneResReturnCorrectString()
		{
			var res = new int[] {0};
			var printer = new ResultPrint();
			Assert.Equal("1", printer.PrintResult(res));
		}
		
		[Fact]
		public void ThreeResReturnCorrectString()
		{
			var res = new int[] {0, 25, 50};
			var printer = new ResultPrint();
			Assert.Equal("1, 26, 51", printer.PrintResult(res));
		}
	}
}