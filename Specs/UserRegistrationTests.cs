using System.Threading.Tasks;
using Common.Commands;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using RawRabbit;
using Sales.Api.Controllers;

namespace Specs
{
    [TestFixture]
    public class UserRegistrationTests
    {
        [Test]
        public async Task Users_Controller_Post_Should_NotBeNull()
        {
            var busClient = Substitute.For<IBusClient>();
            var controller = new UsersController(busClient);
            var command = new RegisterUser
            {
                Email = "Tets@gmail.com",
                FirstName="TestFirstName",
                LastName="TestLastName"
            };
            var actual = await controller.Post(command);
            var contentResult = actual as AcceptedResult;
            contentResult.Should().NotBeNull();
        }

        [Test]
        public async Task Users_Controller_Post_Should_Return_AcceptedAsync()
        {
            var busClient = Substitute.For<IBusClient>();
            var controller = new UsersController(busClient);
            var command = new RegisterUser
            {
                Email = "Tets@gmail.com",
                FirstName = "TestFirstName",
                LastName = "TestLastName"
            };
            var actual = await controller.Post(command);
            var contentResult = actual as AcceptedResult;
            contentResult.Location.Should().BeEquivalentTo($"Users/{command.FirstName}");
        }
    }
}