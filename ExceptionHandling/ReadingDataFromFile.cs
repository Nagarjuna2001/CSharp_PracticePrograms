using System;
using System.IO;
using NLog;

namespace ExceptionHandling
{
    class ReadingDataFromFile
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("The program started executing");
            StreamReader DataFromFile = null;
            try
            {
                DataFromFile = new StreamReader(@"C:\Rainbow\Data.txt");
                Console.WriteLine(DataFromFile.ReadToEnd());

            }
            catch(FileNotFoundException exception)
            {
                //Log the details to DB
                Console.WriteLine("Please check if the file {0} exists",exception.FileName);
                logger.Error("The file was not found " + exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                logger.Error(exception.Message);
            }
            finally
            {
                if(DataFromFile != null)
                {
                    DataFromFile.Close();
                }
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
