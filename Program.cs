using System;
using System.Collections.Generic;

//! static void Main(string[] args)
// {
// }

// ----------default variables---------- //
string newMember = "default";
string newMemberSkillLevelString = "";
int newMemberSkillLevel = 0;
string newMemberCourageFactorString = "";
double newMemberCourageFactor = 0.0;
bool keepAddingToTeam = true;
int bankDifficultyLevel = 100;
int teamSkillLevel = 0;
int luckValue = new Random().Next(-10, 10);
int bankDifficultyLevelAdjusted = bankDifficultyLevel + luckValue;
// --------end default variables-------- //

List <TeamMember> fullTeamList = new List<TeamMember>();

Console.WriteLine("Plan Your Heist!");

// ------------------build team------------------ //
while (keepAddingToTeam == true)
{ 
    Console.WriteLine("Please provide the name of one of your team members.");
    newMember = Console.ReadLine();

    if (newMember == "" || newMember == " ")
    {
        keepAddingToTeam = false;
    }
    else
    {
    Console.WriteLine($"Please enter a numerical skill level for {newMember}.");
    newMemberSkillLevelString = Console.ReadLine();
    newMemberSkillLevel = int.Parse(newMemberSkillLevelString);
    Console.WriteLine($"Please enter a courage factor between 0.0 and 2.0 for {newMember}.)");newMemberCourageFactorString = Console.ReadLine();
    newMemberCourageFactor = Double.Parse(newMemberCourageFactorString);

    TeamMember accomplice = new TeamMember(newMember, newMemberSkillLevel, newMemberCourageFactor);
    fullTeamList.Add(accomplice);
    }
}

if (fullTeamList.Count() == 1)
{
    Console.WriteLine($"Your team has {fullTeamList.Count()} member.");
}
else
{
 
    Console.WriteLine($"Your team has {fullTeamList.Count()} members.");
}
foreach (TeamMember singleTeamMember in fullTeamList)
{
    teamSkillLevel += singleTeamMember.SkillLevel;
    
}

Console.WriteLine($"Your team's collective skill level: {teamSkillLevel}S");
// ----------------------------end build team---------------------------- //

// ----------------------team vs bank comparison---------------------- //
if (teamSkillLevel >= bankDifficultyLevelAdjusted)
{
    Console.WriteLine("Congratulations, Ex-Presidents! You pulled it off!");
}
else
{
    Console.WriteLine("Your heist failed. You're headed for prison. Vaya con Dios.");
}

// --------------------end team vs bank comparison-------------------- //



// TODO: NOTE: the courage factor will be a decimal between 0.0 and 2.0 (will probably need a conditional to handle input outside of that range).

// TODO PHASE FOURS
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




// -------------------------------------team------------------------------------------- //
// public class AllTeamMembers
// {
//     // dictionary:
//     public Dictionary<string, TeamMember> TeamList = new Dictionary<string, TeamMember>();

//     // method:
//     public void AddTeamMember(TeamMember individualTeamMember)
//     {
//         TeamList.Add(individualTeamMember.Name);
//     }


// }
// -----------------------------------end team----------------------------------------- //
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