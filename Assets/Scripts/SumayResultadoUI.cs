using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumayResultadoUI : MonoBehaviour
{
    public TMP_InputField InputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI txtNum;
    int num1;
    int num2;


    // Start is called before the first frame update
    void Start()
    {
        txtNum.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SumarYmostrar()
    {
        num1 = int.Parse(InputNum1.text);
        num2 = int.Parse(inputNum2.text);
        txtNum.text = (num1 + num2).ToString(); 
        Debug.Log("sumando");
    }

}
