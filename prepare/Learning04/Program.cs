Assignment test1 = new Assignment("Keegan","Family and Marriage");
Console.WriteLine(test1.GetSummary());
MathAssignment assign1 = new MathAssignment("David","Church History","7.3","8-19");
Console.WriteLine($"{assign1.GetSummary()}\n{assign1.GetHomeworkList()}");
WritingAssignment assign2 = new WritingAssignment("Tanner","Modern Music","T Swift and her songwriting");
Console.WriteLine(assign2.GetSummary());
Console.WriteLine(assign2.GetWritingInformation());