using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JGManager : MonoBehaviour
{
    public int currentStage = 1;
    public int totalStages = 3;
    public JGUIController uiController;
    public JGSetup gameSetup;

    void Start()
    {
        // ‰Šú‰»ˆ—
        gameSetup.uiController = uiController;
    }

    public void NextStage()
    {
        if (currentStage < totalStages)
        {
            currentStage++;
            LoadStage(currentStage);
        }
        else
        {
            uiController.GameClear();
            uiController.ShowBackToTitleButton();
        }
    }

    public void LoadStage(int stage)
    {
        gameSetup.SetupStage(stage);
    }

    public void GameOver()
    {
        uiController.GameOver();
    }
}
