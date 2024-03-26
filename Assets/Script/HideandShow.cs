using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndShow : MonoBehaviour
{
[Header("Animation One")]
public List<GameObject> ObjAnimOne = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void ShowOrHideAnimOne(bool hasToShow){
HideOrShow(ObjAnimOne, hasToShow);
}

private void HideOrShow(List<GameObject> objs, bool hasToShow){
foreach(var obj in objs){
obj.SetActive(hasToShow);
}
}
}
