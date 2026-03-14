namespace RestApiTests.Models;

public class ObjectModel
{
    public string name { get; set; }
    public Data data { get; set; }
}

public class Data
{
    public int year { get; set; }
    public double price { get; set; }
    public string CPUmodel { get; set; }
    public string HardDiskSize { get; set; }
}