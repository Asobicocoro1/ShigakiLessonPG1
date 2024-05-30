using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
�������ł��BAnimator�E�B���h�E�łł��邱�Ƃ��A�����ƏڍׂɁA�킩��₷���������܂��B

### Animator�E�B���h�E�̊�{

Animator�E�B���h�E�́A�Q�[���̃L�����N�^�[��I�u�W�F�N�g�ɃA�j���[�V������ݒ肵�A���䂷�邽�߂̃c�[���ł��B�����ł́AAnimator�E�B���h�E�łł����{�I�Ȃ��Ƃɂ��Đ������܂��B

### 1. Animator�E�B���h�E���J��

1. **Animator�E�B���h�E�̊J����**
   - Unity�̃��j���[����uWindow�i�E�B���h�E�j�v���N���b�N���܂��B
   - �uAnimation�i�A�j���[�V�����j�v��I�сA�uAnimator�i�A�j���[�^�[�j�v���N���b�N���܂��B
   - �����Animator�E�B���h�E���\������܂��B

### 2. Animator�E�B���h�E�̍\��

1. **�p�����[�^�[**
   - �����ɁuParameters�i�p�����[�^�[�j�v�Ƃ����^�u������܂��B�����ɂ̓A�j���[�V�����𐧌䂷�邽�߂̃p�����[�^�[��ǉ��ł��܂��B
   - �p�����[�^�[�ɂ́uBool�i�u�[���j�v�A�uFloat�i�t���[�g�j�v�A�uInt�i�C���g�j�v�A�uTrigger�i�g���K�[�j�v��4��ނ�����܂��B

2. **���C���[**
   - �p�����[�^�[�^�u�̉��ɂ́uLayers�i���C���[�j�v�^�u������܂��B���C���[���g���ƁA�����̃A�j���[�V�������d�˂čĐ����邱�Ƃ��ł��܂��B

3. **�A�j���[�V�����X�e�[�g**
   - �E���̍L���G���A�ɂ́A�A�j���[�V�����X�e�[�g���\������܂��B�����ł́A�A�j���[�V�����̏�Ԃ�J�ځi�g�����W�V�����j��ݒ�ł��܂��B
   - �uAny State�v�́A�ǂ̃A�j���[�V������Ԃ���ł��J�ڂł�����ʂȏ�Ԃł��B
   - �uEntry�v�́A�A�j���[�V�����̊J�n�n�_�������܂��B

### 3. �p�����[�^�[�̒ǉ�

1. **�p�����[�^�[��ǉ�������@**
   - �uParameters�i�p�����[�^�[�j�v�^�u���N���b�N���܂��B
   - �����ɂ���u+�v�{�^�����N���b�N���܂��B
   - �uBool�i�u�[���j�v��I�т܂��B����́Atrue��false��2�̒l�����p�����[�^�[�ł��B
   - �p�����[�^�[�ɁuisWalking�v�Ɩ��O��t���܂��B

### 4. �A�j���[�V�����X�e�[�g�̐ݒ�

1. **�A�j���[�V�����X�e�[�g�̒ǉ�**
   - �C���|�[�g�����A�j���[�V�����N���b�v�i�Ⴆ�΁A�uWalkRight�v�j��Animator�E�B���h�E�̋󂢂Ă��镔���Ƀh���b�O���h���b�v���܂��B
   - ����ŁuWalkRight�v�A�j���[�V�����X�e�[�g���쐬����܂��B

2. **�J�ڂ̍쐬**
   - �uAny State�v���E�N���b�N���A�uMake Transition�i�J�ڂ��쐬�j�v��I�т܂��B
   - �����uWalkRight�v�X�e�[�g�Ƀh���b�O���Đڑ����܂��B
   - �t�����̑J�ڂ����l�ɍ쐬���܂��B���x�́uWalkRight�v����uIdle�i�ҋ@�j�v�X�e�[�g�Ƀh���b�O���Đڑ����܂��B

### 5. �J�ڂ̏�����ݒ�

1. **�J�ڂ̏�����ݒ肷����@**
   - �쐬�����J�ځi���j���N���b�N���܂��B�C���X�y�N�^�[�E�B���h�E�ɑJ�ڂ̐ݒ肪�\������܂��B
   - �uConditions�i�����j�v�Z�N�V�����Łu+�v�{�^�����N���b�N���A�V����������ǉ����܂��B
   - �h���b�v�_�E�����X�g����uisWalking�v��I�����A���̒l��`true`�ɐݒ肵�܂��B
   - ���l�ɁA�t�����̑J�ځi�uWalkRight�v����uIdle�v�j�ɂ�������ݒ肵�܂��B�����́uisWalking�v��`false`�ɐݒ肵�܂��B

### 6. �A�j���[�V�����̊m�F

1. **�A�j���[�V�����̊m�F���@**
   - �v���C���[�I�u�W�F�N�g��I�����AAnimator�E�B���h�E�Őݒ肵���A�j���[�V�������������Đ�����邩�m�F���܂��B
   - Unity�G�f�B�^�[�㕔�̍Đ��{�^�����N���b�N���ăQ�[�����J�n���܂��B
   - �v���C���[�����E�Ɉړ�����ƁA�A�j���[�V�������������Đ�����邩�m�F���܂��B

### �X�N���[���V���b�g�t���̎菇

1. **Animator�E�B���h�E���J��**
   ![Animator Window]
   - ���j���[����uWindow�i�E�B���h�E�j�v>�uAnimation�i�A�j���[�V�����j�v>�uAnimator�i�A�j���[�^�[�j�v��I�т܂��B

2. **�p�����[�^�[�̒ǉ�**
   ![Parameters Tab]
   - Animator�E�B���h�E�̍����ɂ���uParameters�i�p�����[�^�[�j�v�^�u���N���b�N���܂��B
   - �u+�v�{�^�����N���b�N���A�uBool�i�u�[���j�v��I�����܂��B
   - �p�����[�^�[�ɁuisWalking�v�Ƃ������O��t���܂��B

3. **�J�ڂ̍쐬**
   ![Make Transition]
   - �uAny State�v���E�N���b�N���āuMake Transition�v��I�т܂��B
   - �����h���b�O���āuWalkRight�v�ɐڑ����܂��B

4. **�J�ڂ̐ݒ�**
   ![Transition Conditions]
   - �J�ڂ��N���b�N���ăC���X�y�N�^�[�E�B���h�E���J���܂��B
   - �uConditions�i�����j�v�Z�N�V�����Łu+�v�{�^�����N���b�N���ĐV����������ǉ����܂��B
   - �h���b�v�_�E�����X�g����uisWalking�v��I�����A���̒l��`true`�ɐݒ肵�܂��B

����ŁAAnimator�E�B���h�E�̊�{�I�Ȏg�����ƁA�A�j���[�V�����̐ݒ���@���킩��܂��B���₪����΁A�C�y�ɕ����Ă��������ˁI

 ----------------------------------------------------------------------------------------------------------------------------------

�������ł��B�ȉ��ɁA�킩��₷���悤�ɁAAnimation�E�B���h�E�łł��邱�Ƃ��ڍׂɐ������܂��B

### Animation�E�B���h�E�̊�{

Animation�E�B���h�E�́AUnity�ŃA�j���[�V�������쐬�A�ҏW�A�Đ����邽�߂̃c�[���ł��B�����ł́AAnimation�E�B���h�E�łł����{�I�Ȃ��Ƃɂ��Đ������܂��B

### 1. Animation�E�B���h�E���J��

1. **Animation�E�B���h�E�̊J����**
   - Unity�̃��j���[����uWindow�i�E�B���h�E�j�v���N���b�N���܂��B
   - �uAnimation�i�A�j���[�V�����j�v��I�сA�uAnimation�i�A�j���[�V�����j�v���N���b�N���܂��B
   - �����Animation�E�B���h�E���\������܂��B

### 2. Animation�E�B���h�E�̍\��

1. **�^�C�����C��**
   - �����ɕ\�������̂��^�C�����C���ł��B�����ŃA�j���[�V�����̊e�t���[����ҏW���܂��B
   - �^�C�����C���ɂ́A�A�j���[�V�����̍Đ����Ԃ��\������܂��B

2. **�v���p�e�B**
   - �^�C�����C���̍����ɂ́A�A�j���[�V��������I�u�W�F�N�g�̃v���p�e�B���\������܂��B
   - �ʒu�iPosition�j�A��]�iRotation�j�A�X�P�[���iScale�j�Ȃǂ̃v���p�e�B���A�j���[�V�����ł��܂��B

### 3. �V�����A�j���[�V�����N���b�v�̍쐬

1. **�I�u�W�F�N�g��I��**
   - �V�[���E�B���h�E�ŁA�A�j���[�V�������������I�u�W�F�N�g��I�����܂��B�Ⴆ�΁A�v���C���[�̃X�v���C�g�ł��B

2. **�V�����A�j���[�V�����N���b�v���쐬**
   - Animation�E�B���h�E�ŁuCreate�i�쐬�j�v�{�^�����N���b�N���܂��B
   - �V�����A�j���[�V�����N���b�v�ɖ��O��t���܂��B�Ⴆ�΁uWalkRight�v�Ƃ��܂��B
   - �ۑ����I��ŁuSave�i�ۑ��j�v���N���b�N���܂��B

### 4. �A�j���[�V�����̕ҏW

1. **�t���[���ɃX�v���C�g��ǉ�**
   - �C���|�[�g����4���̕��s�摜���v���W�F�N�g�E�B���h�E����Animation�E�B���h�E�Ƀh���b�O���h���b�v���āA�A�j���[�V�����̊e�t���[���ɐݒ肵�܂��B
   - �Ⴆ�΁A0�t���[���ڂ�1���ڂ̃X�v���C�g���A10�t���[���ڂ�2���ڂ̃X�v���C�g��ǉ����܂��B

2. **�A�j���[�V�������Đ�**
   - �^�C�����C���̍Đ��{�^�����N���b�N���āA�A�j���[�V�������Đ����Ċm�F���܂��B
   - �Đ����ɃX�v���C�g���A�����ĕ\������邱�ƂŁA���s�A�j���[�V�������Đ�����܂��B

### 5. �L�[�t���[���̒ǉ�

1. **�L�[�t���[���̒ǉ�**
   - �^�C�����C����ŉE�N���b�N���A�uAdd Keyframe�i�L�[�t���[���̒ǉ��j�v��I�т܂��B
   - �I�u�W�F�N�g�̃v���p�e�B��ύX����ƁA�����I�ɃL�[�t���[�����ǉ�����܂��B

2. **�L�[�t���[���̕ҏW**
   - �^�C�����C����̃L�[�t���[�����h���b�O���Ĉʒu��ύX���܂��B
   - �v���p�e�B�p�l���ŁA�L�[�t���[���̒l�𒼐ڕҏW���邱�Ƃ��ł��܂��B

### 6. �A�j���[�V�����̕ۑ��ƍĐ�

1. **�A�j���[�V�����N���b�v�̕ۑ�**
   - �ҏW������������A�A�j���[�V�����N���b�v��ۑ����܂��B
   - �v���W�F�N�g�E�B���h�E�ɃA�j���[�V�����N���b�v���\������܂��B

2. **�A�j���[�V�����̍Đ�**
   - �V�[���E�B���h�E�ŃI�u�W�F�N�g��I�����AAnimator�E�B���h�E�Őݒ肵���A�j���[�V�������������Đ�����邩�m�F���܂��B
   - Unity�G�f�B�^�[�㕔�̍Đ��{�^�����N���b�N���ăQ�[�����J�n���܂��B
   - �v���C���[�����E�Ɉړ�����ƁA�A�j���[�V�������������Đ�����邩�m�F���܂��B

### �X�N���[���V���b�g�t���̎菇

1. **Animation�E�B���h�E���J��**
   ![Animation Window]
   - ���j���[����uWindow�i�E�B���h�E�j�v>�uAnimation�i�A�j���[�V�����j�v>�uAnimation�i�A�j���[�V�����j�v��I�т܂��B

2. **�V�����A�j���[�V�����N���b�v���쐬**
   ![Create Animation]
   - Animation�E�B���h�E�ŁuCreate�i�쐬�j�v�{�^�����N���b�N���܂��B
   - �V�����A�j���[�V�����N���b�v�ɖ��O��t���ĕۑ����܂��B

3. **�t���[���ɃX�v���C�g��ǉ�**
   ![Add Keyframe]
   - �C���|�[�g�����X�v���C�g���^�C�����C���Ƀh���b�O���h���b�v���܂��B
   - �e�t���[���ɃX�v���C�g��z�u���ăA�j���[�V������ҏW���܂��B

4. **�L�[�t���[���̕ҏW**
   ![Edit Keyframe
   - �^�C�����C����̃L�[�t���[�����h���b�O���Ĉʒu��ύX���܂��B
   - �v���p�e�B�p�l���ŃL�[�t���[���̒l��ҏW���܂��B

����ŁAAnimation�E�B���h�E�̊�{�I�Ȏg�����ƁA�A�j���[�V�����̐ݒ���@���킩��܂��B���₪����΁A�C�y�ɕ����Ă��������ˁI


 */

public class Guide_Anima : MonoBehaviour
{
}
