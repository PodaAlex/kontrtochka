using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _headerText;
    [SerializeField] private TMP_InputField _nameInputField;
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;

    private void Start()
    {
        SetBestScore();
    }

    private void SetBestScore()
    {
        var winnerName = UserDatabaseManager.GetWinnerName();
        if (winnerName != string.Empty)
        {
            _headerText.text = $"Best Score: {winnerName} {UserDatabaseManager.GetBestScore()}";
        }
        else
        {
            _headerText.text = "Best Score";
        }
    }

    private void OnEnable()
    {
        _startButton.onClick.AddListener(OnStartButtonPressed);
        _exitButton.onClick.AddListener(OnExitButtonPressed);
        
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveListener(OnStartButtonPressed);
        _exitButton.onClick.RemoveListener(OnExitButtonPressed);
        
    }

    private void OnStartButtonPressed()
    {
        GameManager.Instance.CurrentPlayerName = _nameInputField.text;

        SceneManager.LoadScene("main");
    }

    private void OnExitButtonPressed()
    {
        EditorApplication.ExitPlaymode();
    }
    
    
}