using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AQFWS.Pages
{
    public class Index_Tests : AQFWSWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
