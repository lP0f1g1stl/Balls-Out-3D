using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLevelsData", menuName = "Level/LevelsData")]
public class LevelData : ScriptableObject
{
    [SerializeField] private BallType[] _ballTypes;

    public BallType[] BallType => _ballTypes;
}
