using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
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

    }

    // Update is called once per frame
    void Update () {
		
	}
}
