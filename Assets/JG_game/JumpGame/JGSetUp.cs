using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JGSetup : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject flagPrefab;
    public GameObject platformPrefab;
    public GameObject backgroundPrefab;

    private GameObject playerInstance;
    private GameObject flagInstance;

    void Start()
    {
        // �w�i�𐶐�
        Instantiate(backgroundPrefab, new Vector3(0, 0, 10), Quaternion.identity);
    }

    public void SetupStage1()
    {
        // �v���C���[�𐶐�
        playerInstance = Instantiate(playerPrefab, new Vector3(-8, -3.5f, 0), Quaternion.identity);

        // �S�[���t���b�O�𐶐�
        flagInstance = Instantiate(flagPrefab, new Vector3(8, -3.5f, 0), Quaternion.identity);

        // �v���b�g�t�H�[���𐶐�
        Instantiate(platformPrefab, new Vector3(0, -4, 0), Quaternion.identity);
    }
}

