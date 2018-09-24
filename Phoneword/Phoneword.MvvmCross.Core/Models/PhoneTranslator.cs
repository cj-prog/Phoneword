using System;
using System.Text;

namespace Phoneword.MvvmCross.Core.Models
{
    public class PhonewordTranslator //TEST
    {

        public String PhoneNumberText(string phoneNumberText)
        {
            if (phoneNumberText != "")
            {
                return ToNumber(phoneNumberText);
            }

            return "1-555-XAMARIN";
        }

        public string ToNumber(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                return null;

            raw = raw.ToUpperInvariant();

            var newNumber = new StringBuilder();
            foreach (var c in raw)
            {
                if (Contains(" -0123456789", c))
                    newNumber.Append(c);
                else
                {
                    var result = TranslateToNumber(c);
                    if (result != null)
                        newNumber.Append(result);
                    // Bad character?
                    else
                        return null;
                }
            }
            return newNumber.ToString();
        }

        bool Contains(string keyString, char c)
        {
            return keyString.IndexOf(c) >= 0;
        }

        static readonly string[] digits = {
            "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"
        };


        int? TranslateToNumber(char c)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (Contains(digits[i], c))
                    return 2 + i;
            }
            return null;
        }

        public (bool IsEnabled, string Text, string TranslatedNumber) Translate(string phoneNumberText)
        {
            // return isEnabled and button Text.

            var translatedNumber = ToNumber(phoneNumberText);
            var buttonText = "Call";

            if (string.IsNullOrWhiteSpace(translatedNumber)) return (false, buttonText, translatedNumber);

            buttonText = "Call " + translatedNumber;

            return (true, buttonText, translatedNumber);
        }

        public void Call(string TranslatedNumber)
        {
            //return
            //(
            //    "Dial a Number",
            //    " Would you like to call" + TranslatedNumber + "?",
            //    "Yes",
            //    "No"
            //);
        }
    }
}