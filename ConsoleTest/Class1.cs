using System;
using System.Text.RegularExpressions;

public class Class1 { 

    public void regularExpression(string txtRegNo)
        {

        /*//check myanmar font but complex with zawgyi
        string Pattern1 = @"^[\\\-~!@#$%^*()_+{}:|""?`;',./[\]\u1000-\u109F\uA9E0-\uAA7F]+$";

        *//*  string Pattern2 = @"^[a-zA-Z0-9 \\\-~!@#$%^*()_+{}:|""?`;',./[\]]+$";*//*

        Regex regex1 = new Regex(Pattern1);

        *//*  Regex regex2 = new Regex(Pattern2);*//*

        Match match1 = regex1.Match(txtRegNo);

        Console.WriteLine(match1.Success);*/

        /*  Match match2 = regex2.Match(this.txtRegNo.Text.Trim());*/
        /*string pattern1 = "^([\u1000-\u109F\uA9E0-\uAA7F]+)$";*//*
        string pattern1 = "^([^\u1000-\u109F\uA9E0-\uAA7F]+)$";
        *//*string pattern2 = @"^([a-zA-Z0-9 \\\-~!@#$%^*()_+{}:|""?`;',./[\]]+)$";*//*
        string pattern2 = "^([^a-zA-Z0-9]+)$";

        Regex regex1 = new Regex(pattern1);

        Regex regex2 = new Regex(pattern2);

            Match match1 = regex1.Match(txtRegNo);

            Match match2 = regex2.Match(txtRegNo);

            if (match1.Success)
            {
                Console.WriteLine("Success with English Format");
            }

            else if (match2.Success)
            {
                Console.WriteLine("Success with Unicode");
            }

            else
            {
                Console.WriteLine("Unsupported Format");
            }*/

        /*Console.WriteLine("Hello World!");

      string pattern1 = @"\b[M]\w+";

      Regex rg = new Regex(pattern1);

      string author = "Miracle , Moon , Tundra";

      MatchCollection matchedAuthors = rg.Matches(author);

      for (int count = 0; count < matchedAuthors.Count; count++)
          Console.WriteLine(matchedAuthors[count].Value);*/

        /*  string testString = "စာရင်းစာမျက်နှာသို့ပြန်သွားရန်";

          string pattern = @"^([\u1000-\u109F\uA9E0-\uAA7F \\\-~!@#$%^*()_+{}:|""?`;',./[\]]+)$";

          Regex regex = new Regex(pattern);

          Match match = regex.Match(testString);

          if (match.Success)
          {
              Console.WriteLine(regex.IsMatch(testString));
              Console.WriteLine(match.Value);
          }*/

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
