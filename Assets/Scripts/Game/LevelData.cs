using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LevelData")]
public class LevelData : ScriptableObject
{
    [SerializeField] public float ConveyorSpeed;
    [SerializeField] public ChocolateInterval ChcolateIntervals;
    [SerializeField] public ChocolateProbabilities[] ChocolateProbabilityes;

    [Serializable]
    public class ChocolateInterval
    {
        public float IntervalStart;
        public float IntervalEnd;
    }

    [Serializable]
    public class ChocolateProbabilities
    {
        public ChocolateType ChocolateType;
        [Range(0, 100)] public int Probability;
    }

}

