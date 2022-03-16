using CleverCore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Utilities.Test.Dtos
{
    public class PagedResultTest
    {
        [Fact]
        public void Constructor_CreateObject_NotNull()
        {
            var pagedResult = new PagedResult<Array>();
            Assert.NotNull(pagedResult);
        }

        [Fact]
        public void Constructor_CreateObject_WithResultNotNull()
        {
            var pagedResult = new PagedResult<Array>();
            Assert.NotNull(pagedResult.Results);
        }




    }
}
