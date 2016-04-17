using System;
using System.ComponentModel.DataAnnotations;

namespace ROG_6.Model
{
    public class Status
    {
        [Key]
        public int id { get; set; }
        public Boolean overleden { get; set; }
        public Boolean hongerig { get; set; }
        public Boolean topvorm { get; set; }
        public Boolean krankzinnig { get; set; }
        public Boolean bezig
        {
            get
            {
                return bezig;
            }
            set
            {
                if (value == false)
                    actieTijd = 0;
                bezig = value;
            }
        }
        public int actieTijd { get; set; }
        public DateTime startActie { get; set; }

        public Status()
        {
            overleden = false;
            hongerig = false;
            topvorm = false;
            krankzinnig = false;
        }

        public Boolean getOverleden()
        {
            return overleden;
        }

        public Boolean getHongerig()
        {
            return hongerig;
        }

        public Boolean getTopvorm()
        {
            return topvorm;
        }

        public Boolean getKrankzinnig()
        {
            return krankzinnig;
        }

        public void setOverleden(Boolean overleden)
        {
            this.overleden = overleden;
        }

        public void setHongerig(Boolean hongerig)
        {
            this.hongerig = hongerig;
        }

        public void setTopvorm(Boolean topvorm)
        {
            this.topvorm = topvorm;
        }

        public void setKrankzinnig(Boolean krankzinnig)
        {
            this.krankzinnig = krankzinnig;
        }

        public Boolean getBezig()
        {
            if (bezig == true && startActie.AddSeconds(actieTijd) <= DateTime.Now)
            {
                bezig = false;
            }
            return bezig;
        }

        public void setBezig(int tijd)
        {
            this.bezig = true;
            this.startActie = DateTime.Now;
            this.actieTijd = tijd;
        }

    }
}
