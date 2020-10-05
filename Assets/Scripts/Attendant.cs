using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attendant : MonoBehaviour
{
    public AttendantType type;
    public int cost;
    public bool isAttending;
    public Image art;

    public void HideAttendee()
    {
        art.enabled = false;
    }

    public void ShowAttendee()
    {
        art.enabled = true;
    }
}

public enum AttendantType { TeamMember, Expert, EndUser1, EndUser2, Subcontractor, Client}
