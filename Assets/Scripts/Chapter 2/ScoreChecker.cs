using System.Collections;
using System.Collections.Generic;
using UnityEngine;//Unity�G���W�����񋟂���@�\���g�����߂ɕK�v�ł��B
                  //Unity�̃N���X�⃁�\�b�h��C#�X�N���v�g�Ŏg����悤�ɂ��邽�߂ɁA���̍s���t�@�C���̍ŏ��ɏ����܂��B

/*
 �ڍא���
public class ScoreChecker : MonoBehaviour�F

���̍s�́AScoreChecker�Ƃ����V�����N���X�����Ƃ���ł��BMonoBehaviour���p�����Ă���̂ŁA
Unity�̃Q�[���I�u�W�F�N�g�ɂ��̃X�N���v�g���A�^�b�`���邱�Ƃ��ł��AUnity�̃C�x���g�V�X�e���𗘗p���邱�Ƃ��ł��܂��B

public int score;�F

������score�Ƃ������O�̌��J���ꂽ�����^�̕ϐ����`���Ă��܂��B����ɂ��AUnity�̃G�f�B�^���璼�ڃX�R�A�̒l��ݒ肷�邱�Ƃ��ł��܂��B

void Start()����if���F

Start�֐����ŏ������iif���j���g�p���āA�X�R�A��100�ȏォ�ǂ������`�F�b�N���Ă��܂��B100�_�ȏ�Ȃ�u�������I�v�ƕ\�����A
����ȊO�Ȃ�u�����Ɗ撣�낤�I�v�ƕ\�����܂��B
����ɂ��A�v���C���[�Ƀt�B�[�h�o�b�N��񋟂��邱�Ƃ��ł��܂��B

�ق��̃p�^�[��
1. ���l�̔�r:if (age < 13)
int age = 16;

if (age < 13) {
    Debug.Log("�q��");
} else if (age < 20) {
    Debug.Log("�e�B�[��");
} else {
    Debug.Log("��l");
}

2. ������̔�r:

string password = "secret";

if (password == "secret") {
    Debug.Log("�p�X���[�h���������ł��B");
} else {
    Debug.Log("�p�X���[�h���Ԉ���Ă��܂��B");
}

3. �����̏���
�����̏�����&&�iAND���Z�q�j��||�iOR���Z�q�j�őg�ݍ��킹�Ďg���܂��B
�N�65�Έȏ�ł���A�������o�[�ł���ꍇ�Ɋ�����K�p

int age = 65;
bool isMember = true;

if (age >= 65 && isMember) {
    Debug.Log("�������K�p����܂��I");
}
4. �u�[���l�̃`�F�b�N
�u�[���l�i�^�܂��͋U�j�𒼐ڃ`�F�b�N���܂��B
bool isNight = true;

if (isNight) {
    Debug.Log("���C�g�����܂��B");
} else {
    Debug.Log("���C�g�������܂��B");
}

5. �l�X�g���ꂽ����
�����̒��ɏ��������邱�Ƃ��ł��A��蕡�G�ȃ��W�b�N���쐬���܂��B
�N�18�Έȏ�Őg���ؖ����������Ă���ꍇ�ɂ̂݃A���R�[���̍w���������Ă��܂��B

int age = 20;
bool hasID = true;

if (age >= 18) {
    if (hasID) {
        Debug.Log("�A���R�[�����w���ł��܂��B");
    } else {
        Debug.Log("�g���ؖ����K�v�ł��B");
    }
} else {
    Debug.Log("�w���ł��܂���B");
}


for���̖����̊�,�ȉ���,���傫��,�ȏ�̊ԁ@���g���܂���
�����Ŏ����Ă݂Ă�

 */

public class ScoreChecker : MonoBehaviour
{
    //Unity�̃C���X�y�N�^�[�E�B���h�E���X�N���v�g��ɒl��������if�����m�F���܂��傤�I
    // �X�R�A��ۑ�����ϐ�
    public int score;

    void Start()
    {
        //�� �Q�[���J�n���Ɉ�x�������s�����
        if (score >= 100)
        {
            Debug.Log("�������I");  // �R���\�[���Ɂu�������I�v�ƕ\��
        }
        else
        {
            Debug.Log("�����Ɗ撣�낤�I");  // �R���\�[���Ɂu�����Ɗ撣�낤�I�v�ƕ\��
        }
    }
}

