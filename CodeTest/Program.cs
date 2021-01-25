using static System.Console;

class P
{
    static void Main()
    {
        var u=ReadLine();

        string r=u.Contains(':')?u:u.Contains('.')?$"http://{u}":$"ftp://{u}";


        //string r;
        //if (u.Contains(':'))
        //    r = u;
        //else
        //    if (u.Contains('.'))
        //    r = $"http://{u}";
        //else
        //    r = $"ftp://{u}";

        WriteLine(r);

    }
}
