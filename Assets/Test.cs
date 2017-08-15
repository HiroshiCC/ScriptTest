using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;        // マジックパワー
    int mpCost = 5;     // 魔法１回に消費するmp
    int count = 0;      // 魔法トライ回数

    public void Attack()
    {
        // 攻撃用の関数
    }

    public void Defence(int damage)
    {
        // 防御用の関数
    }

    // ***************************************
    //  魔法を使う
    //  戻り値  1:魔法成功   0:魔法失敗
    // ***************************************
    public int Magic()
    {
        count++;
        Debug.Log( count + "回目");

        // 魔法用の関数
        if (mp < mpCost) {
            Debug.Log("MPが足りないため魔法が使えない。");
            return 0;
        }
        else
        {
            mp -= mpCost;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            return 1;
        }
    }

}


public class Test : MonoBehaviour {
    // Use this for initialization
    void Start() {
#if BASIC
        int i;

        // 5個の箱を用意
        int[] Value = new int[5];

        //値をセット
        Value[0] = 10;
        Value[1] = 5;
        Value[2] = 1;
        Value[3] = 3;
        Value[4] = 8;

        // 順番に表示
        Debug.Log("順番に表示");
        for (i = 0; i < Value.Length; i++)
        {
            Debug.Log(Value[i]);
        }

        // 逆順に表示
        Debug.Log("逆順に表示");
        for (i = Value.Length-1; i>=0 ; i--)
        {
            Debug.Log(Value[i]);
        }
#else
        int result = 0; // 魔法結果
        Boss lastBoss = new Boss();

        while (true) { 
            result = lastBoss.Magic();
            if (result == 0)
            {
                // 魔法失敗
                Debug.Log("mpが足りない！");
                break;
            }
        };
#endif

}

    // Update is called once per frame
    void Update () {
		
	}
}
