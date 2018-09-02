using System;

namespace Managers
{
    public class ErrorManager
    {
        public static void PersistError(Exception error)
        {
           //persist the error
        }

        public static void ReportBadMessage(string value)
        {
            throw new NotImplementedException();
        }
    }
}
