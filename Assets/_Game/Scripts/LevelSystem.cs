using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LevelSystem : MonoBehaviour, ISaveable
{
    [SerializeField] private int level = 1;
    [SerializeField] private int xp = 1;
    [SerializeField] private int health = 100;

    public object CaptureState()
    {
        return new SaveData
        {
            level = level,
            xp = xp,
            health = health
        };
    }

    public void RestoreState(object state)
    {
        var saveData = (SaveData)state;
        level = saveData.level;
        xp = saveData.xp;
        health = saveData.health;
    }

    [Serializable]
    public struct SaveData
    {
        public int level;
        public int xp;
        public int health;
    }
}