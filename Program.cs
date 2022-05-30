using System;
using System.Collections.Generic;

//! static void Main(string[] args)
// {
// }
    
Console.WriteLine("Plan Your Heist!");

// Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a TODO: decimal between 0.0 and 2.0.
namespace Heist
{
    // ------------------------------team member class------------------------------------ //
    public class TeamMember
    {
        // constructor for class properties
        public string Name { get; set; }
        public int SkillLevel { get; set ; }
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
}