using System;
using System.Collections.Generic;

//! static void Main(string[] args)
// {
// }
    
Console.WriteLine("Plan Your Heist!");
Console.WriteLine("Please provide the name of one of your team members.");
string newMember = Console.ReadLine();
Console.WriteLine($"Please enter a numerical skill level for {newMember}.");
string newMemberSkillLevelString = Console.ReadLine();
int newMemberSkillLevel = int.Parse(newMemberSkillLevelString);
Console.WriteLine($"Please enter a courage factor between 0.0 and 2.0 for {newMember}.)");
string newMemberCourageFactorString = Console.ReadLine();
double newMemberCourageFactor = Double.Parse(newMemberCourageFactorString);
Console.WriteLine($"Team Member: {newMember} | Skill Level: {newMemberSkillLevel} | Courage Factor: {newMemberCourageFactor}");

// TODO PHASE TWO Will need to refactor the way team members are added (with a method)
// TODO: 2.1 Create a way to store several team members. NOTE: the courage factor will be a decimal between 0.0 and 2.0 (will probably need a conditional to handle input outside of that range).
// TODO:  2.2 Collect several team members' information.
// TODO:  2.3 Stop collecting team members when a blank name is entered.
// TODO:  2.4 Display a message containing the number of members of the team.
// TODO:  2.5Display each team member's information.

// TODO PHASE THREE
// TODO: 3.1 Stop displaying each team member's information.
// TODO: 3.2 Store a value for the bank's difficulty level. Set this value to 100.
// TODO: 3.3 Sum the skill levels of the team. Save that number.
// TODO: 3.4 Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.

// TODO PHASE FOUR
// TODO: 4.1 Create a random number between -10 and 10 for the heist's luck value.
// TODO: 4.2 Add this number to the bank's difficulty level.
// TODO: 4.3 Before displaying the success or failure message, display a report that shows.
// TODO:     4.3.1 The team's combined skill level
// TODO:     4.3.2 The bank's difficulty level

// TODO PHASE FIVE
// TODO: 5.1 Run the scenario multiple times.
// TODO: 5.2 After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
// TODO: 5.3 Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.

// TODO PHASE SIX
// TODO: 6.1 At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// TODO: 6.2 At the end of the program, display a report showing the number of successful runs and the number of failed runs.

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