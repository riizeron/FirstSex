using System;
using System.Collections.Generic;
using System.Text;

class Soldier
{   
    public virtual string Attack()
    {
        return "Shoot from gun";
        throw new NotImplementedException();
    }
}

class CoolerSoldier : Soldier
{
    public override string Attack()
    {
        return "Shoot from gun and throw a grenade";
        throw new NotImplementedException();
    }
}

class ManInBlack : Soldier
{
    public virtual string Attack()
    {
        return "Shoot from blaster";
        throw new NotImplementedException();
    }
}

class ManInBlackBoss : ManInBlack
{
    public override string Attack()
    {
        return "Shoot from blaster and call an army of aliens";
        throw new NotImplementedException();
    }
}