using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. Unityプロジェクトの新規作成
まず、Unity Hubを開き、「新規プロジェクト」を選択します。プロジェクトのテンプレートとして「3D」または「2D」を選択し、プロジェクト名と保存場所を指定してプロジェクトを作成します。

2. ビルドプラットフォームの設定
ビルド設定の開始:
Unityエディターで「File」メニューから「Build Settings」を開きます。
プラットフォームの選択:
「iOS」または「Android」を選択し、「Switch Platform」ボタンをクリックしてプラットフォームを変更します。
これにより、Unityは選択したプラットフォーム向けにプロジェクトを再設定します。

3. プラットフォーム固有の設定
Android向け設定:
JDK、SDK、NDKの設定: UnityでAndroid開発を行うには、Java Development Kit (JDK)、Android SDK、およびNative Development Kit (NDK)の設定が必要です。Unity Hubの「Installs」セクションからこれらのコンポーネントをインストールし、正しく設定しておく必要があります。
ビルド設定: APKのビルドオプションやキーストアを設定してアプリケーションの署名を行います。
iOS向け設定:
Xcodeの準備: iOS向けのビルドを作成するには、MacにXcodeがインストールされている必要があります。また、Apple Developerアカウントとプロビジョニングプロファイルの設定が必要です。
ビルドオプション: UnityからXcodeプロジェクトを生成し、Xcodeを使ってアプリケーションをビルドおよび署名します。

4. パフォーマンス最適化
解像度とアスペクト比の管理:
「Player Settings」にアクセスし、「Resolution and Presentation」セクションで、デバイスに合わせた解像度とアスペクト比を設定します。
グラフィックス設定の最適化:
低解像度のテクスチャ、シンプルなシェーダーを使用し、動的なライティングを制限することで、パフォーマンスを向上させることができます。

「Player Settings」場所
Unityエディタを開く:

Unityプロジェクトを開いている状態でUnityエディタが利用できます。
Player Settingsにアクセスする:

Unityエディタの上部にあるメニューバーから「Edit」をクリックします。
ドロップダウンメニューから「Project Settings」を選択します。
Project Settingsウィンドウが開く:

左側のカテゴリ一覧から「Player」を選択します。
「Player」セクション内に複数のタブがあり、「Resolution and Presentation」はその中の一つです。
Resolution and Presentationセクション:

このセクションでは、ゲームウィンドウの解像度、フルスクリーンモードのオプション、アスペクト比など、画面表示に関する設定を行います。
ここで、特にモバイルデバイス向けにスクリーンの向き（横持ちや縦持ち）、解像度のスケーリングなどを調整できます。


特にモバイルデバイス向けにスクリーンの向き（横持ちや縦持ち）、解像度のスケーリングの一例

スクリーンの向き（横持ち）の設定
Unityエディタを開き、「Edit」メニューから「Project Settings」を選択します。
プロジェクト設定ウィンドウが開いたら、左側から「Player」を選択します。
「Player」設定で、Androidアイコンをクリックし、プラットフォーム固有の設定にアクセスします。
「Resolution and Presentation」セクションを探し、「Default Orientation」のドロップダウンメニューから「Landscape Left」または「Landscape Right」を選択します。
「Landscape Left」は、デバイスのホームボタンが左側に来るように画面が横向きになります。
「Landscape Right」は、デバイスのホームボタンが右側に来るように画面が横向きになります。
解像度のスケーリング
引き続き「Resolution and Presentation」セクション内で、「Resolution Scaling Mode」を見つけます。
「Resolution Scaling Mode」のオプションから「FixedDPI」を選択します。
「FixedDPI」を選択すると、異なる画面解像度のデバイスでも一定のDPI（ドット・パー・インチ）を保ちながらコンテンツをスケーリングできます。これにより、異なるデバイスで一貫した視覚的体験を提供できます。
下部にある「Fixed DPI Factor」を設定します。
この値は、ターゲット解像度に対するスケーリング比率を示します。例えば、「1」は100%のスケーリングを意味し、「0.5」は50%にスケールダウンされることを意味します。
この設定により、Unityプロジェクトがモバイルデバイスで正確な向きと解像度で実行されるようになり、デバイスの多様性に対応しつつ、ゲームのグラフィックスが最適に表示されるようになります。

縦横向きの設定方法

スクリーンの向き（縦持ち）の設定方法
Unityエディタを開き、「Edit」メニューから「Project Settings」を選択します。
プロジェクト設定ウィンドウが開いたら、左側から「Player」を選択します。
「Player」設定で、プラットフォーム固有のタブ（例えば、AndroidやiOSアイコン）をクリックし、そのプラットフォームに特有の設定にアクセスします。
「Resolution and Presentation」セクションを探し、「Default Orientation」のドロップダウンメニューを見つけます。
「Default Orientation」のオプションから「Portrait」を選択します。
「Portrait」を選択することで、アプリケーションが常に縦向き（デバイスのホームボタンが下になるように）で表示されるように設定されます。
解像度のスケーリング（縦向き対応）
解像度のスケーリングも重要です。縦向きに設定した後は、特にスマートフォンで異なるアスペクト比を持つデバイス間で一貫した表示を実現するために、解像度のスケーリングを適切に設定する必要があります。

引き続き「Resolution and Presentation」セクション内で、「Resolution Scaling Mode」を見つけます。
「Resolution Scaling Mode」で、「FixedDPI」または「Scale With Screen Size」を選択します。
「Scale With Screen Size」を選ぶと、Unityが自動的にスクリーンサイズに合わせてUIとグラフィックスをスケーリングします。これは特に多様なデバイスをサポートするアプリケーションに適しています。
「Scale With Screen Size」を選択した場合は、さらに「Match」オプション（Width, Height, or Expand）を調整して、どの寸法に合わせてスケーリングするかを決定します。
「Match Width or Height」のスライダーを調整して、幅と高さのどちらにより重きを置くかを決めます（0は幅、1は高さ）。


ターゲットのスマホ画面設定は調べましょう


5. テストとデバッグ
Unityエディター内のシミュレーター:
Unityエディターには、異なるデバイスのスクリーンサイズを模倣するシミュレーターがあります。
実デバイスでのテスト:
実際のデバイスでアプリケーションをテストすることが非常に重要です。これにより、異なるデバイスでのパフォーマンスやユーザーインターフェースのレイアウトを確認できます。
 */


public class SetForSmartphone : MonoBehaviour
{

}
