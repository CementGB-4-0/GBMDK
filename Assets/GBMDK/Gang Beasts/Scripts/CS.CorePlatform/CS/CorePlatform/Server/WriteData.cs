using CS.CorePlatform.Utils.Data;

namespace CS.CorePlatform.Server
{
    public interface WriteData
    {
        void WriteData(DataWriter writer);

        void ReadData(DataReader read);
    }
}