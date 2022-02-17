using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            SubscriberModelManager subscriberModelManager = new SubscriberModelManager(new EfSubscriberModelDal());
            foreach (var subscriber in subscriberModelManager.GetAll())
            {
                Console.WriteLine(subscriber.AdSoyad);
            }
        }
    }
}