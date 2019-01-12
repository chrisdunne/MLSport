using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Sport.Tests
{
    [TestFixture]
    public class PredictTests
    {
        [Test]
        public void Predict_WhenInit_ReturnNew()
        {
            var output = new Predict();
            Assert.IsInstanceOf(typeof(Predict), output);
        }
    }
}
