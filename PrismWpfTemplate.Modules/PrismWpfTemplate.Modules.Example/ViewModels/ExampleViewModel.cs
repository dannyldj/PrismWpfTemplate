using Prism.Mvvm;
using PrismWpfTemplate.Core.Interfaces;

namespace PrismWpfTemplate.Modules.Example.ViewModels;

internal class ExampleViewModel : BindableBase
{
    private string? _message;

    public ExampleViewModel(IMessageService messageService)
    {
        Message = messageService.GetMessage();
    }

    public string? Message
    {
        get => _message;
        set => SetProperty(ref _message, value);
    }
}