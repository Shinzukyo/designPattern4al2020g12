namespace ESGI.DesignPattern.Projet
{
    public interface IWrapper
    {
        void add(IXmlFormattable xmlFormattable);
        int count();
        IXmlFormattable getChild(int index);
    }
}