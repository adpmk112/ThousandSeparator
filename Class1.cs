using System;

public class Class1
{
	public Class1()
	{
		public void regularExpression()
        {
            /*Console.WriteLine("Hello World!");

          string pattern1 = @"\b[M]\w+";

          Regex rg = new Regex(pattern1);

          string author = "Miracle , Moon , Tundra";

          MatchCollection matchedAuthors = rg.Matches(author);

          for (int count = 0; count < matchedAuthors.Count; count++)
              Console.WriteLine(matchedAuthors[count].Value);*/

            string testString = "စာရင်းစာမျက်နှာသို့ပြန်သွားရန်";

            string pattern = @"[\u1000-\u109F\uA9E0-\uAA7F]";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(testString);

            if (match.Success)
            {
                Console.WriteLine(regex.IsMatch(testString));
                Console.WriteLine(match.Value);
            }

            /*string testString = "12/TAMANA(N)123016";

            string pattern = @"[a-zA-Z0-9 \\\-~!@#$%^*()_+{}:|""?`;',./[\]]+";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(testString);

            if (match.Success)
            {
                Console.WriteLine(regex.IsMatch(testString));
            }*/

        }
    }
}
