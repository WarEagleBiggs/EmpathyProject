using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject tutorials;
    public GameObject about;
    public GameObject conditionChoice;

    [Header("Main Menu Buttons")]
    public Button startButton;
    public Button tutorialButton;
    public Button aboutButton;
    //public Button quitButton; No quit button

    public List<Button> returnButtons;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        startButton.onClick.AddListener(EnableConditionChoice);
        tutorialButton.onClick.AddListener(EnableTutorial);
        aboutButton.onClick.AddListener(EnableAbout);
        //quitButton.onClick.AddListener(QuitGame);

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableMainMenu);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }

    public void HideAll()
    {
        mainMenu.SetActive(false);
        tutorials.SetActive(false);
        about.SetActive(false);
        conditionChoice.SetActive(false);
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
        tutorials.SetActive(false);
        about.SetActive(false);
        conditionChoice.SetActive(false);
    }
    public void EnableTutorial()
    {
        mainMenu.SetActive(false);
        tutorials.SetActive(true);
        about.SetActive(false);
        conditionChoice.SetActive(false);
    }
    public void EnableAbout()
    {
        mainMenu.SetActive(false);
        tutorials.SetActive(false);
        about.SetActive(true);
        conditionChoice.SetActive(false);
    }
    public void EnableConditionChoice()
    {
        mainMenu.SetActive(false);
        tutorials.SetActive(false);
        about.SetActive(false);
        conditionChoice.SetActive(true);
    }
}
