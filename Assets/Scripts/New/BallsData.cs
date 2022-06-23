using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBallsData", menuName = "Balls/BallsData")]
public class BallsData : ScriptableObject
{
    [SerializeField] private BallTypeData[] _balls;

    public BallTypeData[] Balls => _balls;
}

[System.Serializable]
public struct BallTypeData
{
    [SerializeField] private Ball[] _ball;

    public Ball[] Ball => _ball;
}
