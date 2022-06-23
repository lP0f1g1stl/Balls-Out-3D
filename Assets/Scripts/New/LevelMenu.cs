using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] private InputField _inputField;
    [Header("Buttons")]
    [SerializeField] private Button _accept;
    [SerializeField] private Button _close;

    public Action<int> OnLevelInput;

    private void OnEnable()
    {
        _accept.onClick.AddListener(Accept);
        _close.onClick.AddListener(Close);
    }
    private void OnDisable()
    {
        _accept.onClick.RemoveListener(Accept);
        _close.onClick.RemoveListener(Close);
    }
    private void Accept() 
    {
        OnLevelInput?.Invoke(int.Parse(_inputField.text));
    }
    private void Close() 
    {
        gameObject.SetActive(false);
    }
}
