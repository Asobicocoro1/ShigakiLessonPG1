using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 スクリプトの説明
private AudioSource audioSource;:

AudioSourceコンポーネントを保存するための変数です。
public AudioClip carHorn;:

再生する効果音ファイルを設定するための変数です。インスペクターで設定します。
void Start():

ゲームの開始時に一度だけ呼び出されます。ここでAudioSourceコンポーネントを取得します。
public void PlayCarHorn():

効果音を再生するためのメソッドです。PlayOneShotメソッドを使って、効果音を一回再生します。
スクリプトの設定
スクリプトをアタッチ:

効果音を鳴らしたいオブジェクト（例: 車）を選択し、インスペクターウィンドウで「Add Component」をクリックし、「PlaySound」スクリプトを追加します。
効果音ファイルの設定:

インスペクターウィンドウで、Car Hornフィールドにインポートした効果音ファイル（例: car_horn.wav）をドラッグ＆ドロップします。
スクリプトの呼び出し:

効果音を再生したいタイミングでPlayCarHornメソッドを呼び出します。
例えば、ボタンを押した時に効果音を鳴らす場合、ボタンのOnClickイベントにPlayCarHornメソッドを追加します。
まとめ
この手順を行うことで、Unityで効果音を再生する方法を学びます。
AudioSourceコンポーネントを使って効果音を再生し、スクリプトを使って特定のイベントに応じて効果音を鳴らすことができるようになります。
これにより、ゲームに音を追加して、プレイヤーにより豊かな体験を提供することができます。
 */

public class PlaySound : MonoBehaviour
{
    // AudioSourceコンポーネントを保存する変数
    private AudioSource audioSource;

    // 再生する効果音ファイルを設定する変数
    public AudioClip carHorn;

    void Start()
    {
        // AudioSourceコンポーネントを取得
        audioSource = GetComponent<AudioSource>();

        PlayCarHorn();
    }

    // 効果音を再生するメソッド
    public void PlayCarHorn()
    {
        // 効果音を再生
        audioSource.PlayOneShot(carHorn);
    }
}

