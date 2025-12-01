using MedtatR.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public record ChatMessageRequest(
        string From, string Message, string[] Receivers
    ) : IRequest<bool>;
}
