Player axa = new Player("Axa", "Uribe", 10);
Player michael = new Player("Michael", "Jordan", 25);
axa.Display();


Team fireballs = new Team("Fireballs");
fireballs.AddPlayer(axa);

Team tigers = new Team("Tigers");
tigers.AddPlayer(michael);

Match match1 = new Match(fireballs, tigers);
match1.DecideWin();
