using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MedtatR.Abstractions;

namespace Chat;

public record ChatNotification(string From, string To, string Message) : IEvent
{
    public override string ToString()
        => $"{From} to {To}: {Message}";
}

