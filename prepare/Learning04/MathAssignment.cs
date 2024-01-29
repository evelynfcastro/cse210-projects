using System.Runtime.CompilerServices;

public class Mathassignments : Assignments 
{
    private string _textbookSection="";
    private string _problems="";

    public Mathassignments( string name, string topic, string textbookSection, string problems) :base(name,topic)
    {
        _textbookSection= textbookSection;
        _problems=problems;
    }
    public string GetTextBookSection()
    {
        return _textbookSection;
    }
   

     public string GetProblems()
    {
        return _problems;
    }
   
    public string GetHomeworkList()
    {
        return $" {GetSummary()} \n Section: {_textbookSection} Problems {_problems} ";
    }
}
 



