using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject designBoardScreen;
    public GameObject meetingScreen;
    public GameObject endScreen;

    


    // Start is called before the first frame update
    void Start()
    {
        startScreen.SetActive(true);
        designBoardScreen.SetActive(false);
        meetingScreen.SetActive(false);
        endScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToDesignBoard()
    {
        startScreen.SetActive(false);
        designBoardScreen.SetActive(true);
        meetingScreen.SetActive(false);
        endScreen.SetActive(false);
    }

    public void GoToMeeting()
    {
        startScreen.SetActive(false);
        designBoardScreen.SetActive(false);
        meetingScreen.SetActive(true);
        endScreen.SetActive(false);
    }
}
