using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class SuggestionAction : MonoBehaviour, IPointerClickHandler
{
    public SuggestionManager suggestionManager;
    public GameObject speechBubble;
    public TMP_Text speechTextDisplay;

    public void OnPointerClick(PointerEventData eventData)
    {
        suggestionManager.OnSuggestionClicked(speechBubble);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
