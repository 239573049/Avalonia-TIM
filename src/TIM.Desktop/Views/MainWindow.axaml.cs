using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using TIM.Desktop.ViewModels;

namespace TIM.Desktop.Views;

public partial class MainWindow : Window
{
    private bool _chatPanelStart;

    private bool _startList;

    public MainWindow()
    {
        InitializeComponent();
    }

    private MainWindowViewModel ViewModel => (MainWindowViewModel)DataContext;

    protected override void OnLoaded(RoutedEventArgs e)
    {
        ViewModel.Chats.Add(new ChatDto
        {
            Description = "token: 干活了干活了",
            Id = Guid.NewGuid(),
            Image = "",
            Name = "c#/.net core学习群"
        });
        ViewModel.Chats.Add(new ChatDto
        {
            Description = "token: 干活了干活了",
            Id = Guid.NewGuid(),
            Image = "",
            Name = "进击的码农"
        });
        ViewModel.Chats.Add(new ChatDto
        {
            Description = "token: 干活了干活了",
            Id = Guid.NewGuid(),
            Image = "",
            Name = "【禁水】.NET性能优化"
        });
        ViewModel.SelectedChat = ViewModel.Chats[0];
    }

    private void List_OnPointerMoved(object? sender, PointerEventArgs e)
    {
        if (_startList) ViewModel.ListWidth = (int)e.GetPosition(this).X - 50;
    }

    private void List_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        _startList = true;
    }

    private void List_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        _startList = false;
    }

    private void Chat_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        _chatPanelStart = true;
    }

    private void Chat_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        _chatPanelStart = false;
    }

    private void Chat_OnPointerMoved(object? sender, PointerEventArgs e)
    {
        if (!_chatPanelStart) return;

        if (sender is Border border)
        {
            // 获取父级组件的高度
            var chatPandelGrid = this.Find<Grid>("ChatPanelGrid");

            ViewModel.ChatPanelHeight = (int)(chatPandelGrid.Bounds.Height - e.GetPosition(this).Y + 65);
        }


        // ViewModel.ChatPanelHeight = (int)e.GetPosition(this).Y;
    }
}