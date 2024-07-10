using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    public UIController uiController; // UIコントローラーの参照

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ゲームクリア！");
            //uiController.GameClear(); // ゲームクリアの処理を呼び出し
        }
    }
}
