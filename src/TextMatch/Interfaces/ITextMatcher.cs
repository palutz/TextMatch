namespace TextMatch.Interfaces
{
	public interface ITextMatcher
	{
		int[] MatchText(string mainstr, string substr);
	}
}