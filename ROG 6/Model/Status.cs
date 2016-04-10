using System;

namespace ROG_6.Model
{
    public class Status
    {
        private Boolean overleden;
        private Boolean hongerig;
        private Boolean topvorm;
        private Boolean krankzinnig;
        private Boolean bezig;
        private int actieTijd;
        private DateTime startActie;

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
