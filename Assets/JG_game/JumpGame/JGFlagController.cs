using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JGFlagController : MonoBehaviour
{
    private JGUIController uiController;

    public void Initialize(JGUIController controller)
    {
        uiController = controller;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ゲームクリア！");
            uiController.GameClear();
        }
    }
}
