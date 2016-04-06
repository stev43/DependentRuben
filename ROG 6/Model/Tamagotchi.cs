using System;

namespace ROG_6.Model
{
    class Tamagotchi
    {

        private String name;
        private int hunger;
        private int sleep;
        private int boredom;
        private int health;
        private DateTime lastAcces;
        private Status status;

        public Tamagotchi(String name)
        {
            this.name = name;
            this.hunger = 20;
            this.sleep = 20;
            this.boredom = 20;
            this.health = 20;
            this.lastAcces = DateTime.Now;
            this.status = new Status();

        }

        public Tamagotchi(String name, int hunger, int sleep, int boredom, int health, DateTime lastAcces)
        {
            this.name = name;
            this.hunger = hunger;
            this.sleep = sleep;
            this.boredom = boredom;
            this.health = health;
            this.lastAcces = lastAcces;
            this.status = new Status();
        }

        public String getName()
        {
            return name;
        }

        public int getHunger()
        {
            return hunger;
        }

        public int getSleep()
        {
            return sleep;
        }

        public int getBoredom()
        {
            return boredom;
        }

        public int getHealth()
        {
            return health;
        }

        public DateTime getLastAcces()
        {
            return lastAcces;
        }

        public Status getStatus()
        {
            return status;
        }

        public void setHunger(int hunger)
        {
            this.hunger = hunger;
        }

        public void setSleep(int sleep)
        {
            this.sleep = sleep;
        }

        public void setBoredom(int boredom)
        {
            this.boredom = boredom;
        }

        public void setHealth(int health)
        {
            this.health = health;
        }

        public void setLastAcces(DateTime lastAcces)
        {
            this.lastAcces = lastAcces;
        }

        public void setStatus(Status status)
        {
            this.status = status;
        }

        public void setBezig(int tijd)
        {
            this.status.setBezig(tijd);
        }
    }
}
