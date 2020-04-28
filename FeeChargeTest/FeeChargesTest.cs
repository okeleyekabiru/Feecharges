using System;
using FeeCharges.infrastructure;
using FeeCharges.Models;
using Xunit;

namespace FeeChargeTest
{
    public class FeeChargesTest
    {
        
            private readonly FeesCharges _configuration;

            public FeeChargesTest() => _configuration = Configuration.GetFeeSection();

            [Theory, InlineData(5000), InlineData(4990), InlineData(1), InlineData(3000), InlineData(2230),
             InlineData(3200),InlineData(2220)]
            public void TestForChargesBelowFiveThousand(double value)
            {
                var result = ApplyCharges.AmountToPay(_configuration, value);
                var expected = 10;
                Assert.Equal(expected, result);

            }

            [Theory, InlineData(5001), InlineData(50000), InlineData(40000), InlineData(30004), InlineData(10000),
             InlineData(32000), InlineData(22200)]
            public void TestForChargesAboveFiveThousandLessThanFiftyThousand(double value)
            {
                var result = ApplyCharges.AmountToPay(_configuration, value);
                var expected = 25;
                Assert.Equal(expected, result);

            }
            [Theory, InlineData(50001), InlineData(500000), InlineData(400000), InlineData(305554), InlineData(949404),
             InlineData(70000), InlineData(222000)]
            public void TestForChargesAboveFiftyThousand(double value)
            {
                var result = ApplyCharges.AmountToPay(_configuration, value);
                var expected = 50;
                Assert.Equal(expected, result);

            }

    }
       
    }

