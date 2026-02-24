using System;

public class Client
{
    public int Id { get ; set; }
    public string Name {get; set;} = string.Empty;
    public string Motive { get; set;} = string.Empty;

    public Client (int id, string name, string motive)
    {
        Id = id;
        Name = name;
        Motive = motive;
    }
}