

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;


public class LogError : ILogException
{
    private string UserName { get; set; }
    private string ApplicationName { get; set; }
    
    private UserAccessDbContext _dbContext;
    
    public LogError(UserAccessDbContext dbContext)
    {
        _dbContext = dbContext;
    }
  
    public void LogErrorFileSystem(System.Exception ex, string action)
    {
        using (StreamWriter writer = new StreamWriter(@"\\10.10.7.217\\NASShare\WEBLogs\" + ApplicationName + ".txt", true))
        {
            writer.WriteLine(DateTime.Now.ToString() + ": UserName: " + UserName + ": Action:" + action + ": " + ex.Message + ": \r\nStack Trace: " + ex.StackTrace + ":");
        }
        // throw new NotImplementedException();
    }

    public int LogErrorDB(System.Exception ex, string action)
    {
        throw new NotImplementedException();

    }
}
