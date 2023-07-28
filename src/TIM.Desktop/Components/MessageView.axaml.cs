using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TIM.Desktop.ViewModels;

namespace TIM.Desktop.Components;

public partial class MessageView : UserControl
{
    public MessageView()
    {
        InitializeComponent();

        DataContextChanged += (sender, args) =>
        {
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "您好啊",
                Role = "【菜鸟】",
                Name = "token",
                Type = MessageType.Text
            });
        };
    }

    private MessageViewModel ViewModel => (MessageViewModel) DataContext;
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
}