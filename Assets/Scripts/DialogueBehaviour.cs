using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class DialogueBehaviour : MonoBehaviour
{
    // make this class a singleton
    //#region Singleton
    //public static DialogueBehaviour instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //        instance = this;
    //}
    //#endregion

    public GameObject continueTextButton;
    public GameObject endScreenButton;

    public delegate void DialogueEnded();
    public event DialogueEnded onDialogueEnded;

    [SerializeField] private TMP_Text textDisplay;
    [SerializeField] private GameObject dialoguePanel;

    private string[] dialoguePieces;
    private int progressionIndex = 0;

    private void Start()
    {
        //dialoguePanel.SetActive(false);
        //ResetButtons();
    }

    public void AdvanceDialogue()
    {
        // moves to the next block of dialogue

        // check which section of the dialogue array it's at
        if (progressionIndex < dialoguePieces.Length)
        {
            textDisplay.text = dialoguePieces[progressionIndex];
            progressionIndex++;
        }
        
        if (progressionIndex >= dialoguePieces.Length)
            EndDialogue();
    }

    public void DisplayDialogue(string[] inDialogues)
    {
        dialoguePieces = inDialogues;   // store incoming dialogue array

        // Display the dialogue box and text

        dialoguePanel.SetActive(true);  // display the dialogue panel
        ResetButtons();
        AdvanceDialogue();      // start going through the dialogue blocks
    }

    public void DisplayDialogue(string inDialogue)
    {

        // Display the dialogue box and text
        if (inDialogue != "")
        {
            dialoguePanel.SetActive(true);  // display the dialogue panel
            dialoguePieces = new[] { inDialogue };
            ResetButtons();
            AdvanceDialogue();
        }
    }

    void EndDialogue()
    {
        // ends the dialogue and hides the dialogue box
        progressionIndex = 0;   // reset the index for the next dialogue interaction
        //Debug.Log("Dialogue has ended. Hiding Dialogue box");
        //dialoguePanel.SetActive(false);
        endScreenButton.SetActive(true);
        continueTextButton.SetActive(false);
        //onDialogueEnded?.Invoke();
    }

    public void ResetButtons()
    {
        continueTextButton.SetActive(true);
        endScreenButton.SetActive(false);
    }
}
