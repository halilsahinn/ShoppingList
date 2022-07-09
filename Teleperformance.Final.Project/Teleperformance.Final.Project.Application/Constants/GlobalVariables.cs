namespace Teleperformance.Final.Project.Application.Constants
{
    public static class GlobalVariables
    {
        #region SUMMARY
        /// <summary>
        /// Uygulamanın gerek duyduğu ayarlar.
        /// </summary>
        #endregion

        #region SYSTEM
        private static string MachineName;
        public static string MACHINE_NAME
        {
            get
            {
                return MachineName;
            }
            set
            {
                MachineName = Environment.MachineName.ToString();
            }
        }
        #endregion

        #region DATABASE
        public static string DB_SERVER_ADRDESS { get; set; }
        public static string DB_USER_NAME { get; set; }
        public static string DB_PASSWORD { get; set; }

        public static int DB_PORT { get; set; }

        public static string CONNECTION_STRING = $@"Server={MACHINE_NAME};Database={DB_USER_NAME};Trusted_Connection=True;Connect Timeout = 30; MultipleActiveResultSets=True;";

        public static string DEFAULT_SCHEMA { get; set; } = "dbo";
        #endregion

        #region SWAGGER

        #endregion
    }
}
