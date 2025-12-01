using Chat;
using MedtatR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedtatR.Tests
{
    public class ChatMessageHandlerTests
    {
        [Fact]
        public void Handle_Should_Return_False_When_Message_Is_Empty()
        {
            // Arrange
            var mediator = new Mediator<ChatMessageRequest, bool>();
            var handler = new ChatMessageHandler(mediator);
            mediator.Register(handler);



            var request = new ChatMessageRequest(
                "David",
                "   ",
                new[] { "Alice", "Bob" }
            );

            // Act
            var result = mediator.Send(request);

            // Assert
            Assert.False(result);
        }

    }
}
