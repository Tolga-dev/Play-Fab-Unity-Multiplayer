using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Scenes
{
    public class NetworkTest : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(CheckInternetConnection());
        }

        IEnumerator CheckInternetConnection()
        {
            UnityWebRequest request = new UnityWebRequest("http://www.google.com");
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Error: " + request.error);
            }
            else
            {
                Debug.Log("Internet connection successful.");
            }
        }
    }
}