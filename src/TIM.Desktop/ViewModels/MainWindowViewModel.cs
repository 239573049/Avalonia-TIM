namespace TIM.Desktop.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<ChatDto> _chats = new();
    private int _listWidth = 280;

    private ChatDto _selectedChat;

    private int chatPanelHeight = 240;

    public int ListWidth
    {
        get => _listWidth;
        set => this.RaiseAndSetIfChanged(ref _listWidth, value);
    }

    public ObservableCollection<ChatDto> Chats
    {
        get => _chats;
        set => this.RaiseAndSetIfChanged(ref _chats, value);
    }

    public ChatDto SelectedChat
    {
        get => _selectedChat;
        set => this.RaiseAndSetIfChanged(ref _selectedChat, value);
    }

    public int ChatPanelHeight
    {
        get => chatPanelHeight;
        set => this.RaiseAndSetIfChanged(ref chatPanelHeight, value);
    }

    public MessageViewModel MessageViewModel { get; set; } = new();
}