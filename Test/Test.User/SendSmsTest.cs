using Domain.Shared;
using Domain.User;
using Domain.User.Models;
using Test.User.Adapters;
using Xunit;

namespace Test.User
{
    public class SendSmsTest
    {
        [Fact]
        public void Should_Send_Sms()
        {
            //Arrange
            var userFacade = new UserFacade(new FakeUserRepository(), new FakeUserNotification());
            var sendSms = new SendSms("8474674838", "Hello World");

            //Act
            var result = userFacade.SendSms(sendSms);

            //Assert
            Assert.Equal(ResultCode.Successful, result.ResultCode);
        }
    }
}
