using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//このスクリプトは、特定のアクション（例: ボタンを押したとき）で効果音を再生するためのスクリプトです。

public class ActionSEController : MonoBehaviour
{
    public AudioClip buttonClickClip; // ボタンをクリックしたときの効果音
    private AudioSource audioSource;
    public Button targetButton; // 効果音を再生する対象のボタン

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = buttonClickClip;
        audioSource.loop = false; // 効果音はループしない
        audioSource.playOnAwake = false; // 自動再生しない

        if (targetButton != null)//!=（Not Equal）は、プログラミングで「等しくない」を意味する比較演算子
        {
            targetButton.onClick.AddListener(PlayButtonClickSE); // ボタンがクリックされたときにPlayButtonClickSEを実行
        }
    }

    void PlayButtonClickSE()
    {
        audioSource.PlayOneShot(buttonClickClip); // 効果音を一度だけ再生
    }
}


