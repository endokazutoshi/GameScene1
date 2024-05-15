// Ground.cs
using UnityEngine;

public class Ground : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private GameObject _wallPrefab;
    [SerializeField] private GameObject _tilePrefab;

    const int _nLengthStart = 1;
    const int _nWidthStart = 1;
    const int _nLengthEnd = 22;
    const int _nWidthEnd = 9;
    const int _nCenter = 11;

    [SerializeField] private int _length;
    [SerializeField] private int _width;
=======
    [SerializeField] private int _length; // �c�̈ړ��ł���}�X
    [SerializeField] private int _width; // ���̈ړ��ł���}�X
    const int _nLengthStart = 1; // �c�̈ړ��ł��Ȃ��}�X�n��
    const int _nLengthEnd = 22; // �c�̈ړ��ł��Ȃ��}�X�I���
    const int _nWidthStart = 1; // ���̈ړ��ł��Ȃ��}�X�n��
    const int _nWidthEnd = 9; // ���̈ړ��ł��Ȃ��}�X�I���
    const int midSpritPanel = 11; // �����̒l

    // �u���b�N�̐���
    [SerializeField] private GameObject _wallPrefab; // ������
    [SerializeField] private GameObject _tilePrefab; // �ړ��ł���}�X

>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
    private void Start()
    {
        for (int width = 0; width < _length; width++) // ���̃}�X�̏o��
        {
            for (int length = 0; length < _width; length++) // �c�̃}�X�̏o��
            {
<<<<<<< HEAD
                if (length >= _nLengthStart && length < _nLengthEnd && width >= _nWidthStart && width < _nWidthEnd) // ���̍��W��0����22�͈̔͂̏ꍇ
=======
                if (length >= _nLengthStart && length < _nLengthEnd && width >= _nWidthStart && width < _nWidthEnd) // �c�̃}�X���P��22�A���̃}�X��1��9�̈��
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
                {
                    Instantiate(_tilePrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // ���̃}�X���쐬
                }
                else // ����ȊO�̏ꍇ
                {
                    GameObject wall = Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // ���̕ǂ��쐬
                    wall.GetComponent<SpriteRenderer>().color = Color.black;
                }

<<<<<<< HEAD
                }
                if (length == _nCenter)
=======
                if (length == midSpritPanel) // �^�񒆂̃}�X�̕���
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
                {
                    GameObject wall = Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // ���̕ǂ��쐬
                    wall.GetComponent<SpriteRenderer>().color = Color.black;
                }
            }
        }
    }

    // �w�肵���ʒu�̃}�X���ړ��\���ǂ����𔻒肷��֐�
    public bool IsTileMoveable(Vector2 position)
    {
        // �ړ��\�ȃ}�X���ǂ����̏����������ɒǉ�
        // �Ⴆ�΁A����̍��W���ړ��s�\�ȏꍇ��false��Ԃ�

        // ���̗�ł́A�ړ���̈ʒu�� (-5, -5) �ȏ� (5, 5) �����͈͓̔��ł���Έړ��\�Ƃ��Ă��܂�
        if (position.x >= -5 && position.x < 5 && position.y >= -5 && position.y < 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}