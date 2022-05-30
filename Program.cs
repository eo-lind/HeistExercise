using System;
using System.Collections.Generic;

// ----------default variables---------- //
string newMember = "default";
string newMemberSkillLevelString = "";
int newMemberSkillLevel = 0;
string newMemberCourageFactorString = "";
double newMemberCourageFactor = 0.0;
bool keepAddingToTeam = true;
string bankDifficultyLevelString = "";
int bankDifficultyLevel = 0;
int teamSkillLevel = 0;
int luckValue = 0;
int bankDifficultyLevelAdjusted = 0;
int numOfTrials = 0;
int successes = 0;
int failures = 0;
// --------end default variables-------- //

List <TeamMember> fullTeamList = new List<TeamMember>();

Console.WriteLine("Plan Your Heist!");
Console.WriteLine();
Console.WriteLine("Please enter a numerical bank difficulty level.");
bankDifficultyLevelString = Console.ReadLine();
bankDifficultyLevel = int.Parse(bankDifficultyLevelString);

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
        successes += 1;
    }
    else
    {
        Console.WriteLine($"Team Skill Level: {teamSkillLevel}  |  Bank Difficulty Level: {bankDifficultyLevelAdjusted}");
        Console.WriteLine("Your heist failed. You're headed for prison. Vaya con Dios.");
        Console.WriteLine();
        failures += 1;
    }
    // --------------------end team vs bank comparison-------------------- //
}

Console.WriteLine($"SUCCESSES: {successes}  |  FAILURES: {failures}");

// ----------------------------end run trials---------------------------- //

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