using System;

public class Bank
{
    //constructor for properties
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }
    public bool IsSecure { get; }

    // constructor for new Bank object
    public Bank(int cash, int alarm, int vault, int securityGuard)
    {
        CashOnHand = cash;
        AlarmScore = alarm;
        VaultScore = vault;
        SecurityGuardScore = securityGuard;
        // FIXME:IsSecure = if (CashOnHand <=0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <=0){
        //     return false;
        // } else {
        //     return true;
        }
}