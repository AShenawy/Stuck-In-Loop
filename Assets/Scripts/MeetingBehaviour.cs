using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetingBehaviour : MonoBehaviour
{
    public Activities activities;
    public int currentActivity;
    public MeetingStages meetingStage;
    public MeetingDialogue meetingDialogue;

    private void OnEnable()
    {
        currentActivity = 0;
        meetingStage = MeetingStages.Greeting;
        
        AdvanceMeeting(meetingStage);
    }

    private void OnDisable()
    {
        
    }

    private void Start()
    {
        
    }

    void StartMeeting()
    {

    }

    public void AdvanceMeeting(MeetingStages stage)
    {
        switch (stage)
        {
            case MeetingStages.Greeting:
                meetingDialogue.DisplayGreeting();
                break;

            case MeetingStages.Ideation:
                meetingDialogue.DisplayIdeation();
                break;

            case MeetingStages.TargetAudience:
                meetingDialogue.DisplayTarget();
                break;

            case MeetingStages.Story:
                meetingDialogue.DisplayStory();
                break;

            case MeetingStages.Art:
                meetingDialogue.DisplayArt();
                break;

            case MeetingStages.Music:
                meetingDialogue.DisplaySound();
                break;

            case MeetingStages.Conclusion:
                if (GameManager.instance.currentTurn < 3)
                {
                    meetingDialogue.DisplayConclusionNoClient();
                }
                else
                {
                    meetingDialogue.DisplayConclusionWithClient();
                }
                break;
        }
    }
}

public enum MeetingStages {Greeting, Ideation, TargetAudience, Story, Art, Music, Conclusion }
