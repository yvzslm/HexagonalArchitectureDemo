using Domain.User;
using Domain.User.Models;
using Test.User.Adapters;
using Xunit;

namespace Test.User
{
    public class AddUserTest
    {
        [Fact]
        public async void Should_Add_User()
        {
            //Arrange
            var userFacade = new UserFacade(new FakeSqlServerAdapter());
            var addUser = new AddUserCommand("Yavuz", "Altun", "test@test.com.tr", "4736352728");

            //Act
            var userEntity = await userFacade.AddUserAsync(addUser);

            //Assert
            Assert.Equal(addUser.FirstName, userEntity.FirstName);
        }
    }
}
