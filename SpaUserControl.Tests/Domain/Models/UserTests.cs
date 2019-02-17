using SpaUserControl.Domain.Models;
using System;
using Xunit;

namespace SpaUserControl.Tests.Domain.Models
{
    public class UserTests
    {
        [Fact]
        public void UserConstructedSuccessfully()
        {
            User user = new User("Bruno Miquelotto", "bmiquelotto@gmail.com");
        }

        [Fact]
        public void UserInvalidArguments()
        {
            Assert.Throws<InvalidOperationException>(() => new User("", "bmiquelotto@gmail.com"));
        }

        [Fact]
        public void UserSetPasswordSuccess()
        {
            User user = new User("Bruno Miquelotto", "bmiquelotto@gmail.com");
            user.SetPassword("#Bruno123", "#Bruno123");
        }

        [Fact]
        public void UserDiffPasswords()
        {
            User user = new User("Bruno Miquelotto", "bmiquelotto@gmail.com");
            Assert.Throws<InvalidOperationException>(() => user.SetPassword("#Bruno123", "#Bruno12"));
        }

        [Fact]
        public void UserInvalidPassword()
        {
            User user = new User("Bruno Miquelotto", "bmiquelotto@gmail.com");
            Assert.Throws<InvalidOperationException>(() => user.SetPassword("#Bruno123", ""));
        }

        [Fact]
        public void UserInvalidPasswordLength()
        {
            User user = new User("Bruno Miquelotto", "bmiquelotto@gmail.com");
            Assert.Throws<InvalidOperationException>(() => user.SetPassword("#br", "#br"));
        }

        [Fact]
        public void ResetPassword()
        {
            string pass = new User("Bruno Miquelotto", "bmiquelotto@gmail.com").ResetPassoword();
            Assert.NotEmpty(pass);
        }
    }
}
