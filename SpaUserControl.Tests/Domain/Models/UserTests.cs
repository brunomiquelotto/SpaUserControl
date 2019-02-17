
using SpaUserControl.Domain.Models;
using Xunit;

namespace SpaUserControl.Tests.Domain.Models
{
    public class UserTests
    {
        [Fact]
        public void UserConstructedSuccessfully()
        {
            User user = new User();
        }
    }
}
