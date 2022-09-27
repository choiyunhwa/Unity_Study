using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public TextMeshPro timeText;
    public TextMeshPro rocordText;

    private float surviveTime;
    private bool isGameover;

    private void Start()
    {
        surviveTime = 0;
        isGameover = false;

    }

    private void Update()
    {
        if(!isGameover)
        {
            surviveTime += Time.deltaTime;

            timeText.text = "Time :" + (int)surviveTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SimpleScene");
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;

        gameoverText.SetActive(true);
    }
}
