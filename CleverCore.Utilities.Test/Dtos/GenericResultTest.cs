using CleverCore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Utilities.Test.Dtos
{
    public class GenericResultTest
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_ValidObjectNoPramDefault()
        {
            var genericResult = new GenericResult();
            Assert.NotNull(genericResult);
        }
        [Fact]
        public void Contructor_CreateObjectSuccess_ValidObjectNoPramDefault()
        {
            var genericResult = new GenericResult();
            Assert.True(genericResult.Success);
        }
        [Fact]
        public void Contructor_CreateObjectNotNull_NoPramDefault()
        {
            var genericResult = new GenericResult();
            Assert.Equal(expected: "test", actual: genericResult.Message);
        }
    }
}
