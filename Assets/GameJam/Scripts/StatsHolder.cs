using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsHolder : MonoBehaviour
{
    public Stats holderStats = new Stats();

    public void Sum(Stats sumSource)
    {
        holderStats.Funny += sumSource.Funny;
        holderStats.Brainrot += sumSource.Brainrot;
        holderStats.CuteCat += sumSource.CuteCat;
        holderStats.VideoAmount += sumSource.VideoAmount;
    }
}
