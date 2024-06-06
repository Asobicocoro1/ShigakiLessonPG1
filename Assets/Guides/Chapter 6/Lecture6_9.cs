using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### 講義9: スマートフォン対応の設定（6-11 スマートフォンで動かしてみよう）

#### 学習の目的の明確化 (1分)
**説明**: スマートフォンでの操作に対応する設定を行い、実際にビルドして動作確認をします。これにより、完成したゲームをスマートフォンでプレイできるようにします。

#### 講義 (20分)
**内容**: スマートフォン対応の設定方法（6-11 スマートフォンで動かしてみよう）

##### 6-11-1 スマートフォンの操作に対応させる
- **説明**: スマートフォンでゲームを操作するために、タッチ入力や加速度センサーを使用します。基本的なタッチ入力の実装方法を学びます。

##### タッチ入力の設定
- **手順**:
  1. Projectウィンドウで「Scripts」フォルダを開きます。
  2. 「Scripts」フォルダ内で右クリックし、「Create」→「C# Script」を選択し、スクリプト名を「TouchInputController」にします。
  3. TouchInputControllerスクリプトをダブルクリックして開き、以下のコードを入力します。

```csharp
using UnityEngine;

/// <summary>
/// スマートフォンのタッチ入力を管理するスクリプト
/// </summary>
public class TouchInputController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = touch.deltaPosition;
                rb.velocity = new Vector2(touchDeltaPosition.x * moveSpeed * Time.deltaTime, rb.velocity.y);
            }
        }
    }
}
```

- **手順**:
  1. Hierarchyウィンドウでプレイヤオブジェクトを選択します。
  2. Inspectorウィンドウで「Add Component」をクリックし、「TouchInputController」スクリプトをアタッチします。

##### 6-11-2 iPhoneでビルドする場合
- **手順**:
  1. File → Build Settingsを開きます。
  2. プラットフォームのリストから「iOS」を選択し、「Switch Platform」をクリックします。
  3. Player Settingsをクリックし、以下の設定を行います。
     - Product Name: ゲームの名前を入力します。
     - Company Name: 会社名やデベロッパー名を入力します。
     - Bundle Identifier: 一意の識別子を入力します（例: com.companyname.gamename）。
  4. Build and Runをクリックし、ビルド場所を指定します。
  5. Xcodeが開きますので、必要な設定を行い、iOSデバイスにインストールします。

##### 6-11-3 Androidでビルドする場合
- **手順**:
  1. File → Build Settingsを開きます。
  2. プラットフォームのリストから「Android」を選択し、「Switch Platform」をクリックします。
  3. Player Settingsをクリックし、以下の設定を行います。
     - Product Name: ゲームの名前を入力します。
     - Company Name: 会社名やデベロッパー名を入力します。
     - Package Name: 一意の識別子を入力します（例: com.companyname.gamename）。
  4. Android SDKとNDKのパスを設定します（Preferences → External Toolsから設定）。
  5. Build and Runをクリックし、ビルド場所を指定します。
  6. Androidデバイスにインストールし、動作を確認します。

### Unity上で個人操作 (10分)
- **内容**: スマートフォン用のビルド設定を行う
  - TouchInputControllerスクリプトを作成し、プレイヤにアタッチします。
  - iOSまたはAndroid用にビルド設定を行い、デバイスにインストールします。
  - スマートフォンでゲームが正しく動作するか確認します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにスマートフォン対応の設定を行ったか、ビルドをどのように行ったかを説明し合います。
  - スマートフォンでの操作に関する問題点や解決方法について意見を交換します。

これで、スマートフォン対応の設定とビルド方法を学びました。これにより、完成したゲームをスマートフォンでプレイできるようになりました。
 */

public class Lecture6_9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
