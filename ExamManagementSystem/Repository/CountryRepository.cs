using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContexts;
using Models;

namespace Repository
{
   public class CountryRepository
    {
       ExamManagementDbContext db=new ExamManagementDbContext();
       public bool Add(Country country)
       {
           db.Countries.Add(country);
           bool isSave = db.SaveChanges() > 0;
           return isSave;
       }

       public bool Update(Country country)
       {
           db.Countries.Attach(country);
           db.Entry(country).State=EntityState.Modified;
           bool isUpdate = db.SaveChanges() > 0;
           return isUpdate;
       }

       public bool Delete(int id)
       {
           var countries = db.Countries.FirstOrDefault(c => c.Id == id);
           countries.isDelete = true;
           return Update(countries);
       }

       public Country GetById(int id)
       {
           var countries = db.Countries.FirstOrDefault(c => c.Id == id);
           return countries;
       }

       public List<Country> GetAllCountry()
       {
           var countries = db.Countries.Where(c => c.isDelete == false).ToList();
           return countries;
       }
    }
}
