using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Level",menuName ="GameLevelDesign")]
public class LevelManager : ScriptableObject
{
    [SerializeField] private string levelName;
    [SerializeField] private int levelLevel;
}
