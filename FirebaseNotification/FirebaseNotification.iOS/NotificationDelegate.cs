using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using UserNotifications;

namespace FirebaseNotification.iOS
{
    class NotificationDelegate : UNUserNotificationCenterDelegate
    {
        public NotificationDelegate()
        {

        }
        public override void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler)
        {

        }
        public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler)
        {

        }
        public void RegisterNotification(string title, string body)
        {
            UNUserNotificationCenter center = UNUserNotificationCenter.Current;

            //creat a UNMutableNotificationContent which contains your notification content
            UNMutableNotificationContent notificationContent = new UNMutableNotificationContent();

            notificationContent.Title = title;
            notificationContent.Body = body;

            notificationContent.Sound = UNNotificationSound.Default;

            UNTimeIntervalNotificationTrigger trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(1, false);

            UNNotificationRequest request = UNNotificationRequest.FromIdentifier("FiveSecond", notificationContent, trigger);


            center.AddNotificationRequest(request, (NSError obj) =>
            {

            });
        }
    }
}