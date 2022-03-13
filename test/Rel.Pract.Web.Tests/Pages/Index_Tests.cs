using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Rel.Pract.Pages;

public class Index_Tests : PractWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
