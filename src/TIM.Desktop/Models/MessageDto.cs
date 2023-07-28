namespace TIM.Desktop.Models;

public class MessageDto
{
    public Guid Id { get; set; }

    /// <summary>
    ///     头像
    /// </summary>
    public string Avatar { get; set; }

    /// <summary>
    ///     名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     群角色
    /// </summary>
    public string Role { get; set; }

    /// <summary>
    ///     内容
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    ///     Type
    /// </summary>
    public MessageType Type { get; set; }

    /// <summary>
    ///     创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }
}