﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ROG_6.Model
{
    public class Tamagotchi
    {

        [Key]
        public String name { get; set; }
        public int hunger { get; set; }
        public int sleep { get; set; }
        public int boredom { get; set; }
        public int health { get; set; }
        public DateTime lastAcces { get; set; }
        public Status status { get; set; }

        public Tamagotchi()
        {
            name = "";
            hunger = -1;
            sleep = -1;
            boredom = -1;
            health = -1;
            lastAcces = DateTime.Now;
            status = new Status();
        }

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

        public Tamagotchi(String name, int hunger, int sleep, int boredom, int health, DateTime lastAcces, Status status)
        {
            this.name = name;
            this.hunger = hunger;
            this.sleep = sleep;
            this.boredom = boredom;
            this.health = health;
            this.lastAcces = lastAcces;
            this.status = status;
        }

    }
}
