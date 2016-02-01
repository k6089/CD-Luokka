using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD myCDs = new CD();

            CD disc1 = new CD { Name = "Endless Forms Most Beautiful", Artist = "Nightwish", Price = 11.95 };
            CD disc2 = new CD { Name = "My God-Given Right", Artist = "Helloween", Price = 24.95 };

            //first cds here and then tracks

            Songs mySongs = new Songs();

            Songs EndlessFormsTrackOne = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Shudder Before the Beautiful", Artist = "Nightwish", Lenght = 6.29 };
            Songs EndlessFormsTrackTwo = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Weak Fantasy", Artist = "Nightwish", Lenght = 5.23 };
            Songs EndlessFormsTrackThree = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Elan", Artist = "Nightwish", Lenght = 4.45 };
            Songs EndlessFormsTrackFour = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Yours Is an Empty Hope", Artist = "Nightwish", Lenght = 5.34 };
            Songs EndlessFormsTrackFive = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Our Decades in the Sun", Artist = "Nightwish", Lenght = 6.37 };
            Songs EndlessFormsTrackSix = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "My Walden", Artist = "Nightwish", Lenght = 4.38 };
            Songs EndlessFormsTrackSeven = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Endless Forms Most Beautiful", Artist = "Nightwish", Lenght = 5.07 };
            Songs EndlessFormsTrackEight = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Edema Ruh", Artist = "Nightwish", Lenght = 5.15 };
            Songs EndlessFormsTrackNine = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "Alpenglow", Artist = "Nightwish", Lenght = 4.45 };
            Songs EndlessFormsTrackTen = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "The Eyes of Sharbat Gula", Artist = "Nightwish", Lenght = 6.03 };
            Songs EndlessFormsTrackEleven = new Songs { CDName = "Endless Forms Most Beautiful", TrackName = "The Greatest Show on Earth", Artist = "Nightwish", Lenght = 24.00 };

            Songs MyGodGivenRightI = new Songs { CDName = "My God-Given Right", TrackName = "Heroes", Artist = "Helloween", Lenght = 3.51};
            Songs MyGodGivenRightII = new Songs { CDName = "My God-Given Right", TrackName = "Battle’s Won", Artist = "Helloween", Lenght = 4.53};
            Songs MyGodGivenRightIII = new Songs { CDName = "My God-Given Right", TrackName = "My God-Given Right", Artist = "Helloween", Lenght = 3.30};
            Songs MyGodGivenRightIV = new Songs { CDName = "My God-Given Right", TrackName = "Stay Crazy", Artist = "Helloween", Lenght = 4.05};
            Songs MyGodGivenRightV = new Songs { CDName = "My God-Given Right", TrackName = "Lost in America", Artist = "Helloween", Lenght = 3.35};
            Songs MyGodGivenRightVI = new Songs { CDName = "My God-Given Right", TrackName = "Russian Roulé", Artist = "Helloween", Lenght = 3.53};
            Songs MyGodGivenRightVII = new Songs { CDName = "My God-Given Right", TrackName = "The Swing of a Fallen World", Artist = "Helloween", Lenght = 4.53};
            Songs MyGodGivenRightVIII = new Songs { CDName = "My God-Given Right", TrackName = "Like Everybody Else", Artist = "Helloween", Lenght = 4.04};
            Songs MyGodGivenRightIX = new Songs { CDName = "My God-Given Right", TrackName = "Creatures in Heaven", Artist = "Helloween", Lenght = 6.36};
            Songs MyGodGivenRightX = new Songs { CDName = "My God-Given Right", TrackName = "If God Loves Rock ‘n’ Roll", Artist = "Helloween", Lenght = 3.21};
            Songs MyGodGivenRightXI = new Songs { CDName = "My God-Given Right", TrackName = "Living on the Edge", Artist = "Helloween", Lenght = 5.19};
            Songs MyGodGivenRightXII = new Songs { CDName = "My God-Given Right", TrackName = "Claws", Artist = "Helloween", Lenght = 5.52};
            Songs MyGodGivenRightXIII = new Songs { CDName = "My God-Given Right", TrackName = "You, Still of War", Artist = "Helloween", Lenght = 7.21};



        }
    }
}
