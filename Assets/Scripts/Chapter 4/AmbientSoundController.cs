using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//このスクリプトは、環境音を再生するためのスクリプトです。


public class AmbientSoundController : MonoBehaviour
{
    public AudioClip ambientClip; // 再生する環境音の音声ファイル
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = ambientClip;
        audioSource.loop = true; // 環境音をループ再生
        audioSource.playOnAwake = true; // ゲーム開始時に再生
        audioSource.volume = 0.5f; // 音量を50%に設定
        audioSource.Play();
    }

    public void AdjustVolume(float volume)
    {
        audioSource.volume = volume;
    }
}

/*AdjustVolumeメソッドを使用して音量を調整する例
 using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AmbientSoundController ambientSoundController; // 環境音コントローラーへの参照
    public Slider volumeSlider; // UIスライダーへの参照

    void Start()
    {
        // スライダーの初期値を環境音コントローラーの音量に設定
        volumeSlider.value = ambientSoundController.GetComponent<AudioSource>().volume;

        // スライダーの値が変更されたときにAdjustVolumeメソッドを呼び出すリスナーを追加
        volumeSlider.onValueChanged.AddListener(delegate { AdjustAmbientVolume(); });
    }

    // スライダーの値に基づいて音量を調整
    void AdjustAmbientVolume()
    {
        float volume = volumeSlider.value; // スライダーの値を取得
        ambientSoundController.AdjustVolume(volume); // 環境音コントローラーの音量を調整
    }
}

 */
