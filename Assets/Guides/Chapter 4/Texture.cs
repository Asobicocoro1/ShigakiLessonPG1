﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### インポートした画像のインスペクター情報の解説

Unityでは、画像をインポートするとインスペクターウィンドウでさまざまな設定を行うことができます。以下に、インスペクターで設定できる主な情報について説明します。

#### Texture Type (テクスチャタイプ)
- **Default**: 通常のテクスチャとして使用します。3Dモデルのマテリアルなどに適しています。
- **Sprite (2D and UI)**: 2Dスプライトとして使用します。2DゲームやUI要素に適しています。
- **Normal Map**: 法線マップとして使用します。3Dモデルの表面に細かいディテールを追加するために使用します。
- **Editor GUI and Legacy GUI**: UnityエディタのGUIやレガシーGUIシステムで使用するテクスチャです。
- **Cursor**: カーソル画像として使用します。
- **Cookie**: ライトのクッキーテクスチャとして使用します。ライトの投影パターンを定義します。
- **Lightmap**: ライトマップテクスチャとして使用します。シーン全体のライティング情報を保存します。
- **Single Channel**: 単一チャネルのテクスチャとして使用します。

#### Texture Shape (テクスチャシェイプ)
- **2D**: 通常の2Dテクスチャ。
- **Cube**: キューブマップとして使用するテクスチャ。環境マッピングに適しています。
- **2D Array**: 複数の2Dテクスチャを配列として使用します。
- **3D**: 3Dテクスチャとして使用します。

#### sRGB (Color Texture) (sRGB (カラーテクスチャ))
- **有効/無効**: テクスチャがカラー情報を持つ場合は有効にします。法線マップなどのデータテクスチャには無効にします。

#### Alpha Source (アルファソース)
- **None**: アルファチャンネルを無視します。
- **Input Texture Alpha**: 入力テクスチャのアルファチャンネルを使用します。
- **From Gray Scale**: グレースケール値をアルファチャンネルとして使用します。

#### Wrap Mode (ラップモード)
- **Repeat**: テクスチャを繰り返して表示します。
- **Clamp**: テクスチャの端のピクセルを伸ばして表示します。
- **Mirror**: テクスチャを鏡像で繰り返します。
- **Mirror Once**: 一度だけ鏡像で繰り返し、以後はClampと同じように表示します。

#### Filter Mode (フィルターモード)
- **Point (no filter)**: ポイントフィルタリング。最近接ピクセルを選択します。ピクセルアートに適しています。
- **Bilinear**: バイリニアフィルタリング。隣接する4ピクセルを線形補間します。
- **Trilinear**: トリリニアフィルタリング。隣接する8ピクセルを線形補間します。ミップマップを使用する場合に適しています。

#### Aniso Level (異方性フィルタリングレベル)
- 異方性フィルタリングのレベルを設定します。高い値にするほどテクスチャの遠近表示が鮮明になりますが、パフォーマンスに影響を与えます。

#### Max Size (最大サイズ)
- テクスチャの最大サイズを設定します。指定されたサイズにテクスチャをリサイズしてインポートします。

#### Compression (圧縮)
- **None**: 圧縮しません。最高品質ですが、メモリ使用量が多くなります。
- **Low Quality**: 低品質の圧縮。メモリ使用量を減らしますが、画質が低下します。
- **Normal Quality**: 通常品質の圧縮。バランスの取れた画質とメモリ使用量。
- **High Quality**: 高品質の圧縮。画質が良くなりますが、メモリ使用量が増えます。

#### Import Settings (インポート設定)
1. **テクスチャの選択**: プロジェクトウィンドウでインポートした画像ファイルを選択します。
2. **インスペクターウィンドウ**: インスペクターウィンドウが画像の設定を表示します。
3. **設定の変更**: 各設定を変更して、プロジェクトに最適な状態に調整します。
4. **Applyボタン**: 設定を変更したら、インスペクターウィンドウの「Apply」ボタンをクリックして変更を適用します。

このように、インポートした画像の設定をインスペクターウィンドウで適切に調整することで、ゲームのパフォーマンスや見栄えを最適化できます。
 */

public class Texture : MonoBehaviour
{

}
