namespace Fly.Dal
{
    public static class ModuleConfigurator
    {
        public static void Configure()
        {
            RegisterEF();
        }

        /// <summary>
        /// Configure app with EF
        /// </summary>
        private static void RegisterEF()
        {
        }

        /// <summary>
        /// Configure app with SQL
        /// </summary>
        private static void RegisterSQL()
        {
        }
    }
}
