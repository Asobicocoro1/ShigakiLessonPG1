using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 用語の解説
1. Transform（トランスフォーム）
説明: Transformは、ゲームオブジェクトの位置（Position）、回転（Rotation）、スケール（Scale）を表す情報です。プレイヤーのTransformを参照することで、プレイヤーの位置を取得することができます。
2. Vector3（ベクトル3）
説明: Vector3は、3次元空間での位置や方向を表すためのデータ型です。x、y、zの3つの値を持ちます。例えば、Vector3(1, 2, 3)はxが1、yが2、zが3の位置を表します。
3. オフセット
説明: オフセットは、ある基準点からの距離や位置のずれを表します。このスクリプトでは、カメラの位置とプレイヤーの位置の差（ずれ）をオフセットとして使っています。
4. Startメソッド
説明: Startメソッドは、ゲームが始まったときに一度だけ呼ばれるメソッドです。ここで、カメラとプレイヤーの初期位置のオフセットを計算しています。
5. LateUpdateメソッド
説明: LateUpdateメソッドは、毎フレームの最後に呼ばれるメソッドです。通常のUpdateメソッドの後に実行されるため、プレイヤーの動きが反映された後にカメラの位置を更新するのに適しています。
スクリプトの流れの説明
Startメソッド:

ゲームが開始されたときに一度だけ呼ばれます。
プレイヤーとカメラの初期位置の差（オフセット）を計算して保存します。
LateUpdateメソッド:

毎フレームの最後に呼ばれます。
プレイヤーの現在の位置にオフセットを加えて、カメラの新しい位置を計算し、カメラをその位置に移動させます。
このようにして、カメラは常にプレイヤーの動きに追従し、一定の位置関係を保つようになります。
 */


/// <summary>
/// プレイヤーに追従するカメラを制御するスクリプト
/// </summary>
public class CameraController : MonoBehaviour
{
    // プレイヤーのTransform（位置、回転、スケールの情報）への参照
    public Transform player;

    // カメラとプレイヤーの位置の差（オフセット）
    private Vector3 offset;

    /// <summary>
    /// 初期設定を行うメソッド
    /// ゲーム開始時に一度だけ呼ばれます。
    /// </summary>
    void Start()
    {
        // プレイヤーとカメラの初期位置の差（オフセット）を計算
        offset = transform.position - player.position;
    }

    /// <summary>
    /// 毎フレームの最後に呼ばれるメソッド
    /// カメラの位置を更新するために使います。
    /// </summary>
    void LateUpdate()
    {
        // プレイヤーの現在の位置にオフセットを加えてカメラの位置を更新
        transform.position = player.position + offset;
    }
}

