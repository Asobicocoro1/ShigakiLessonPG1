using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    public UIController uiController; // UI�R���g���[���[�̎Q��

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("�Q�[���N���A�I");
            //uiController.GameClear(); // �Q�[���N���A�̏������Ăяo��
        }
    }
}
