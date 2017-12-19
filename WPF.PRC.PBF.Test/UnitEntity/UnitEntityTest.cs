using System;
using NUnit.Framework;

namespace WPF.PRC.PBF.Test
{
    [TestFixture]
    public class UnitEntityTest
    {
        [Test]
        public void CitizenshipToString()
        {
            var citizenship = new Citizenship { Value = "Российская Федерация"};

            var expectedValue = citizenship.ToString();
            
            Assert.True(expectedValue == "Российская Федерация");
        }
    }
}