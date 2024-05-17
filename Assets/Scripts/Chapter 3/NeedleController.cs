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

 まず、angle 変数に代入されている値は、needleTransform オブジェクトの eulerAngles プロパティの z 成分を 360 で割った余りです。

1. eulerAngles プロパティ

eulerAngles プロパティは、3D オブジェクトの回転を表すベクトルです。ベクトルの各成分は、オブジェクトが X 軸、Y 軸、Z 軸 の周りにどれだけ回転したかを表します。

2. z 成分

z 成分は、オブジェクトが Z 軸 の周りにどれだけ回転したかを表します。値は -180° から 180° までの範囲で、正の値は時計回りの回転、負の値は反時計回りの回転を表します。

3. % 360 演算子

% 演算子は、剰余演算子 と呼ばれ、2 つのオペランドの除算の余りを返します。この場合、angle 変数には、needleTransform オブジェクトの eulerAngles プロパティの z 成分を 360 で割った余りが代入されます。
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
