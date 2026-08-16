using TwitterClone.Domain.Entities;

var notifications = new List<Notification>()
{
    new LikeNotification(Guid.NewGuid(), Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new SystemNotification(Guid.NewGuid(), "System is under maintenance."),
    new FriendRequestNotification(Guid.NewGuid())
};

foreach (var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
    Console.WriteLine();
}
