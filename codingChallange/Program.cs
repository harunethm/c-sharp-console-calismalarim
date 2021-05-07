using System;
namespace codingChallange {
    class Program {
        private static string Reverse(string str) {
            string revStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
                revStr += str[i];
            return revStr;
        }
        static void Main(string[] args) {
            int counter = 0;//added letters counter
            Console.WriteLine("Please enter the string : ");
            string input = Console.ReadLine();
            int len = input.Length;//input's first length
            string inputRev = Reverse(input);//the reverse of the input

            while (input != inputRev) { //while the input not equal to reverse 
                char[] tempInput = input.ToCharArray();//input converted to array
                Array.Resize(ref tempInput, input.Length + 1);//a space was added to the array
                if (counter > 0)//if it's not first round
                    for (int i = tempInput.Length - 2; i >= len; i--)//created an empty slot in array for the new letter
                        tempInput[i + 1] = tempInput[i];
                tempInput[input.Length - counter] = tempInput[counter];//letters have been moved in here
                input = new string(tempInput);//the new word value assigned to input variable
                inputRev = Reverse(input);//the reverse of the input has been updated
                counter++;//increased for one added letter
            }
            Console.WriteLine(inputRev);
            Console.WriteLine(counter);
            Console.ReadLine();//to wait until you close
        }   }   }