using System;

namespace DesignPattern.FactoryMethod
{
    public class AppConfigHelper
    {
        public static string GetLoggerFactoryName()
        {
            string factoryName = null;
            try
            {
                factoryName = System.Configuration.ConfigurationManager.AppSettings["LoggerFactory"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetLoggerFactoryInstance()
        {
            string assemblyName = AppConfigHelper.GetLoggerFactoryName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
