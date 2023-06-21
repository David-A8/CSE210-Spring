SimpleGoal test1 = new SimpleGoal();
test1.GetName("Goal1");
test1.GetDescription("This is a test goal");
test1.GetPoints(100);
Goals Collection = new Goals();
Collection.AddGoal(test1);
Collection.DisplayGoals();