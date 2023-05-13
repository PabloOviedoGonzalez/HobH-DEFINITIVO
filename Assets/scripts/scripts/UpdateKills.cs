using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateKills : MonoBehaviour
{
    public TMPro.TMP_Text KillsText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string v = "KILLS:  " + GameManager.instance.GetenemyKills();
        KillsText.text = v;
    }
}
