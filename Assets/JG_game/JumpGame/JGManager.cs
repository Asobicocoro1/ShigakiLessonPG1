using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JGManager : MonoBehaviour
{
    public int currentStage = 1;
    public int totalStages = 3;
    public JGUIController uiController;

    void Start()
    {
        // 初期化処理
    }

    void Update()
    {
        // ステージ進行管理
    }

    public void NextStage()
    {
        if (currentStage < totalStages)
        {
            currentStage++;
            // 次のステージをロード
        }
        else
        {
            uiController.GameClear();
        }
    }

    public void GameOver()
    {
        uiController.GameOver();
    }
}
