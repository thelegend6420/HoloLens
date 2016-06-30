using UnityEngine;
using System.Collections;
using System.Net;
using System.Collections.Generic;

public class txtSample : MonoBehaviour {

    private TextMesh txt = null;
    private string sampleTxt = string.Empty;
	// Use this for initialization
	void Start () {

        txt = GetComponent<TextMesh>();
        var basUrl = "http://localhost/HoloLens/api/";
        var api = new WebApiInvoke(Callback);
        //var url = "http://10.70.77.166/HoloLens/api/DataProvider/GetDataExample?type=MIG";
        var url = "http://test.epo.oa.com/SPQMAPI/api/P2PProspectiveAPI/GetItemByPrTypeId";
        var dic = new Dictionary<string, object>();
        //dic.Add("type", "PO");
         api.PostAsyn(url, dic);
	}
	
	// Update is called once per frame
	void Update () {
        if (sampleTxt != txt.text)
        {
            txt.text = sampleTxt;
        }
	
	}
    private void Callback(int code, string data)
    {
        if (code == 200)
        {
            sampleTxt = data;
        }
    }
}
