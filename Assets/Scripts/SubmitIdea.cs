using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitIdea : MonoBehaviour
{
    public MeetingBehaviour meetingBehaviour;
    public MeetingStages nextStage;

    public void SubmitAndAdvance()
    {
        meetingBehaviour.AdvanceMeeting(nextStage);
    }
}
