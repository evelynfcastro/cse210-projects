using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Scripture
{
    Reference _reference {get;}
    public List<Words> _word;
    public string Text {get;}
    
   

    public Scripture( Reference reference, string text)
    {
       reference= _reference;
       Text = text;

        string[] wordArray = text.Split(' ');
       _word= new List<Words>();
       foreach (string item in wordArray)
       {
        _word.Add(new Words(item));
       }
      
       
    }
    public void HiddenRandomWords( double porcentageToHidde)
    {
    
      porcentageToHidde = Math.Max(0, Math.Min(porcentageToHidde, 1));
      int numberWordToHide =(int) (_word.Count * porcentageToHidde);
      Random random = new Random();
      for (int i = 0; i < numberWordToHide; i++)
      {
          int randomIndex = random.Next(0, _word.Count);
        _word[randomIndex].IsHidden = true;
      }


    }
    public string GetDisplayText()
    {

      string hiddedText = "";

      foreach ( var word in _word)
      {
        if (word.IsHidden)
        {
          hiddedText += new string ('_', word.Text.Length) + " ";
        }
         else
            {
                hiddedText += word.Text + " ";
            }
        }
        return hiddedText.Trim();
    }


      
        
    
    public bool IsCompletlyHidden()
    {
        
        return _word.All(word => word.IsHidden);

    }
}