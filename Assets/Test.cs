using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int hp = 100;         //体力
    private int power = 25;       //攻撃力
    private int mp = 53;          //魔法力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    
    }

    //魔法用の関数

    public void Magic(int mpuse)
    {
        
        if (this.mp >= mpuse)
        {
            //残りmpを減らす
            this.mp -= mpuse;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        
    }





}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        // 配列を初期化する
        int[] array = { 10, 20, 30, 40, 50 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            // 配列の要素を順番に表示する
            Debug.Log(array[i]);
        }

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = array.Length - 1; i >= 0; i--)
        {
            // 配列の要素を逆順に表示する
            Debug.Log(array[i]);
        }

        //発展課題
        Boss Xboss = new Boss();
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
