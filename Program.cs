using Csla;
using Csla.Configuration;
using System;

namespace CslaMobileFormatterBug
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager.AppSettings.Set("CslaSerializationFormatter", "MobileFormatter");

            var sbo = DataPortal.Create<SimpleBusinessObject>();

            sbo.BeginEdit();

            Console.ReadLine();
        }
    }
}
