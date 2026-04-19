namespace EquipRent.Models;

public class Equipment
{
    private static int idToAssign = 1;
    private static List<Equipment> inventory = new List<Equipment>();

    private Equipment(string make, string model)
    {
        this.Make = make;
        this.Model = model;
        Available = true;
        Id = idToAssign++;
        inventory.Add(this);
    }

    public string Make { get; }
    public string Model { get; }
    public bool Available { get; set; }
    public int Id { get; }
}