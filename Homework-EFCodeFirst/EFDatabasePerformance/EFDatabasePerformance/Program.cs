
namespace EFDatabasePerformance
{
    using System;
    using System.Linq;
    using System.Data.Entity;

    public class Program
    {
        public static void Main()
        {
            var db = new AdsEntities();

            // Problem 1

            //var ads = db.Ads;

            //foreach (var ad in ads)
            //{
            //    Console.WriteLine("{0} {1} {2} {3} {4}", ad.Title, ad.AdStatus, ad.Category, ad.Town, ad.AspNetUser);
            //}

            //-----------------------------------

            //var ads = db.Ads.Select(a => new
            //{
            //    a.Title,
            //    a.AdStatus,
            //    a.Category,
            //    a.Town,
            //    a.AspNetUser
            //});

            //foreach (var ad in ads)
            //{
            //    Console.WriteLine("{0} - {1} \n Category: {2}; Town: {3} \n User: {4}\n",
            //        ad.Title, ad.AdStatus, ad.Category, ad.Town, ad.AspNetUser);
            //}

            //-----------------------------------

            //foreach (var ad in db.Ads
            //    .Include(a => a.AdStatus)
            //    .Include(a => a.Town)
            //    .Include(a => a.Category)
            //    .Include(a => a.AspNetUser))
            //{
            //    Console.WriteLine("Title: " + ad.Title + ", Status: " + ad.AdStatus.Status +
            //        ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
            //        ", Town: " + (ad.Town == null ? "(no town)" : ad.Town.Name) +
            //        ", User: " + ad.AspNetUser.Name);
            //}

            //=========================================================================================================
            // Problem 2 

            //var ads = db.Ads.ToList()
            //    .Where(a => a.AdStatus.Status == "Published")
            //    .Select(a => new
            //        {
            //            a.Title,
            //            a.Category,
            //            a.Town,
            //            a.Date
            //        }).ToList()
            //        .OrderBy(a => a.Date);

            //------------------------------------------------------
            //var ads = db.Ads
            //    .Where(a => a.AdStatus.Status == "Published")
            //    .OrderBy(a => a.Date)
            //    .Select(a => new{
            //        a.Title,
            //        a.Category,
            //        a.Town,
                
            //    }).ToList();

            //foreach (var ad in ads)
            //{
            //    Console.WriteLine(ad.Title);
            //    Console.WriteLine(ads.Count());
            //}

            //=========================================================================================================
            // Problem 3

            var ads = db.Ads.ToList();

            foreach (var ad in ads)
            {
                Console.WriteLine(ad.Title);
            }

            //var adsTitles = db.Ads
            //    .Select(a => a.Title);

            //foreach (var adTitle in adsTitles)
            //{
            //    Console.WriteLine(adTitle);
            //}
        }
    }
}
