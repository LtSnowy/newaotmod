using System;
using UnityEngine;

public class PlayerInfoPHOTON
{
    public string guildname = string.Empty;

    public string name = "Raide";

    public string entry = string.Empty;

    public void initAsGuest()
    {
        this.name = "RAIDE" + UnityEngine.Random.Range(0, 100);
    }
}