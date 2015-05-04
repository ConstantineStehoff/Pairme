using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pairme.Services;
using Pairme.Models;

namespace Pairme.Services
{
    public class AccountService : IAccountService
    {
        PairmeEntities db = new PairmeEntities();

        public string GetCountryByID(int id){
            return (from gd in db.Countries where gd.ID == id select gd.CountryName).Single();
        }
    }
}