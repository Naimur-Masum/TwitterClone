using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;

namespace Test
{
    public class Class10
    {
        public void Run()
        {
            Tweet likeableTweet = new Tweet("This is a likeable tweet.");

            Console.WriteLine(likeableTweet.CanBeLiked());
            Notification frn = new FriendRequestNotification(Guid.NewGuid());
            frn.AddNotification(Guid.NewGuid());
            BaseEntity flo= new Follow();
            flo.Unfollow(Guid.NewGuid());
        }
    }

    
}
