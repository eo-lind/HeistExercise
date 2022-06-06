// ------------------------------team member class------------------------------------ //
public class TeamMember
{
    // constructor for class properties
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public double CourageFactor { get; set; }

    // constructor for instance of class (object)
    public TeamMember(string name, int skillLevel, double courageFactor)
    {
        Name = name;
        SkillLevel = skillLevel;
        CourageFactor = courageFactor;
    }
}
// ----------------------------end team member class---------------------------------- //