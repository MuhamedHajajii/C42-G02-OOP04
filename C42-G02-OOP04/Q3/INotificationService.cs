using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04.Q3
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);

    }
}
