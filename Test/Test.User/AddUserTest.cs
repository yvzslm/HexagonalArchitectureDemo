using Domain.User;
using Domain.User.Models;
using Test.User.Adapters;
using Xunit;

namespace Test.User
{
    public class AddUserTest
    {
        [Fact]
        public void Should_Add_User()
        {
            //Arrange
            var userFacade = new UserFacade(new FakeUserRepository(), new FakeUserNotification());
            var addUser = new AddUser("Yavuz", "Altun", "test@test.com.tr", "4736352728");

            //Act
            var userEntity = userFacade.AddUser(addUser);

            //Assert
            Assert.Equal(addUser.FirstName, userEntity.FirstName);
        }
    }
}
