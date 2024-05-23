using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//このスクリプトは、複数の効果音を管理し、異なる効果音を再生するためのスクリプトです。
public class MultiSEController : MonoBehaviour
{
    public AudioClip[] seClips; // 再生する効果音の音声ファイルの配列
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = false; // 効果音はループしない
        audioSource.playOnAwake = false; // 自動再生しない
    }

    //インデックス（index）: 配列やリストの中の要素を特定するための番号。0から始まります。
/*
 条件式の説明
index >= 0: インデックスが0以上であることを確認します。
配列のインデックスは0から始まるため、この条件は範囲の下限をチェックしています。
index < seClips.Length: インデックスが配列の長さ未満であることを確認します。
seClips.Lengthは配列の要素数を返すので、この条件は範囲の上限をチェックしています。
全体の条件式: index >= 0 && index < seClips.Length は、インデックスが配列の範囲内にあるかどうかを確認します。
 */
    public void PlaySE(int index)
    {
        // インデックスが配列の範囲内かどうかを確認する
        if (index >= 0 && index < seClips.Length)
        {
            // インデックスが範囲内の場合、指定された効果音を再生する
            audioSource.PlayOneShot(seClips[index]);
        }
        else
        {
            // インデックスが範囲外の場合、エラーメッセージを表示する
            Debug.LogError("SE index out of range");
        }
    }
}

/*
 // seClips配列が3つの効果音を持っている場合
// seClips = {clip1, clip2, clip3};

PlaySE(0); // 有効なインデックス、clip1を再生
PlaySE(2); // 有効なインデックス、clip3を再生
PlaySE(3); // 無効なインデックス、エラーメッセージが表示される

 */
