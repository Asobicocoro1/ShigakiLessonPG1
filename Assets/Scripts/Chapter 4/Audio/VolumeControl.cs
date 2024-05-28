using System.Collections;
using System.Collections.Generic;
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
