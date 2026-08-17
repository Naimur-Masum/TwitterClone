using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification:Notification
    {
        public SystemNotification() : base("System")
        {

        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }
    }
}
