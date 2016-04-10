using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCF_Tamagotchi.service
{
    public class Dummy
    {

        [Key]
        public int Id {
            get;
            set;
        }
        public string Naam {

            get;
            set;
        }

        public int Honger {
            get; 
            set;
        }
        public int Leven {
            get;
            set;
        }

        public int Vermoeidheid {
            get;
            set;
        }
        public int Verveling {
            get;
            set;
        }
        public int Isolatie {
            get;
            set;
        }
        public Boolean Overleden {
            get;
            set;
        }
        public Boolean Voedseltekort {
            get;
            set;
        }
        public Boolean Slaaptekort {
            get;
            set;
        }
        public Boolean Trek {
            get;
            set;
        }
        public Boolean TopAtleet {
            get;
            set;
        }
        public Boolean Crazy {
            get;
            set;
        }
        public DateTime LastAccess {
            get;
            set;
        }
            
                   

    }
}