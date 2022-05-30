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
int luckValue = 0;
int bankDifficultyLevelAdjusted = 0;
int numOfTrials = 0;
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
    Console.WriteLine($"Please enter a courage factor between 0.0 and 2.0 for {newMember}.)");
    newMemberCourageFactorString = Console.ReadLine();
    newMemberCourageFactor = Double.Parse(newMemberCourageFactorString);

    TeamMember accomplice = new TeamMember(newMember, newMemberSkillLevel, newMemberCourageFactor);
    fullTeamList.Add(accomplice);
    }
}

if (fullTeamList.Count() == 1)
{
    Console.WriteLine($"Your team has {fullTeamList.Count()} member.");
    Console.WriteLine("How many trial runs of the heist would you like to perform?");
    numOfTrials = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
else
{
 
    Console.WriteLine($"Your team has {fullTeamList.Count()} members.");
    Console.WriteLine("How many trial runs of the heist would you like to perform?");
    numOfTrials = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
foreach (TeamMember singleTeamMember in fullTeamList)
{
    teamSkillLevel += singleTeamMember.SkillLevel;
    
}
// ----------------------------end build team---------------------------- //

// ------------------------------run trials------------------------------ //

for (int i = 0; i < numOfTrials; i++)
{
    luckValue = new Random().Next(-10, 10);
    bankDifficultyLevelAdjusted = bankDifficultyLevel + luckValue;
    // ----------------------team vs bank comparison---------------------- //
    if (teamSkillLevel >= bankDifficultyLevelAdjusted)
    {
        Console.WriteLine($"Team Skill Level: {teamSkillLevel}  |  Bank Difficulty Level: {bankDifficultyLevelAdjusted}");
        Console.WriteLine("Congratulations, Ex-Presidents! You pulled it off!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Team Skill Level: {teamSkillLevel}  |  Bank Difficulty Level: {bankDifficultyLevelAdjusted}");
        Console.WriteLine("Your heist failed. You're headed for prison. Vaya con Dios.");
        Console.WriteLine();
    }

    // --------------------end team vs bank comparison-------------------- //
}

// ----------------------------end run trials---------------------------- //





// TODO: NOTE: the courage factor will be a decimal between 0.0 and 2.0 (will probably need a conditional to handle input outside of that range).

// TODO: handle exceptions


// TODO PHASE SIX
// TODO: 6.1 At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// TODO: 6.2 At the end of the program, display a report showing the number of successful runs and the number of failed runs.



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