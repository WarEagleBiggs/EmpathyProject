using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject tutorials;
    public GameObject about;
    public GameObject conditionChoice;

    [Header("Main Menu Buttons")]
    public Button conditionChoiceButton;
    public Button tutorialButton;
    public Button aboutButton;
    //public Button quitButton; No quit button

    [Header("Get Started Buttons")]
    public TMP_Dropdown conditionDropdown;
    public Button startButton;

    public List<Button> returnButtons;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        conditionChoiceButton.onClick.AddListener(EnableConditionChoice);
        tutorialButton.onClick.AddListener(EnableTutorial);
        aboutButton.onClick.AddListener(EnableAbout);
        //quitButton.onClick.AddListener(QuitGame);
        startButton.onClick.AddListener(StartGame);

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
        switch (conditionDropdown.value)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                SceneTransitionManager.singleton.GoToSceneAsync(1);
                break;
            default:
                break;
        }
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
