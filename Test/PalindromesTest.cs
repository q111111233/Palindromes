using Xunit;

namespace Palindromes
{
  public class GameTests
  {
    [Fact]
    public void Palindromes_test_fail()
    {
      Game g = new Game("Rock paper");
      Assert.Equal(false, g.Palin());
    }
    [Fact]
    public void Palindromes_test_success()
    {
      Game g = new Game("Hello olleH");
      Assert.Equal(true, g.Palin());
    }
    [Fact]
    public void PalinHard_test_fail()
    {
      Game g = new Game("Rock paper");
      Assert.Equal(false, g.PalinHard());
    }
    [Fact]
    public void PalinHard_test_success()
    {
      Game g = new Game("Hello olleH");
      Assert.Equal(true, g.PalinHard());
    }
    [Fact]
    public void PalinHard_test_for_int_success()
    {
      Game g = new Game(101);
      Assert.Equal(true, g.PalinHard());
    }
  }
}
