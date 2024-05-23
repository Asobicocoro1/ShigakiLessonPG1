using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//このスクリプトは、効果音を再生するためのスクリプトです。

public class SEController : MonoBehaviour
{
    public AudioClip seClip; // 再生する効果音の音声ファイル
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = seClip;
        audioSource.loop = false; // 効果音はループしない
        audioSource.playOnAwake = false; // 自動再生しない
    }

    public void PlaySE()
    {
        audioSource.PlayOneShot(seClip); // 効果音を一度だけ再生
    }
}


