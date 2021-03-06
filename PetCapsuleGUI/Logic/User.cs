﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCapsuleGUI.Logic
{
    [JsonObject(MemberSerialization.OptIn)]
    class User
    {
        [JsonProperty]
        private string username;
        [JsonProperty]
        private string password;
        [JsonProperty]
        private string email;
        [JsonProperty]
        private string firstname;
        [JsonProperty]
        private string lastname;
        [JsonProperty]
        private string address;
        [JsonProperty]
        private string city;

        [JsonProperty]
        private List<Cage> cages = new List<Cage>(); 

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public List<Cage> Cages
        {
            get { return cages; }
            set { cages = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public User(string username, string password, string email, string firstname, string lastname, string address, string city)
        {
            Username = username;
            Password = password;
            Email = email;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            City = city;
        }

        public User() { }

        public User(string firstname, string lastname, string address, string city)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            City = city;
        }

        public void addCage(Cage c)
        {
            cages.Add(c);
        }

        public List<Cage> getCages()
        {
            return cages;
        }

        public Cage getCage(int index)
        {
            return cages[index];
        }
    }
}
