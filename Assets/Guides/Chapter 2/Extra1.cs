using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*�ԗ��ł��ĂȂ�����������e�ꗗ
 
 1. �_�����Z
�_�����Z�q�́A�^�itrue�j��U�ifalse�j�Ƃ������u�[���l�𑀍삷��ۂɎg�p���܂��B��Ș_�����Z�q�ɂ�&&�iAND�j�A||�iOR�j�A!�iNOT�j������܂��B
bool isSunny = true;
bool isWeekend = false;

if (isSunny && isWeekend) {
    Debug.Log("�����֍s�����I");
} else {
    Debug.Log("�Ƃŉ߂������B");
}

if (!isWeekend) {
    Debug.Log("�����͊w�Z����������B");
}
���̂悤�ɘ_�����Z���g���āA�����̏�����g�ݍ��킹�邱�Ƃ��ł��܂��B
 
 2. �������Z�q�i�O�����Z�q�j
�������Z�q�͏��� ? �^�̎��̒l : �U�̎��̒l�Ƃ����`�Ŏg�p����A�ȒP�ȏ��������1�s�ŋL�q�ł��܂��B
int score = 85;
string result = score >= 60 ? "���i" : "�s���i";
Debug.Log(result);
���̃R�[�h�ł́A�X�R�A��60�ȏ�Ȃ�"���i"�A�����łȂ����"�s���i"�Ƃ������ʂ�result�Ɋi�[���܂��B


3. �z��ƃ��X�g�̍��x�ȑ���
�z��⃊�X�g���g��������ɕ��G�ȑ��������܂��B�Ⴆ�΁A�z��⃊�X�g�̃\�[�g�A�����A�܂��̓t�B���^�����O�Ȃǂł��B
 List<int> numbers = new List<int> { 10, 5, 3, 9, 7 };
numbers.Sort(); // ���X�g�������Ƀ\�[�g

foreach (int number in numbers) {
    Debug.Log(number);
}
���̃R�[�h�ł́A���X�g���̐��l�������ɕ��בւ��Ă��܂��B

 4. �C�x���g�ƃf���Q�[�g�̊�{
�C�x���g�ƃf���Q�[�g���g���āA�v���O�������ŃJ�X�^���̒ʒm�V�X�e����݌v������@���w�Ԃ��Ƃ��ł��܂��B
����ɂ��A����̃A�N�V���������������Ƃ��ɑ��̃R�[�h����������悤�ɐݒ肷�邱�Ƃ��\�ł��B
 public delegate void ActionEvent();
public event ActionEvent OnAction;

void DoSomething() {
    OnAction?.Invoke();
}
���̃R�[�h�ł́A�����A�N�V����������ۂɃC�x���g�𔭉΂����Ă��܂��B

�����̃g�s�b�N��ǉ��Ŋw�Ԃ��ƂŁA�v���O���~���O�̗��������[�߁A���܂��܂Ȗ��ɑΉ��ł���͂�g�ɂ��邱�Ƃ��ł��܂��B
�v���O���~���O�͔��ɍL������Ȃ̂ŁA��{����n�߂ď��X�ɐV�����T�O��������Ă������Ƃ��d�v�ł��B
 
 

1. ��O����
�v���O�������ŃG���[�����������ꍇ�ɁA��������S�ɏ���������@���w�ԁB��O�����́A�G���[���v���O�����̎��s�𒆒f�����Ȃ��悤�ɂ��邽�߂ɏd�v�ł��B

csharp
�R�[�h���R�s�[����
try
{
    // �����ɒʏ�̏���������
    int division = 10 / 0; // �[���Ŋ���Z�����Ă݂�i�G���[�����j
}
catch (DivideByZeroException ex)
{
    Debug.Log("�[���Ŋ��邱�Ƃ͂ł��܂���F" + ex.Message); // �G���[���b�Z�[�W���o��
}
2. �t�@�C�����o��
�f�[�^���t�@�C���ɕۑ�������A�t�@�C������ǂݍ��񂾂肷����@���w�ԁB����ɂ��A�Q�[���̃Z�[�u�f�[�^�Ǘ��Ȃǂ��\�ɂȂ�܂��B

csharp
�R�[�h���R�s�[����
using System.IO;

string path = "path/to/your/file.txt";

// �t�@�C���Ƀe�L�X�g����������
File.WriteAllText(path, "����ɂ��́A���E�I");

// �t�@�C������e�L�X�g��ǂݎ��
string readText = File.ReadAllText(path);
Debug.Log(readText);
3. �����iAttributes�j
�R�[�h�Ƀ��^�f�[�^��ǉ�������@�B�Ⴆ�΁AUnity�ł悭�g����[SerializeField]��[Range]�Ȃǂ�����܂��B����ɂ��A�G�f�B�^���ł̕\���⓮����J�X�^�}�C�Y�ł��܂��B

csharp
�R�[�h���R�s�[����
public class Player : MonoBehaviour
{
    [SerializeField] private int health = 100; // �G�f�B�^�[���璲���\�ɂ���
    [Range(1, 10)]
    public float speed = 5.0f; // �X�s�[�h�͈̔͂�1����10�ɐ�������
}
4. �f���Q�[�g�ƃC�x���g�̉��p
��蕡�G�ȃf���Q�[�g�ƃC�x���g�̎g�������w�сA�����̃C�x���g���X�i�[��A�N�V�������Ǘ�������@�𗝉�����B

csharp
�R�[�h���R�s�[����
public delegate void HealthChanged(int newHealth);
public event HealthChanged onHealthChanged;

void TakeDamage(int damage)
{
    health -= damage;
    onHealthChanged?.Invoke(health);
}
5. �W�F�l���N�X�̎g�p
�^���p�����[�^�Ƃ��Ĉ������Ƃ��ł���W�F�l���N�X���g�p������@���w�ԁB����ɂ��A���ė��p�\�ŏ_��ȃR�[�h��������悤�ɂȂ�܂��B

csharp
�R�[�h���R�s�[����
public class MyList<T>
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public T Get(int index)
    {
        return list[index];
    }
}
�����̃g�s�b�N���w�Ԃ��ƂŁA�v���O���~���O�̗������[�܂�A�����H�I�ō��x�ȃv���O�������쐬����\�͂��g�ɂ��܂��B
 
 
 
 
 
 
 
 
 
 */

public class Extra1 : MonoBehaviour
{
 
}
