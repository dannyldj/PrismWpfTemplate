using PrismWpfTemplate.Core.Interfaces;

namespace PrismWpfTemplate.Modules.Example.Services;

internal class MessageService : IMessageService
{
    public string GetMessage()
    {
        return "Hello, World!";
    }
}