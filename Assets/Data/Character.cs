using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using System.IO;

public class Character : MonoBehaviour
{
    private string _jsondata;
    private JsonData _characterdata;

    public void CallCharacterName()
    {

    }

    void Start()
    {
        _jsondata = File.ReadAllText(Application.dataPath + "/Data/Character.json");
        _characterdata = JsonMapper.ToObject(_jsondata);
    }

}
