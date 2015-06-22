using System;
using System.Linq;
using System.Collections.Generic;

using TextMatch.Interfaces;

namespace TextMatch.Services
{
	public class TextMatcher : ITextMatcher
	{
		// Verify that all the chars are matching
		private bool IsStringMatching(string mainstr, string substr, int pos)
		{
			int ln = substr.Length;
			int i = 0;
			while((i < ln) && (mainstr[pos+i] == substr[i]))
				i++;
				
			return 	(i == ln);
		}
		
		public int[] MatchText(string mainstr, string substr)
		{
			// verify that the parameters are correct
			if(String.IsNullOrEmpty(substr) || String.IsNullOrEmpty(mainstr) || mainstr.Length < substr.Length)
				return new int[0];

			// converto all to lowercase (case insensitive)
			mainstr = mainstr.ToLower();
			substr = substr.ToLower();
			
			List<int> res = new List<int>(); 
			for(int i = 0; i < mainstr.Length - substr.Length + 1; i++)
			{
				if(mainstr[i] == substr[0])  // find the first matching char
					if(IsStringMatching(mainstr, substr, i))
						res.Add(i);
			}
	
			return res.ToArray();
		}
	}
}