using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gm : MonoBehaviour
{

    public static int coinTotal;
    public static float timeTotal;
    public Transform basicPlatform;
    public Transform barrel;
    public Transform coin;
    public Transform crate;
    public int obsPos = -24;
    public float xScenePos = -24;
    public float time;

    // Use this for initialization
    void Start()
    {
        coinTotal = 0;
        timeTotal = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        float positionCoin = Random.Range(-14.0f, -10.0f);
        float positionObstacle = Random.Range(-14.0f, -10.0f);
        int choseObs = Random.Range(0, 101);
        timeTotal += Time.deltaTime;
        GameObject platform = ObjectPooler.SharedInstance.GetPooledObject("emptyP");
        GameObject barrel = ObjectPooler.SharedInstance.GetPooledObject("barrel");
        GameObject coin = ObjectPooler.SharedInstance.GetPooledObject("Coin");
        GameObject crate = ObjectPooler.SharedInstance.GetPooledObject("crate");
        if (platform != null )
        {
            platform.transform.position = new Vector3(xScenePos, 0.5f, -15);
            xScenePos += 4;
            platform.SetActive(true);
            if (barrel != null && choseObs >= 50)
            {

                barrel.transform.position = new Vector3(obsPos, 0.5f, positionObstacle);
                obsPos += 4;
                barrel.SetActive(true);
            }else if(crate != null && choseObs < 50)
            {   
                    crate.transform.position = new Vector3(obsPos, 0.5f, positionObstacle);
                    obsPos += 4;
                    crate.SetActive(true);
              
            }
            if (coin != null)
            {
                coin.SetActive(true);
                coin.transform.position = new Vector3(obsPos, 1f, positionCoin);
                obsPos += 4;
            }
        }
     


    }
}
