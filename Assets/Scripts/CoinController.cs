using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //回転を開始する角度を設定
        this.transform.Rotate(0f, Random.Range(0f, 360f), 0f);
    }

    // Update is called once per frame
    void Update()
    {

        //回転
        this.transform.Rotate(0f, 3f, 0f);
    }
}
