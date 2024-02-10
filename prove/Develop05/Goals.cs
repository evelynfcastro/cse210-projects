public abstract class Goals
{

   private string _name;
   private string _description; 
   private int _points;

  protected bool isComplete;

   

   
   public Goals()
   {

   }
   
   public Goals(string name, string description, int points)
   {
    _name=name;
    _description= description;
    _points= points;
   }


  public void SetName(string name)
  {
    
    _name=name;
  }
  public void SetDescription(string description)
  {
    _description= description;
  }
  public virtual void SetPoints(int points)
  {
    _points=points;
  }
   public string GetName()
   {
    return _name;
   }
    public  string GetDescription()
   {
    return _description;
   }

    public virtual int GetPoints()
   {
    return _points;
   }

  public abstract string GetStringRepresentation();
  public virtual void GetStringInformation()
  {
     Console.WriteLine("What is your goal name?");
        SetName(Console.ReadLine());
        Console.WriteLine("What is your goal's description?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points this goal will have?");
        string points =Console.ReadLine();
        int ponts= int.Parse( points);
        SetPoints(ponts);

  }
   public abstract bool IsComplete();
  public abstract void RecordEvent();

  //public abstract string GetStringRepresentation();


   
}
