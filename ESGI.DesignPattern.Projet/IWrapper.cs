namespace ESGI.DesignPattern.Projet
{
    public interface IWrapper
    {
        void AddChild(IXmlFormattable xmlFormattable);
        int CountChildren();
        IXmlFormattable GetChild(int index);
    }
}