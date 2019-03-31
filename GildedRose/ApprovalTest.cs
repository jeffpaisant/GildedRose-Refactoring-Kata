using Xunit;
using System;
using System.IO;
using System.Text;
using ApprovalTests.Reporters;
using ApprovalTests;
using ApprovalTests.Reporters.Mac;

namespace GildedRose
{
    [UseReporter(typeof(XUnit2Reporter))]
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            String output = fakeoutput.ToString();

            Approvals.Verify(output);
        }
    }
}
