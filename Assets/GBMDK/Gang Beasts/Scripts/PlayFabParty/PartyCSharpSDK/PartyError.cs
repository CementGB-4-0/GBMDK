namespace PartyCSharpSDK
{
    public class PartyError
    {
        public const uint Success = 0u;

        public const uint InvalidArg = 4u;

        public const uint UnsupportedPartyOption = 4305u;

        public static bool SUCCEEDED(uint error)
        {
            return false;
        }

        public static bool FAILED(uint error)
        {
            return false;
        }
    }
}