public class File
{
private string _filename;

public void SaveInFile( string filename, List<string> meals)
{


            using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var item in meals)
            {
                writer.WriteLine(item);
            }
        }



}
 
 
}