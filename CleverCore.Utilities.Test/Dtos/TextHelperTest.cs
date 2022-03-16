using CleverCore.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Utilities.Test.Dtos
{
    public class TextHelperTest
    {
        [Theory]
        [InlineData("test ninhnv13")]
        public void ToUnsignString_UpperCaseInput_LowerCaseOutput(string input)
        {
            string result = TextHelper.ToUnsignString(input);
            Assert.Equal(expected: "test-ninhnv13", actual: result);
        }

        [Fact]
        public void ToString_NumberInput_CharactersNumber()
        {
            string result = TextHelper.ToString(number: 120);
            Assert.Equal(expected: "một trăm hai mươi đồng chẵn", actual: result);
        }
    }
}
