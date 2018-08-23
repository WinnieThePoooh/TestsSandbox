using Lib;

using NUnit.Framework;

namespace Tests
{
  [SetUpFixture]
  public class MySetUpFixture
  {
  }
  
  [TestFixture]
  public class Tests
  {
    private DummyClass d = new DummyClass();

    [Test]
    public void ShouldReturnZeroByDefault()
    {
      Assert.AreEqual(0, d.ReturnPassedValue());
    }

    [Test]
    public void ShouldReturnPassedValue()
    {
      Assert.AreEqual(42, d.ReturnPassedValue(42));
    }

    [Test]
    public void NewTest()
    {
      Assert.AreEqual(43, d.ReturnPassedValue(43));
    }
    
    [Test]
    public void NewTest2()
    {
      Assert.AreEqual(44, d.ReturnPassedValue(44));
    }
  }
}