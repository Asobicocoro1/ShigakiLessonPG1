using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// �^�C���Ƀ^�O��ݒ肷��X�N���v�g
/// </summary>
public class TileTagger : MonoBehaviour
{
    public Tilemap tilemap; // �^�C���}�b�v�̎Q��
    public string tagToSet; // �ݒ肷��^�O

    void Start()
    {
        // �^�C���}�b�v�̑S�Z�����`�F�b�N
        foreach (var pos in tilemap.cellBounds.allPositionsWithin)
        {
            Vector3Int localPlace = new Vector3Int(pos.x, pos.y, pos.z);
            if (!tilemap.HasTile(localPlace)) continue;

            GameObject tileGameObject = new GameObject("TileObject");
            tileGameObject.transform.position = tilemap.CellToWorld(localPlace) + tilemap.tileAnchor;
            tileGameObject.transform.parent = this.transform;
            tileGameObject.tag = tagToSet; // �^�O��ݒ�

            tileGameObject.AddComponent<BoxCollider2D>().isTrigger = true; // �Փ˔���p�̃R���C�_�[��ǉ�
        }
    }
}


