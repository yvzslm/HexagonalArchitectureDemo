using Domain.Shared;
using Domain.User;
using Domain.User.Models;
using Test.User.Adapters;
using Xunit;

namespace Test.User
{
    public class SendMailTest
    {
        [Fact]
        public void Should_Send_Mail()
        {
            //Arrange
            var userFacade = new UserFacade(new FakeUserRepository(), new FakeUserNotification());
            var sendMail = new SendMail("test@test.com.tr", "Hello", "Hello World");

            //Act
            var result = userFacade.SendMail(sendMail);

            //Assert
            Assert.Equal(ResultCode.Successful, result.ResultCode);
        }
    }
}
