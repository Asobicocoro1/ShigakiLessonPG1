using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// タイルにタグを設定するスクリプト
/// </summary>
public class TileTagger : MonoBehaviour
{
    public Tilemap tilemap; // タイルマップの参照
    public string tagToSet; // 設定するタグ

    void Start()
    {
        // タイルマップの全セルをチェック
        foreach (var pos in tilemap.cellBounds.allPositionsWithin)
        {
            Vector3Int localPlace = new Vector3Int(pos.x, pos.y, pos.z);
            if (!tilemap.HasTile(localPlace)) continue;

            GameObject tileGameObject = new GameObject("TileObject");
            tileGameObject.transform.position = tilemap.CellToWorld(localPlace) + tilemap.tileAnchor;
            tileGameObject.transform.parent = this.transform;
            tileGameObject.tag = tagToSet; // タグを設定

            tileGameObject.AddComponent<BoxCollider2D>().isTrigger = true; // 衝突判定用のコライダーを追加
        }
    }
}


