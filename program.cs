namespace CANew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join("",readRecord("124","cake.txt",1))); //"Spinster","faminefile.csv",4
            Console.ReadLine();
        }

        static string[] readRecord(string searchTerm, string filePath,int positionOfSearchTerm)//postion is what field the search term is in
        {
            positionOfSearchTerm -- ;//meant to be more user friendly could take out
            string[] recordNotFound = { "Record not found" };//returns in catch block
            try
            {
                string[] lines = File.ReadAllLines(@filePath);//this will store each line in the file

                for(int i =0; i < lines.Length; i++)//checks through each line
                {
                    string[] fields=lines[i].Split(' ');//creating a sub array of each fielld from pone record 
                    if(recordMatches(searchTerm,fields,positionOfSearchTerm)) //this retruns the record if the field is in there, eg if it finds field 7 for jobs it will return their job 
                    {
                        Console.WriteLine("Found a record");
                        return fields;
                        //need to add the if satement check of what job has been returned then the counter
                        //this is hwere i should add a counter


                    }
                    else
                    {
                        Console.WriteLine("help");
                    }
                    Console.WriteLine("Yes the for loop is working dumbfuck");
                }
                return recordNotFound;




            }
            catch(Exception ex)
            {
                Console.WriteLine("This program failed ");
                return recordNotFound;
                throw new ApplicationException("This program failed",ex);
            }

        }
        static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)// the string record is passing in all the fields from that number
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;


        }
    }
}