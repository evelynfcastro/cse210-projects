using System.Security.Cryptography.X509Certificates;

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

public void LoadFile(string filename)
{
 
       
            using (StreamReader reader = new StreamReader(filename))
            {
            string fileContent = reader.ReadToEnd();

                // Display the content (you can process or manipulate it as needed)
                Console.WriteLine("Meal List");
                Console.WriteLine(fileContent);
            }
       
    



}
 
 
}