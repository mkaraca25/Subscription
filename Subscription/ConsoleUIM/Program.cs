// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");
/*IndexCalculationModelManager indexCalculationModelManager = new IndexCalculationModelManager(new EfIndexCalculationModelDal());
foreach (var indexCalculationModel in indexCalculationModelManager.GetAll())
{
    Console.WriteLine(indexCalculationModel.Id);
}*/







SubscriberModelManager subscriberModelManager = new SubscriberModelManager(new EfSubscriberModelDal());
var result = subscriberModelManager.GetSubscriberModelDetails();
//if (result.Success == true)
//{
//    foreach (var subscriber in subscriberModelManager.GetSubscriberModelDetails())
//    {
//        Console.WriteLine(subscriber.AdSoyad + "/" + subscriber.AdSoyad);
//    }
//}
//else
//{
//    Console.WriteLine(result.Message);
//}

