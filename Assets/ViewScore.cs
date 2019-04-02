using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class ViewScore : MonoBehaviour
{

    public static int hCoins = 0;
    public static float hTime = 0.0f;
    public static DateTime date;
    public Button start;
    public Button mute;
    public Button back;
    public Button score;
    public Text title;
    public Text coins;
    public Text time;
    Dictionary<List<String>, Boolean> buttonMap = new Dictionary<List<String>, Boolean>()
        {
            {new List<string>(){ "Start", "Mute", "Score" }, false },
            {new List<string>(){ "Back" }, true },
        };


    // Use this for initialization
    void Start()
    {
        //PlayerPrefs.SetInt("Coins", 0);
        //PlayerPrefs.SetFloat("Time", 0.00f);
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    public void Score()
    {
       


        var buttons = Resources.FindObjectsOfTypeAll<Button>();
        var texts = Resources.FindObjectsOfTypeAll<Text>();

        buttonMap.ToList().ForEach(pair =>
            buttons.Where(x => pair.Key.Contains(x.name))
                    .ToList()
                    .ForEach(x => x.gameObject.SetActive(pair.Value)));

        //buttons.Where(x => (new List<string>() { "Start", "Mute", "Score" }).Contains(x.name))
        //        .ToList()
        //        .ForEach(x => x.gameObject.SetActive(false));
        texts.Where(x => (new List<string>() { "Coins", "Time"}).Contains(x.name))
              .ToList()
              .ForEach(x => x.gameObject.SetActive(true));

        //buttons.Where(x => (new List<string>() { "Back" }).Contains(x.name))
        //        .ToList()
        //        .ForEach(x => x.gameObject.SetActive(true));


        title.text = "High Score";
        coins.text = "Colected coins : " + PlayerPrefs.GetInt("Coins");
        time.text = "Best time : " + PlayerPrefs.GetFloat("Time").ToString("F2");


    }
    public void Back()
    {
        var buttons = Resources.FindObjectsOfTypeAll<Button>();
        var texts = Resources.FindObjectsOfTypeAll<Text>();
        buttonMap.ToList().ForEach(pair =>
            buttons.Where(x => pair.Key.Contains(x.name))
                    .ToList()
                    .ForEach(x => x.gameObject.SetActive(!pair.Value)));
        texts.Where(x => (new List<string>() { "Coins", "Time" }).Contains(x.name))
              .ToList()
              .ForEach(x => x.gameObject.SetActive(false));

       
        GameObject.Find("Title").GetComponent<Text>().text = "Endless Runner";
    }

    //public static GameObject FindObject(this GameObject parent, string name)
    //{
    //    Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
    //    foreach (Transform t in trs)
    //    {
    //        if (t.name == name)
    //        {
    //            return t.gameObject;
    //        }
    //    }
    //    return null;
    //}

}
