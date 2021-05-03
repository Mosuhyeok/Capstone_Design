﻿using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckLeapmotion : MonoBehaviour
{
    public TextMeshProUGUI notConnected;
    public UnityEngine.UI.Image circle;


    void Update()
    {
        notConnected.gameObject.SetActive(false);

        if (FindObjectOfType<GameManager>().isLeapMotionConnected)
        {
            if (SceneManager.GetActiveScene().name == "Loading")
                GetComponent<LoadSceneAuto>().GameStart();
            else if (SceneManager.GetActiveScene().name == "Loading2")
                GetComponent<LoadSceneAuto>().GameStart2();
            else // Tutorial_02
                GetComponent<LoadSceneAuto>().LoadNextScene();
        }

        else
        {
            notConnected.gameObject.SetActive(true);
            circle.gameObject.SetActive(true);
        }
    }
}