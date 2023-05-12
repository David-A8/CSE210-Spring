Prompt Question1 = new Prompt();
Prompt Question2 = new Prompt();
Console.WriteLine(Question1.Display());
Console.WriteLine(Question2.Display());

Entry Ent1 = new Entry(DateTime.Today, Question2);
Console.WriteLine(Ent1.GetEntry());
Entry Ent2 = new Entry(DateTime.Today,Question1);

Journal jour = new Journal();
jour.AddEntries(Ent1);
jour.AddEntries(Ent2);
jour.Display();