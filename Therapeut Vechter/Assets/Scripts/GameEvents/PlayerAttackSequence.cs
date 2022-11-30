﻿using Exercises;
using FMODUnity;

namespace GameEvents
{
    [System.Serializable]
    public class PlayerAttackSequence
    {
        public EventReference startingVoiceLine;
        public EventReference exerciseName;
        public PoseDataSet playerAttack;
        public int timesToPerform=1;
    }
}