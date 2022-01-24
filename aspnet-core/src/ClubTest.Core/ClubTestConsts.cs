using ClubTest.Debugging;

namespace ClubTest
{
    public class ClubTestConsts
    {
        public const string LocalizationSourceName = "ClubTest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ad846340558f4ef28d863a73724efadc";
    }
}
