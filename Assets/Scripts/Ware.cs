using System;

[Serializable]
public class Ware
{
    public string name;
    public int menge;


    public Ware(string name, int menge)
    {
        this.name = name;
        this.menge = menge;
    }
}