using System;
using System.Collections.Generic;
using FluentAssertions;
using TakeHomeParserProject.Models;
using Xunit;

namespace TakeHomeParserProject
{
    public class DasTests
    {
        [Fact]
        public void HappyPath()
        {
            var finalData = new List<ChartlogTradeExecution>();

            //create your classes wherever you like but use them here:


            //
            finalData.Should().NotBeNullOrEmpty();
            foreach (var t in finalData)
            {
                t.AccountNumber.Should().NotBeNullOrWhiteSpace();
                t.ExecutionDateAndTime.Should().NotBe(DateTime.MinValue);
                t.Price.Should().BeGreaterThan(0);
                t.Quantity.Should().BeGreaterThan(0);
                t.Symbol.Should().NotBeNullOrWhiteSpace();
                t.Symbol.Should().BeUpperCased();
                t.OrderId.Should().NotBeNullOrWhiteSpace();
            }
        }

        /// <summary>
        /// For this test I will not tell you what is wrong with the file. It should be fairly obvious, but what I want you to do is
        /// gracefully handle these bad files in your parser and throw a BadRequest exception with a user friendly error message. Please try
        /// to parse DAS_Bad_File
        /// </summary>
        [Fact]
        public void When_Bad_File_Is_Upload_Should_Throw_Bad_Request_Exception()
        {

        }
    }
}