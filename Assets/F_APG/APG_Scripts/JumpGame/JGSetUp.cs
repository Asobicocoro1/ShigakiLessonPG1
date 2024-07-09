using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGameSetup : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject flagPrefab;
    public GameObject platformPrefab;
    public GameObject backgroundPrefab;

    void Start()
    {
        // �w�i�𐶐�
        Instantiate(backgroundPrefab, new Vector3(0, 0, 10), Quaternion.identity);

        // �v���C���[�𐶐�
        Instantiate(playerPrefab, new Vector3(-8, -3.5f, 0), Quaternion.identity);

        // �S�[���t���b�O�𐶐�
        Instantiate(flagPrefab, new Vector3(8, -3.5f, 0), Quaternion.identity);

        // �v���b�g�t�H�[���𐶐�
        Instantiate(platformPrefab, new Vector3(0, -4, 0), Quaternion.identity);
    }
}

