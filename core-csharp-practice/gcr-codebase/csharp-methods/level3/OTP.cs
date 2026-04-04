using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class OTP
    {
        public static void OTPfn() {               
                int[] arrayOfOTP = new int[10];

                // Generating OTP
                for(int i = 0; i < arrayOfOTP.Length; i++){
                    arrayOfOTP[i] = GenerateOTP();
                    Console.WriteLine("Generated OTP " + (i + 1) + ": " + arrayOfOTP[i]);
                }

                bool isOTPUnique = OTPsUniqueCheck(arrayOfOTP);

                if(isOTPUnique){
                    Console.WriteLine("Generated OTPs are unique");
                }
                else{
                    Console.WriteLine("OTPs are not unique");
                }
        }

        //Method to generate a OTP
        public static int GenerateOTP(){
            Random random = new Random();
            return random.Next(100000, 1000000);
        }

        //Method to check uniqueness
        public static bool OTPsUniqueCheck(int[] otps){

            for(int i = 0; i < otps.Length; i++){
                for(int j = i + 1; j < otps.Length; j++){
                    if(otps[i] == otps[j]){
                        return false;
                    }
                }
            }

            return true;

        }
    }
}
