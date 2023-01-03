using System;
using System.Linq;
using System.Text;

namespace AlgorithmClass
{
	public class Program
	{
		//string validation algorithm
		static bool IsUpperCase(string s)
		{
			return s.All(char.IsUpper);
		}

		static bool IsLowerCase(string s)
		{
			return s.All(char.IsLower);
		}


		//this checks if the passcode follows the rule
		static bool IsPasswordComplex( string s)
		{
			//Any() checks if any of the character contains needed value 
			return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
		}

		//Normalizing Data this help in achieving a more efficient algorithm
		static string NormalizeString(string input)
		{
			//the Tolower() helps convert character to lower case, the Trim()
			//remove whitespace and the replace() removed the specified character in the bracket from the string
			return input.ToLower().Trim().Replace(",", "");
		}

		//Parsing the content of a string
		static void ParseContent(string s)
		{
			Console.WriteLine("option1");

			foreach(char c in s)
			{
				Console.WriteLine(c);
			}

			Console.WriteLine("option2");
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				Console.WriteLine(c);
			}
				
				
		}
		
		//if the search is to know the character in the even index of the string 
		static Boolean IsEvenIndex(String s, char item)
		{
			if (String.IsNullOrEmpty(s))//check if the string is null
			{
				return false;
			}
			//this search the precised even location
			for (int i = 0; i <s.Length /2 + 1 ; i = i + 2)
			{
				if(s[i] == item)
				{
					return true;
				}
			}
			return false;
		}

		//Creating a new string 
		static String Reverse(String input)
		{
			if (String.IsNullOrEmpty(input))//check if the string is null
			{
				return input;
			}

			StringBuilder reversed = new StringBuilder(input.Length);
			//this start the operation from the last char of the string then decrement the string
			for(int i = input.Length-1; i >= 0; i--)
			{
				reversed.Append(input[i]);// this add the new created char to the index
			}

			return reversed.ToString(); // the convert the stringBuilder to string
		}

		static String Reverse2( String input)
		{
			if (String.IsNullOrEmpty(input))
			{
				return input;
			}

			char[] arr = input.ToCharArray();
			Array.Reverse(arr);
			return new String(arr);
		}


		//reverse word
        static String ReverseWord(String input)
        {
           if (String.IsNullOrEmpty(input))
            {
                return input;
            }

			StringBuilder result = new StringBuilder();
			String[] arr = input.Split(" ");
			return string.Join(" ",arr.Reverse());
        }

		static String ReverseSentence(String input)
		{
            if (String.IsNullOrEmpty(input))
                return input;
            String[] arr = input.Split(" ");
            StringBuilder result = new StringBuilder();
            for (var i = 0; i < arr.Length; i++)
			{
				result.Append(Reverse(arr[i]));
				if(i != arr.Length - 1) 
					result.Append(" ");
            }
			return result.ToString();
            
        }

        static void Main(string[] args)
		{
			
			Console.WriteLine(ReverseWord("Rayo is my name!"));
			Console.WriteLine(ReverseSentence("Hello my people!"));
			//Console.WriteLine(Reverse2("")); 
			//Console.WriteLine(Reverse2("torcS"));
			//Console.WriteLine(Reverse2("Ligali"));
			//Console.WriteLine(Reverse2("Racecar"));

			//Console.WriteLine("Reverse");
			//Console.WriteLine(Reverse("Omotolani"));
			//Console.WriteLine(Reverse("Hello World!"));
			//Console.WriteLine(Reverse(""));
			//Console.WriteLine(Reverse("torcS"));
			//Console.WriteLine(Reverse("Ligali"));
			//Console.WriteLine(Reverse("Racecar"));
		}
	}
}
