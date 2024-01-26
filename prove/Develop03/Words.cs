using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Words
{
   public string Text {get;}

   public bool IsHidden { get; set; }
   
   public Words( string text)
   {
    Text=text;
    IsHidden = false;
    
   }


    public string Hidden( string item)
    {
         return new ('_', item.Length);
    }


    public bool Ishidden()
    {
        return true;

    }

    public string GetDisplayText()
    {
        return "";
    }
}