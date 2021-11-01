using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using TakeHomeParserProject.Models;
using Xunit;

namespace TakeHomeParserProject
{
    /// <summary>
    ///ThinkOrSwim CSVs contain the following columns 
    ///DATE,TIME,TYPE,DESCRIPTION,Commissions & Fees,AMOUNT,BALANCE,,,,,,,
    ///1/21/2021,9:38:07,TRD,BOT +10 FUBO @32.98,,-329.8,"29,730.87",,,,,,,
    /// Notice how some columns contain multiple values. More specifically the "DESCRIPTION" column contains the `Direction`, `Symbol`, and `Price` values
    /// </summary>
    public class ThinkOrSwimTests
    {
        /// <summary>
        /// Should be able to parse file "Goodfile_ThinkOrSwim"
        /// </summary>
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
            }
        }

        /// <summary>
        /// For this test I will not tell you what is wrong with the files. It should be fairly obvious, but what I want you to do is
        /// gracefully handle these bad files in your parser and throw a BadRequest exception with a user friendly error message. Please try
        /// to parse BadFile_1_ThinkOrSwim and BadFile_2_ThinkOrSwim
        /// </summary>
        [Fact]
        public void When_Bad_File_Is_Upload_Should_Throw_Bad_Request_Exception()
        {

        }
    }
}
