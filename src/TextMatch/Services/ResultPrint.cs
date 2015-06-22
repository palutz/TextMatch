using System;
using System.Text;
using System.Collections.Generic;

using TextMatch.Interfaces;

namespace TextMatch.Services
{
	public class ResultPrint : IResultPrint
	{
		public string PrintResult(int[] alist)
		{
			if(alist == null || alist.Length == 0)
				return String.Empty;

			StringBuilder strb = new StringBuilder();
			strb.Append(alist[0] + 1);
			for(int i = 1; i <  alist.Length; i++)
			{
				strb.Append(String.Format(", {0}", alist[i] + 1));  // convert from 0 base array index
			}
			
			return strb.ToString();
		}
	}
}