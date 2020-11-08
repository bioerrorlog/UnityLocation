using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLocationText : MonoBehaviour
{
    public Text location;

    private void Update()
    {
        location.text = $"緯度: {Location.Instance.latitude}\n経度: {Location.Instance.longitude}\n高度: {Location.Instance.altitude}\n\nCount: {Location.Instance.gps_count}\nMessage:\n{Location.Instance.message}";
    }
}
