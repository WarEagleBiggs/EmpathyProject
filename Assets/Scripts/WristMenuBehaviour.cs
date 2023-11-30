using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WristMenuBehaviour : MonoBehaviour
{
    [Header("Menu Buttons")]
    public Button playPauseButton;
    public Button homeButton;
    public Button doneButton;

    [Header("Timer")]
    public TMP_Text timerText;

    //other vars
    private bool isPlaying = false;
    private TMP_Text playPauseText;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        playPauseText = playPauseButton.GetComponentInChildren<TMP_Text>(true);
        playPauseButton.onClick.AddListener(playPause);
        homeButton.onClick.AddListener(goHome);
        doneButton.onClick.AddListener(nextScene);
    }

    void Update()
    {
        if (isPlaying)
        {
            timer += Time.deltaTime;
            timerText.text = "Time Elapsed: " + timer.ToString("N1");
        }
    }

    public void playPause()
    {
        if(!isPlaying)
        {
            isPlaying = true;
            playPauseText.text = "Pause";
        }
        else
        {
            isPlaying = false;
            playPauseText.text = "Resume";
        }
    }

    public void goHome()
    {
        //go to scene 0
    }

    public void nextScene() 
    {
        //go to scene +=1
    }
}
