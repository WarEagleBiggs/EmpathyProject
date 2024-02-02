using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public countNumber object_countNumber;
    public AudioSource audioData;

    int playTime;

    int speedControl=600;

    bool StartPlay = false;

    public int count = 0;

    void Start()
    {
        //audioData = GetComponent<AudioSource>();
        playTime = Random.Range(3,10);
        object_countNumber.groundTrue.text = "?";
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StartPlay==true){        
            if(count % speedControl == 0){            
                Debug.Log("Debug sound works");
                playSound();
            }
            stop();
        }

        if(playTime ==0 && StartPlay == false){
            object_countNumber. Invoke("finishEnd", 5);
            Invoke("extrPlayTime",6);
        }
        count++;
    }

    void playSound(){
        
        audioData.Play(0);
        playTime = playTime - 1;
        
    }
    public void stop(){
        if (playTime == 0){
            Debug.Log("Debug sound should be ended!");
            StartPlay = false;
        }
    }
    public void startGame(){
        StartPlay = true;
        object_countNumber.finishBool.text = "Started!";
        
    }
    public void extrPlayTime(){
        object_countNumber.groundTrue.text = playTime.ToString();

    }
    public void reload(){          
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
    }
}
