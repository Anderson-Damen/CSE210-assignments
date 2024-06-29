public abstract class Goal
{
   protected string _name;
   protected string _description;
   protected int _points;
   protected bool _isComplete;

   public Goal(string name, string description, int points, bool isCompleted)
   {
       _name = name;
       _description = description;
       _points = points;
       _isComplete = isCompleted;
   }

   public string Getname()
   {
       return _name;
   }

   public string Getdescription()
   {
       return _description;
   }

   public int Getpoints()
   {
       return _points;
   }
   public abstract int GetTotalPoints();
}