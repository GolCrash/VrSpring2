using System.IO;
using UnityEngine;

public class JSONWriteScript : MonoBehaviour
{

    [System.Serializable]

    public class tockar
    {
        public string tockar_name;
    }

    [System.Serializable]

    public class tockarList
    {
        public tockar[] tockar;
    }

    public tockar mytockar = new tockar();
    public tockarList tockarlist = new tockarList();

    public void outputJSON()
    {
        string strOutput = JsonUtility.ToJson(mytockar);

        File.WriteAllText(Application.dataPath + "/text.txt", strOutput);

        string strOutput2 = JsonUtility.ToJson(tockarlist);

        File.WriteAllText(Application.dataPath + "/text2.txt", strOutput2);
    }


}
