using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//このスクリプトは、背景音楽を再生、停止、ループするためのスクリプトです。

public class BGMController : MonoBehaviour
{
    public AudioClip bgmClip; // 再生するBGMの音声ファイル
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.loop = true; // BGMをループ再生
        audioSource.playOnAwake = true; // ゲーム開始時に再生
        audioSource.Play(); // 音楽を再生
    }

    public void PlayBGM()
    {
        if (!audioSource.isPlaying) // 音楽が再生されていない場合
        {
            audioSource.Play(); // 音楽を再生
        }
    }

    public void StopBGM()
    {
        if (audioSource.isPlaying) // 音楽が再生されている場合
        {
            audioSource.Stop(); // 音楽を停止
        }
    }

    public void PauseBGM()
    {
        if (audioSource.isPlaying) // 音楽が再生されている場合
        {
            audioSource.Pause(); // 音楽を一時停止
        }
    }

    public void ResumeBGM()
    {
        if (!audioSource.isPlaying) // 音楽が再生されていない場合
        {
            audioSource.UnPause(); // 音楽の一時停止を解除して再生
        }
    }
}
