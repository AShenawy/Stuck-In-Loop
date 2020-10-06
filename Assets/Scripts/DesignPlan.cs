﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DesignPlan : MonoBehaviour, IPointerClickHandler
{
    public MeetingBehaviour meetingBehaviour;
    public Button submitButton;
    public GameObject planView;
    public Idea ideationIdea;
    public Text ideationSumm;
    public Idea targetAudienceIdea;
    public Text targetSumm;
    public Idea storyIdea;
    public Text storySumm;
    public Idea artIdea;
    public Text artSumm;
    public Idea soundIdea;
    public Text soundSumm;

    private void OnEnable()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        submitButton.interactable = false;

        ClearSummaries();
    }

    void ClearSummaries()
    {
        ideationSumm.text = "";
        targetSumm.text = "";
        storySumm.text = "";
        artSumm.text = "";
        soundSumm.text = "";
    }

    public void SaveIdea(Idea idea)
    {
        switch (meetingBehaviour.meetingStage)
        {
            case MeetingStages.Ideation:
                ideationIdea = idea;
                ideationSumm.text = idea.designDocEntry;
                submitButton.GetComponent<SubmitIdea>().nextStage = MeetingStages.TargetAudience;
                submitButton.interactable = true;
                break;

            case MeetingStages.TargetAudience:
                targetAudienceIdea = idea;
                targetSumm.text = idea.designDocEntry;
                submitButton.GetComponent<SubmitIdea>().nextStage = MeetingStages.Story;
                submitButton.interactable = true;
                break;

            case MeetingStages.Story:
                storyIdea = idea;
                storySumm.text = idea.designDocEntry;
                submitButton.GetComponent<SubmitIdea>().nextStage = MeetingStages.Art;
                submitButton.interactable = true;
                break;

            case MeetingStages.Art:
                artIdea = idea;
                artSumm.text = idea.designDocEntry;
                submitButton.GetComponent<SubmitIdea>().nextStage = MeetingStages.Music;
                submitButton.interactable = true;
                break;

            case MeetingStages.Music:
                soundIdea = idea;
                soundSumm.text = idea.designDocEntry;
                submitButton.GetComponent<SubmitIdea>().nextStage = MeetingStages.Conclusion;
                submitButton.interactable = true;
                break;

            default:
                break;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        planView.SetActive(true);
    }
}
