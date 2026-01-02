using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class HotelBooking
    {
        public string guestName;
        public string roomType;
        public int nights;

        // Default constructor
        public HotelBooking(){
            guestName = "Aditey";
            roomType = "AC";
            nights = 3;
        }

        // Parameterized constructor
        public HotelBooking(string nameOfGuest, string typeOfRoom, int nightsStay){
            guestName = nameOfGuest;
            roomType = typeOfRoom;
            nights = nightsStay;
        }

        // Copy constructor
        public HotelBooking(HotelBooking roomBooking){
            guestName = roomBooking.guestName;
            roomType = roomBooking.roomType;
            nights = roomBooking.nights;
        }


        // Method to display booking details
        public void BookingDisplay(){
            Console.WriteLine($"Guest Name: {guestName}");
            Console.WriteLine($"Room Type : {roomType}");
            Console.WriteLine($"Nights    : {nights}");
            Console.WriteLine("------------------------");
        }

        //Method to demonstrate all the working
        public static void HotelBookingSystem(){

            HotelBooking roomBooking1 = new HotelBooking();

            HotelBooking roomBooking2 = new HotelBooking("Aditey Rai", "Deluxe", 3);

            HotelBooking roomBooking3 = new HotelBooking(roomBooking2);

            roomBooking1.BookingDisplay();
            roomBooking2.BookingDisplay();
            roomBooking3.BookingDisplay();
        }
    }
}
