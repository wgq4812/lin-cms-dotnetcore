using IGeekFan.Localization.FreeSql.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace IGeekFan.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool isGenerice=typeof(ICollection<LocalResource>).IsGenericType;
            Assert.True(isGenerice);
        }
    }
}
