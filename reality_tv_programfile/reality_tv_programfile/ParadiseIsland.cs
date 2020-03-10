using System;
using System.Collections.Generic;
using System.Text;

namespace reality_tv_programfile
{

	class ParadiseIslandChild : tvshowParent
    {
        public string gender;
        public string nameOfBoyOrGirlFriend;
        public int yearsDating;

        public ParadiseIslandChild(string gender, string nameOfBoyOrGirlFriend, int yearsDating,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.gender = gender;
            this.nameOfBoyOrGirlFriend = nameOfBoyOrGirlFriend;
            this.yearsDating = yearsDating;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island");
        }
    }
}


