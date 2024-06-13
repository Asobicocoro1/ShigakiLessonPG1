using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Unityでメモリの状況を確認するためには、Unityのプロファイラ（Profiler）を使用する方法が最も一般的です。プロファイラは、ゲームのパフォーマンスを分析し、CPUやGPUの使用状況、メモリの使用状況などを詳細に確認することができます。以下に、プロファイラを使用してメモリの状況を確認する手順を説明します。

### Unity Profilerを使用したメモリの確認方法

#### 1. プロファイラを開く
1. Unityエディタの上部メニューから「Window」をクリックします。
2. 「Analysis」メニューの中にある「Profiler」を選択します。

#### 2. メモリの状況を確認する
1. プロファイラウィンドウが開いたら、上部のタブから「Memory」を選択します。
2. 「Simple」「Detailed」「Detailed (GC Alloc)」など、異なる表示モードを選択して、メモリの使用状況を詳細に確認できます。

#### 3. メモリ使用量の詳細を見る
1. プロファイラの「Memory」タブで、以下の情報を確認できます。
   - **Total Used Memory**: ゲーム全体で使用されているメモリの総量。
   - **Reserved Memory**: Unityが予約しているメモリの総量。
   - **Allocated Memory**: 実際に割り当てられたメモリの量。
   - **Mono Heap**: スクリプトによって使用されているメモリ（主にC#コード）。
   - **Gfx Used**: グラフィックス関連のメモリ使用量。

#### 4. メモリリークの確認
1. メモリ使用量が時間とともに増加し続ける場合、メモリリークが発生している可能性があります。
2. プロファイラの「Detailed」モードで、どのオブジェクトがメモリを消費しているかを確認し、不要なメモリ使用がないかチェックします。

#### 5. スクリプトからのメモリ状況の確認
- メモリ使用状況をスクリプトから取得してログに出力することも可能です。以下のスクリプトを使って、メモリ使用状況を確認できます。

```csharp
using UnityEngine;

public class MemoryUsageLogger : MonoBehaviour
{
    void Update()
    {
        // 総メモリ使用量（MB）
        float totalMemory = Profiler.GetTotalAllocatedMemoryLong() / (1024f * 1024f);
        // 使用中のメモリ量（MB）
        float usedMemory = Profiler.GetTotalReservedMemoryLong() / (1024f * 1024f);
        // 空きメモリ量（MB）
        float unusedMemory = Profiler.GetTotalUnusedReservedMemoryLong() / (1024f * 1024f);
        
        // メモリ使用状況をログに出力
        Debug.Log($"Total Memory: {totalMemory} MB, Used Memory: {usedMemory} MB, Unused Memory: {unusedMemory} MB");
    }
}
```

### 用語の解説

#### 1. Profiler（プロファイラ）
- **説明**: Unityのプロファイラは、ゲームのパフォーマンスを分析するツールです。CPU、GPU、メモリの使用状況など、さまざまなパフォーマンス指標をリアルタイムで確認できます。

#### 2. メモリリーク
- **説明**: メモリリークは、使い終わったメモリが解放されずに残ってしまう現象です。これが発生すると、メモリ使用量が時間とともに増加し、ゲームのパフォーマンスが低下します。

#### 3. Allocated Memory（割り当てられたメモリ）
- **説明**: 現在ゲームで使用されているメモリの量です。スクリプトやオブジェクト、テクスチャなど、さまざまなリソースがこのメモリを消費します。

#### 4. Reserved Memory（予約されたメモリ）
- **説明**: Unityがシステムから予約しているメモリの量です。ゲームで実際に使用されているかどうかに関わらず、確保されているメモリです。

#### 5. Mono Heap（モノ ヒープ）
- **説明**: C#スクリプトが使用するメモリ領域です。スクリプトによって生成されるオブジェクトやデータがここに格納されます。

### プロファイラの使い方の流れ

1. **プロファイラを開く**: 「Window」→「Analysis」→「Profiler」を選択してプロファイラウィンドウを開きます。
2. **「Memory」タブを選択**: メモリの使用状況を詳細に確認するために「Memory」タブを選択します。
3. **メモリ使用量を確認**: Total Used Memory、Reserved Memory、Allocated Memory、Mono Heap、Gfx Usedなどのメモリ使用状況を確認します。
4. **メモリリークの確認**: メモリ使用量が増加し続けている場合、メモリリークの可能性をチェックします。
5. **スクリプトによる確認**: `Profiler.GetTotalAllocatedMemoryLong`などのメソッドを使用して、スクリプトからメモリ使用状況を取得し、ログに出力します。

このようにして、Unityのプロファイラを使用してゲームのメモリ状況を確認し、必要に応じてパフォーマンスの最適化を行うことができます。
 */
public class MemoryUsageLogger : MonoBehaviour
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
