using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string SubscriberModelAdded = ("Abone Eklendi.");
        public static string SubscriberModelUpdated = ("Abone Güncellendi.");
        public static string SubscriberNoInvalid = ("Abone Numarası min 2 karakter olmalıdır.");
        public static string MaintenanceTime=("Sistem bakımda");
        public static string SubscriberModelListed=("Aboneler listelendi.");
    }
}
