using NUnit.Framework;
using PlingPlangPlong_Code;

namespace PlingPlangPlong_Tests
{
    public class PlingPlangPlongTests
    {
        readonly PlingPlangPlongCode pppCode = new PlingPlangPlongCode();

        [TestCase(28, "1 2 4 7 14 28")]
        [TestCase(30, "1 2 3 5 6 10 15 30")]
        [TestCase(34, "1 2 17 34")]
        public void GivenIHaveANumber_WhenIEnterItIntoReturnFactors_ThenItReturnsAListOfAllCorrectFactors(int num, string expected)
        {
            var factorsList = pppCode.ReturnFactors(num);
            var factorsString = "";

            foreach (var factor in factorsList)
            {
                factorsString += $"{factor} ";
            }

            Assert.That(factorsString.TrimEnd(), Is.EqualTo(expected));
        }
    }
}