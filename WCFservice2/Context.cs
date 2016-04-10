using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WCFservice2;

namespace WCF_Tamagotchi.service
{
    public class Context : DbContext
    {
        public Context()
            : base("name=GotchiDb2")
        {

        }
        public DbSet<Dummy> ChatMsg { get; set; }
        public DbSet<Tamagotchi> Tamagotchis {
            get;
            set;
        }
       // public Db

     }
}
