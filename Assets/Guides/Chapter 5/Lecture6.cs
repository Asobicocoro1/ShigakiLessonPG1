using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

学習の目的の明確化 (1分)
目的: UnityでのUIの表示と更新方法を学び、ゲーム内の情報をプレイヤーに伝える技術を習得する。
講義 6
内容: UIの表示と更新方法、監督スクリプトの作成方法を説明する。
UIの基本概念とHPゲージの配置: UIはゲーム内の情報をプレイヤーに伝えるためのものです。HPゲージを画面に配置し、プレイヤーのHPを視覚的に表示します。
UIを更新する監督スクリプトの作成: ゲームの状態に応じてUIを更新するスクリプトを作成します。
UIの配置と監督スクリプトの作成
以下のようなスクリプトを作成し、UIの更新機能を実装します：
csharp
コードをコピーする
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider hpSlider; // HPを表示するスライダー

    public void UpdateHP(float newHP)
    {
        hpSlider.value = newHP; // HPゲージを更新
    }
}


内容: UIを配置し、監督スクリプトを作成してHPゲージを更新する。
手順:
シーン内にUIのスライダーを配置します。
スクリプトを作成し、スライダーを更新する機能を追加します。
プレイヤーのスクリプトからHPの変化を監督スクリプトに通知する。
csharp
コードをコピーする
public class PlayerController : MonoBehaviour
{
    public GameManager gameManager; // GameManagerを参照
    public float currentHP = 100f; // プレイヤーの現在のHP

    void TakeDamage(float damage)
    {
        currentHP -= damage; // HPを減らす
        gameManager.UpdateHP(currentHP); // HPゲージを更新
    }
}

**内容


ポイント:
UIの基本概念と配置方法
UIを更新するスクリプトの基本構造と実装手順
 */
public class Lecture6 : MonoBehaviour
{
   
}
