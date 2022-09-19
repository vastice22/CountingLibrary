using System.Reflection;
using System.Numerics;
using UtilityLibraries;
namespace ExampleTest;

[TestClass]
public class UnitTest1
{
    //Variables
    
    [TestMethod]
    public void TestMaximumNumber(){
        string number = "18456002032011000007";
        BigInteger _number = BigInteger.Parse(number);
        string result = _number.Towards();
        string statement = "eighteen quintillion, four hundred and fifty six quadrillion, two trillion, thirty two billion, eleven million, and seven";
        Assert.AreEqual(statement, result);
        
    }
    [TestMethod]
    public void TestNumber343434343(){
        string number = "343434343";
        BigInteger _number = BigInteger.Parse(number);
        string result = _number.Towards();
        string statement = "three hundred and forty three million, four hundred and thirty four thousand, three hundred and forty three";
        Assert.AreEqual(statement, result);
        
    }
        [TestMethod]
    public void TestNumber0(){
        string number = "0";
        BigInteger _number = BigInteger.Parse(number);
        string result = _number.Towards();
        string statement = "Zero";
        Assert.AreEqual(statement, result);
        
    }
    [TestMethod]
    public void Test545445454545(){
        string number = "545445454545";
        string statement = "five hundred and forty five billion, four hundred and forty five million, four hundred and fifty four thousand, five hundred and forty five";
        BigInteger _number = BigInteger.Parse(number);
        string result = _number.Towards();
        Assert.AreEqual(statement,result);
    }
    [TestMethod]
    public void Test100(){
        string number = "100";
        string statement = "one hundred";
        BigInteger _number = BigInteger.Parse(number);
        string result = _number.Towards();
        Assert.AreEqual(statement,result);
    }
}