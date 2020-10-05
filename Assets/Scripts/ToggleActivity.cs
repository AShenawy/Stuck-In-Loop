using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleActivity : MonoBehaviour
{
    public Activity activity;
    public Text costDisplay;
    public BudgetCounter budgeter;
    public BudgetLock startMeetingButton;
    private Toggle toggle;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate
        {
            ChangeActivity(toggle.isOn);
            budgeter.AdjustBudget(activity.cost, toggle.isOn);
            startMeetingButton.CheckActivities();
        });

        costDisplay.text = $"({activity.cost} €)";
    }

    void ChangeActivity(bool value)
    {
        activity.isHappening = value;
    }
}
