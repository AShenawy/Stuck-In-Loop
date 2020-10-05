using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Screens")]
    public GameObject startScreen;
    public GameObject introScreen;
    public GameObject designBoardScreen;
    public GameObject meetingScreen;
    public GameObject endScreen;

    [Header("Behaviour Control")]
    public BudgetCounter budgeter;
    public DesignBoardBehaviour designBoardBehaviour;

    [Header("Game Turns")]
    public Text turnCounter;
    public int gameTurns;
    [SerializeField] private int currentTurn = 0;


    // Start is called before the first frame update
    void Start()
    {
        GoToStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToStart()
    {
        startScreen.SetActive(true);
        introScreen.SetActive(false);
        designBoardScreen.SetActive(false);
        meetingScreen.SetActive(false);
        endScreen.SetActive(false);

        designBoardBehaviour.ResetToggles();
        budgeter.ResetCounter();
        currentTurn = 0;
    }

    public void GoToIntro()
    {
        startScreen.SetActive(false);
        introScreen.SetActive(true);
        designBoardScreen.SetActive(false);
        meetingScreen.SetActive(false);
        endScreen.SetActive(false);
    }

    public void GoToDesignBoard()
    {
        startScreen.SetActive(false);
        introScreen.SetActive(false);
        designBoardScreen.SetActive(true);
        meetingScreen.SetActive(false);
        endScreen.SetActive(false);
    }

    public void GoToMeeting()
    {
        currentTurn++;
        if (currentTurn > gameTurns)
        {
            GoToEnd();
            return;
        }

        startScreen.SetActive(false);
        introScreen.SetActive(false);
        designBoardScreen.SetActive(false);
        meetingScreen.SetActive(true);
        endScreen.SetActive(false);

        turnCounter.text = currentTurn.ToString("D2");
    }

    public void GoToEnd()
    {
        startScreen.SetActive(false);
        introScreen.SetActive(false);
        designBoardScreen.SetActive(false);
        meetingScreen.SetActive(false);
        endScreen.SetActive(true);
    }
}
