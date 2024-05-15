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
    [SerializeField] private int _length; // 縦の移動できるマス
    [SerializeField] private int _width; // 横の移動できるマス
    const int _nLengthStart = 1; // 縦の移動できないマス始め
    const int _nLengthEnd = 22; // 縦の移動できないマス終わり
    const int _nWidthStart = 1; // 横の移動できないマス始め
    const int _nWidthEnd = 9; // 横の移動できないマス終わり
    const int midSpritPanel = 11; // 中央の値

    // ブロックの生成
    [SerializeField] private GameObject _wallPrefab; // 黒い壁
    [SerializeField] private GameObject _tilePrefab; // 移動できるマス

>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
    private void Start()
    {
        for (int width = 0; width < _length; width++) // 横のマスの出現
        {
            for (int length = 0; length < _width; length++) // 縦のマスの出現
            {
<<<<<<< HEAD
                if (length >= _nLengthStart && length < _nLengthEnd && width >= _nWidthStart && width < _nWidthEnd) // 横の座標が0から22の範囲の場合
=======
                if (length >= _nLengthStart && length < _nLengthEnd && width >= _nWidthStart && width < _nWidthEnd) // 縦のマスが１と22、横のマスが1と9の一列
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
                {
                    Instantiate(_tilePrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // 白のマスを作成
                }
                else // それ以外の場合
                {
                    GameObject wall = Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // 黒の壁を作成
                    wall.GetComponent<SpriteRenderer>().color = Color.black;
                }

<<<<<<< HEAD
                }
                if (length == _nCenter)
=======
                if (length == midSpritPanel) // 真ん中のマスの分列
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
                {
                    GameObject wall = Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // 黒の壁を作成
                    wall.GetComponent<SpriteRenderer>().color = Color.black;
                }
            }
        }
    }

    // 指定した位置のマスが移動可能かどうかを判定する関数
    public bool IsTileMoveable(Vector2 position)
    {
        // 移動可能なマスかどうかの条件をここに追加
        // 例えば、特定の座標が移動不可能な場合はfalseを返す

        // この例では、移動先の位置が (-5, -5) 以上 (5, 5) 未満の範囲内であれば移動可能としています
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