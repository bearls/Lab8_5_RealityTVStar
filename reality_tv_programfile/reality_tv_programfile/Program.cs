using System;
using System.Collections.Generic;
using System.Text;

namespace reality_tv_programfile
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseHunterChild hhContestant = new HouseHunterChild("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
                "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

            ParadiseIslandChild piContestant = new ParadiseIslandChild("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles",
                "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

            AboveDeckChild adContestant = new AboveDeckChild(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles",
            "California", 90001, "711-333-1234", "captian@gmail.com");

            hhContestant.Submit();
            hhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();


        }
    }
}
