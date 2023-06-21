public class Goals
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal NewGoal)
    {
        _goals.Add(NewGoal);
    }

    public void DisplayGoals()
    {
        Console.Clear();
        for (int i = 0; i < _goals.Count; i++)
        {
            _goals[i].Display();
        }
    }
}