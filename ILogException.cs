using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



   public interface ILogException
    {
    int LogErrorDB(Exception ex, string action);
    void LogErrorFileSystem(Exception ex, string action);

    }

