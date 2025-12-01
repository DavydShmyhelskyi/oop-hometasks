using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedtatR.Tests
{
    using Chat;
    using MedtatR.Services;
    using System;
    using System.IO;
    using Xunit;

    public class ChatMediatorTests
    {
        [Fact]
        public void Send_Should_Return_True_When_Message_Is_Valid()
        {
            // Arrange
            var mediator = new Mediator<ChatMessageRequest, bool>();
            var handler = new ChatMessageHandler(mediator);
            mediator.Register(handler);


            var request = new ChatMessageRequest(
                "David",
                "Hello",
                new[] { "Alice", "Bob", "Mike" }
            );

            // Act
            var result = mediator.Send(request);

            // Assert
            Assert.True(result);
        }

    }
}