namespace AirplaneSoundBites.Service
{
    public interface IClipRepository
    {

        string[] GetAllClipsFullPath();
        string[] GetClipFileNames();
        string GetClipFullPath(string clipName);

    }
}