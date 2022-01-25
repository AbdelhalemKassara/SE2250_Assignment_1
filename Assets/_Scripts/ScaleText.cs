using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScaleText : MonoBehaviour
{
    public TextMeshProUGUI text;
    private RectTransform textRectTran;

    // Start is called before the first frame update
    void Start()
    {
        textRectTran = text.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //sets the text position to the top right
        textRectTran.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 0, textRectTran.rect.width);
        textRectTran.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0, textRectTran.rect.height);
    }
}
