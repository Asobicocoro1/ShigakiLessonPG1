using UnityEngine;
using UnityEngine.UI; // UIコンポーネントを使用するための名前空間をインクルード

/*
 * UIのセットアップ
Unity エディタで、ヒエラルキーに新しい UI Text オブジェクトを追加します。

GameObject -> UI -> Text を選択して、新しいテキストオブジェクトを作成します。
Canvas が自動的に作成されない場合は、GameObject -> UI -> Canvas を選択して先に Canvas を作成してください。
作成した Text オブジェクトを選択し、Inspector でプロパティを調整します。

Text プロパティを "Text Output Here" など初期テキストに設定します。
フォントサイズ、カラー、位置などをゲームデザインに合わせて調整します。
NeedleController スクリプトの更新
スクリプトに UnityEngine.UI をインクルードし、Text コンポーネントへの参照を追加して、実際のテキスト出力を行うように変更します。
 * 

 * 説明
using UnityEngine.UI;：この行で UnityEngine.UI ライブラリをインクルードしており、これにより Text などのUI関連のクラスにアクセスできるようになります。
public RouletteController rouletteController;：これは外部からアタッチする RouletteController スクリプトへの参照です。
                                                ルーレットの動作を制御するために使用します。
public Transform needleTransform;：これはUnityエディタからアサインする針のトランスフォームです。
                                   針の角度を取得するために使います。
public Text outputText;：結果表示用のテキストコンポーネントへの参照。
                         ルーレットの結果をユーザーに通知するためにテキストを更新します。
if (!rouletteController.isSpinning && rouletteController.currentRotationSpeed == 0)
：ルーレットが現在停止しているかどうかを確認する条件です。
  ルーレットが回転しておらず、回転速度も0であれば、内部の処理が実行されます。
float angle = needleTransform.eulerAngles.z % 360;
：針の現在の角度をZ軸に沿って取得し、360で割った余りを使用して0度から360度の範囲で計算します。
  これにより、針がどのセクションを指しているかを判断します。
  このスクリプトは、針がルーレットのどのセクションを指しているかに基づいて異なるアクションを実行し、その結果をゲーム内テキストでプレイヤーに表示します。
  このようなインタラクティブなフィードバックは、ゲームプレイの魅力を高める重要な要素です。
 */


public class NeedleController : MonoBehaviour
{
    public RouletteController rouletteController; // ルーレットのコントロールを管理するスクリプトへの参照
    public Transform needleTransform; // 針のTransformコンポーネントへの参照
    public Text outputText; // 結果を表示するUIテキストへの参照

    void Update()
    {
        // ルーレットが停止しているかどうかをチェック
        //isSpinning,currentRotationSpeedはpublic class RouletteControllerから参照してますよ
        if (!rouletteController.isSpinning && rouletteController.currentRotationSpeed == 0)
        {
            PerformActionOnStop(); // ルーレットが停止したときの処理を呼び出し
        }
    }

    // ルーレットが停止したときに実行されるメソッド
    private void PerformActionOnStop()
    {
        // 針が指している角度を計算（0度から360度）
        float angle = needleTransform.eulerAngles.z % 360;

        // 角度に基づいて異なるアクションを実行し、結果をテキストとして表示
        if (angle < 90)
        {
            outputText.text = "Section 1: Perform some action here.";
        }
        else if (angle < 180)
        {
            outputText.text = "Section 2: Perform another action here.";
        }
        else if (angle < 270)
        {
            outputText.text = "Section 3: Yet another action here.";
        }
        else
        {
            outputText.text = "Section 4: Different action here.";
        }
    }
}
