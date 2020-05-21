using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Print my favorite games
/// </summary>
public class PrintFavoriteGames : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string fireEmblem = "Fire Emblem Series";
        string godOfWar = "God of War";
        string theWitcher = "The Witcher III";

        print($"My favorite games are: {fireEmblem} {godOfWar} and {theWitcher}");
    }
}
