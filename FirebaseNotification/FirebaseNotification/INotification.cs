using System;
using System.Collections.Generic;
using System.Text;

namespace FirebaseNotification
{
    public interface INotification
    {
        void CreateNotification(String title, String message);
    }  
}
