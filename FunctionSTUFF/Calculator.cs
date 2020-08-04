using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace FunctionSTUFF
{
    class Calculator
    {
        string[] Operators = {"+", "-", "*", "/"};
        Dictionary<string, string> reverseOperators;
        public Calculator()
        {
            reverseOperators = new Dictionary<string, string>();
            reverseOperators.Add("+", "-");
            reverseOperators.Add("-", "+");
            reverseOperators.Add("*", "/");
            reverseOperators.Add("/", "*");
        }

        // * 3 + 4 / 5
        public double CalculateFunction(double num, string query)
        {
            string[] arr = query.Split(" ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                string s = arr[i];
                if (!Operators.Contains(s)) continue;
                float next = float.Parse(arr[i + 1]);
                switch (s.ToUpper()) 
                { 
                    case "*":
                        num *= next;
                        break;
                    case "+":
                        num += next;
                        break;
                    case "-":
                        num -= next;
                        break;
                    case "/":
                        num /= next;
                        break;
                    default:
                        break;
                }
            }
            return num;
        }

        

        public string GetInverseFunction(string function)
        {
            string s = "";
            string[] arr = function.Split(" ");
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (!Operators.Contains(arr[i])) continue;
                string next = arr[i + 1];
                s += reverseOperators[arr[i]];
                s += " ";
                s += next;
                s += " ";
            }
            return s;
        }
    }
}
