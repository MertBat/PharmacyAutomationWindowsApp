using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class BasketDetailRepository
    {
        ProjectContext db;
        public BasketDetailRepository()
        {
            db = new ProjectContext();
        }

        public void Add(BasketDetail basketDetails)
        {
            db.BasketDetails.Add(basketDetails);
            db.SaveChanges();
        }

        public void Update(BasketDetail basketDetails)
        {
            db.BasketDetails.Update(basketDetails);
            db.SaveChanges();
        }

        public void Delete(BasketDetail basketDetails)
        {
            db.BasketDetails.Remove(basketDetails);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            BasketDetail basketDetails = db.BasketDetails.Where(x => x.BasketDetailId == id).FirstOrDefault();
            db.BasketDetails.Remove(basketDetails);
            db.SaveChanges();
        }

        public List<BasketDetail> GetAll()
        {
            return db.BasketDetails.ToList();
        }

        public string GetDailyIncome()
        {

            return db.BasketDetails.Where(a => a.PurshasedDate.Day == DateTime.Now.Day && a.PurshasedDate.Month == DateTime.Now.Month && a.PurshasedDate.Year == DateTime.Now.Year).Sum(a => a.TotalPrice).ToString() + "TL";
        }

        public string GetMonthlyIncome()
        {
            return db.BasketDetails.Where(a => a.PurshasedDate.Month == DateTime.Now.Month && a.PurshasedDate.Year == DateTime.Now.Year).Sum(a => a.TotalPrice).ToString() + "TL";
        }

        public string GetDailyProfit()
        {
            return ((db.BasketDetails.Where(a => a.PurshasedDate.Day == DateTime.Now.Day && a.PurshasedDate.Month == DateTime.Now.Month && a.PurshasedDate.Year == DateTime.Now.Year).Sum(a => a.TotalPrice)) - (db.BasketDetails.Where(a => a.PurshasedDate.Day == DateTime.Now.Day && a.PurshasedDate.Month == DateTime.Now.Month && a.PurshasedDate.Year == DateTime.Now.Year).Sum(a => a.BuyTotalPrice))).ToString() + "TL";
        }

        public string GetMonthlyProfit()
        {
            return ((db.BasketDetails.Where(a => a.PurshasedDate.Month == DateTime.Now.Month && a.PurshasedDate.Year == DateTime.Now.Year).Sum(a => a.TotalPrice)) - (db.BasketDetails.Where(a => a.PurshasedDate.Month == DateTime.Now.Month && a.PurshasedDate.Year == DateTime.Now.Year).Sum(a => a.BuyTotalPrice))).ToString() + "TL";
        }
    }
}
