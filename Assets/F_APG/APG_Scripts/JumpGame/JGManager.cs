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
        // ����������
    }

    void Update()
    {
        // �X�e�[�W�i�s�Ǘ�
    }

    public void NextStage()
    {
        if (currentStage < totalStages)
        {
            currentStage++;
            // ���̃X�e�[�W�����[�h
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
