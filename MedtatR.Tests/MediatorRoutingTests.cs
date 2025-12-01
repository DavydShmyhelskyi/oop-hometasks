using Chat;
using MedtatR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedtatR.Tests
{
    public class MediatorRoutingTests
    {
        [Fact]
        public void Send_Without_Handler_Should_Throw_Exception()
        {
            // Arrange
            var mediator = new Mediator<ChatMessageRequest, bool>();


            var request = new ChatMessageRequest(
                "David",
                "Hello",
                new[] { "Alice" }
            );

            // Act + Assert
            Assert.Throws<Exception>(() => mediator.Send(request));
        }
    }
}
