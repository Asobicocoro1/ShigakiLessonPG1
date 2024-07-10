using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class JGGenericButtonController : MonoBehaviour
{
    public UnityEvent onClick;

    void Start()
    {
        // ボタンの参照を取得し、クリックイベントにリスナーを追加
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (onClick != null)
        {
            onClick.Invoke(); // UnityEventに登録された関数を呼び出し
        }
    }
}
