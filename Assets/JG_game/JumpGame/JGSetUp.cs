using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JGSetup : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject stage1Prefab;
    public GameObject stage2Prefab;
    public GameObject stage3Prefab;
    public JGUIController uiController;

    private GameObject playerInstance;
    private GameObject stageInstance;

    public void SetupStage(int stageNumber)
    {
        Cleanup();

        // プレイヤーを生成
        playerInstance = Instantiate(playerPrefab, new Vector3(-8, -3.5f, 0), Quaternion.identity);

        // ステージを生成
        switch (stageNumber)
        {
            case 1:
                stageInstance = Instantiate(stage1Prefab);
                break;
            case 2:
                stageInstance = Instantiate(stage2Prefab);
                break;
            case 3:
                stageInstance = Instantiate(stage3Prefab);
                break;
            default:
                Debug.LogError("Invalid stage number: " + stageNumber);
                break;
        }

        // UIControllerの初期化
        InitializeFlag(stageInstance);
    }

    private void Cleanup()
    {
        if (playerInstance != null)
        {
            Destroy(playerInstance);
        }
        if (stageInstance != null)
        {
            Destroy(stageInstance);
        }
    }

    private void InitializeFlag(GameObject stage)
    {
        var flagController = stage.GetComponentInChildren<JGFlagController>();
        if (flagController == null)
        {
            //Debug.LogError("JGFlagController is not attached to the flagInstance!");
            return;
        }
        flagController.Initialize(uiController);
    }
}



