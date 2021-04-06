using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class WorkWithText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    // Start is called before the first frame update
    void Start()
    {
        _text1.DOText("Zamena", 3);
        _text2.DOText("Dopolnenir", 3).SetRelative();
        _text3.DOText("perebor", 3, true, ScrambleMode.All);
    }


}
