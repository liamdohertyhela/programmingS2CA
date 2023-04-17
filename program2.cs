namespace CA3S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shipfile[] myShipFile=new shipfile[345];

            FileStream fs = new FileStream("faminefile.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            

            string recordIn = sr.ReadLine();

            string[] fields = new string[9];//reps how many parts are in the array 3 here as it is Number, name, result

            int sum = 0;
            int count = 0;

            while (recordIn != null)
            {
                fields = recordIn.Split(',');

                //Console.WriteLine($"{fields[0]}\t {fields[1]}\t{fields[2]}\t{fields[3]}\t{fields[4]}\t{fields[5]}\t{fields[6]}\t{fields[7]}\t{fields[8]}\t{fields[9]}");
                

                Console.WriteLine($"{fields[1]}   {fields[0]}");//THIS IS THE 1ST PART OF PART TWO READS THE NAMES OUT 
                
                //fields[0] = myShipFile[0].PassengerFirstName;
                //fields[1] = myShipFile[0].PassengerSurname;

                //sum += int.Parse(fields[9]);

                count++;


                recordIn = sr.ReadLine();
            }
            //Console.WriteLine($"Average {avg}");
            sr.Close();









        }
    }
}