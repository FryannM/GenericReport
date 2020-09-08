namespace Modelo.Abstracts
{
    public static class Channel
    {
        public static string getConnnectionString(this string cnn)
        {
            Connection = cnn;
            return Connection;
        }
        //public static string Connection { get; set; } = "User Id=postgres; Password=Artesania99;Server=104.248.59.55;Port=5432; Database=medvelSRL; Pooling=true;";

        public static string Connection { get; set; } = "User Id=postgres; Password=Artesania99;Server=167.99.167.150;Port=5432; Database=fsa; Pooling=true;";
    }
    
}
