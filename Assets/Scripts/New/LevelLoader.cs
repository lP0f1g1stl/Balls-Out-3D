using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private PlayerState _playerState;
    [SerializeField] private LevelMenu _levelMenu;

    private void OnEnable()
    {
        _levelMenu.OnLevelInput += LoadLevel;
    }
    private void OnDisable()
    {
        _levelMenu.OnLevelInput -= LoadLevel;
    }
    private void LoadLevel(int levelNumber) 
    {
        _playerState.level = levelNumber;
        _playerState.Save();
        SceneManager.LoadScene(1);
    }
}
