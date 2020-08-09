using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EmenyCreate : EditorWindow
{
    string s = "Wow";
    public GameObject c1, c2, c3;

    [MenuItem("TestEditor/EditorWindow")]
    public static void Open()
    {
        GetWindow<EmenyCreate>().titleContent = new GUIContent("My");
    }

    private void OnGUI()
    {
        GUILayout.Label("Hello World");
        c1 = (GameObject)EditorGUILayout.ObjectField(c1, typeof(GameObject), true);
        c2 = (GameObject)EditorGUILayout.ObjectField(c2, typeof(GameObject), true);
        c3 = (GameObject)EditorGUILayout.ObjectField(c3, typeof(GameObject), true);

        if (GUILayout.Button("Shuffle Card"))
        {
            ShuffleGameObj(c1, c2);
            ShuffleGameObj(c2, c3);
            ShuffleGameObj(c1, c3);
        }

        void ShuffleGameObj(GameObject go1, GameObject go2)
        {
            int n = Random.Range(0, 2);

            if (n == 0)
            {
                Vector3 pos = go1.transform.localPosition;
                go1.transform.localPosition = go2.transform.localPosition;
                go2.transform.localPosition = pos;
            }
        }
    }
}
