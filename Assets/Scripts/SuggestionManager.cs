using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuggestionManager : MonoBehaviour
{
    public GameObject[] speechBubbles;
    public GameObject acceptButton;
    public GameObject passButton;
    
    private CanvasGroup attendantsCanvasGroup;

    private void OnEnable()
    {
        attendantsCanvasGroup = GetComponent<CanvasGroup>();
        attendantsCanvasGroup.blocksRaycasts = true;
        HideSpeechBubbles();
        DisplayChoices(false);
    }

    public void OnSuggestionClicked(GameObject bubble)
    {
        attendantsCanvasGroup.blocksRaycasts = false;

        DisplaySpeechBubble(bubble);
        DisplayChoices(true);
    }

    public void OnSuggestionEnded()
    {
        attendantsCanvasGroup.blocksRaycasts = true;

        HideSpeechBubbles();
        DisplayChoices(false);
    }

    void DisplaySpeechBubble(GameObject bubble)
    {
        for (int i = 0; i < speechBubbles.Length; i++)
        {
            if (speechBubbles[i] == bubble)
            {
                speechBubbles[i].SetActive(true);
            }
        }
    }

    void HideSpeechBubbles()
    {
        foreach (GameObject bubble in speechBubbles)
        {
            bubble.SetActive(false);
        }
    }

    void DisplayChoices(bool value)
    {
        acceptButton.SetActive(value);
        passButton.SetActive(value);
    }
}
