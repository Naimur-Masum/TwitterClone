using TwitterClone.Domain.Entities;

//var notification = new Notification("comment");

//notification.Message = "I can access";

var notifications = new List<Notification>()
{
    new LikeNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new FriendRequestNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new SystemNotification()
};

foreach (var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
}
