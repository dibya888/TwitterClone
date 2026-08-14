using TwitterClone.Domain.Entities;

var likeNotification = new LikeNotification(Guid.NewGuid(), "\nLike Notification: You have a new like!");

Console.WriteLine(likeNotification.DescribeRecord());

var friendRequestNotification = new FriendRequestNotification(Guid.NewGuid(), "(Dibya)");

Console.WriteLine("\n" + friendRequestNotification.NotificationMessage());

var systemNotification = new SystemNotification(
    Guid.NewGuid(),
    "\nSystem Notification: Your password was changed successfully."
);

Console.WriteLine(systemNotification.DescribeRecord());

var commentNotification = new CommentNotification(
    Guid.NewGuid(),
    "\nComment Notification: You have a new comment on your post."
);

Console.WriteLine(commentNotification.DescribeRecord());