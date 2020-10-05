using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attendants : MonoBehaviour
{
    public Attendant[] attendants;

    private void OnEnable()
    {
        CheckAttendants();
    }

    private void Awake()
    {
        //CheckAttendants();
    }

    void CheckAttendants()
    {
        for (int i = 0; i < attendants.Length; i++)
        {
            if (!attendants[i].isAttending)
            {
                attendants[i].HideAttendee();
                attendants[i].enabled = false;
            }
            else
            {
                attendants[i].enabled = true;
                attendants[i].ShowAttendee();
            }
        }
    }
}
