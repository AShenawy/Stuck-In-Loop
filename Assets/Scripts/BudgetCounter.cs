using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BudgetCounter : MonoBehaviour
{
    public delegate void BudgetChanged();
    public event BudgetChanged onBudgetChanged;
    public int startBudget;
    public int currentBudget;
    public Text budgetDisplay;
    

    // Start is called before the first frame update
    void Start()
    {
        currentBudget = startBudget;
        budgetDisplay.text = currentBudget.ToString();
    }

    public void AdjustBudget(int cost, bool isUsed)
    {
        if (isUsed)
        {
            currentBudget -= cost;
            UpdateBudgetDisplay();
            onBudgetChanged?.Invoke();
        }
        else
        {
            currentBudget += cost;
            UpdateBudgetDisplay();
            onBudgetChanged?.Invoke();
        }
    }

    void UpdateBudgetDisplay()
    {
        budgetDisplay.text = currentBudget.ToString();
    }
}
