using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CsScaleChecker : EditorWindow
{
    // Start is called before the first frame update
    string meshName;
    float m_Height;
    float m_Width;
    float m_Length;

    [MenuItem("Tools/Toolkit/Check Scale")]
    static public void ShowWindow()
    {
        CsScaleChecker window = EditorWindow.GetWindow<CsScaleChecker>();
        window.titleContent.text = "Check Object Scale";
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField("Check Mesh Size in Meter", EditorStyles.boldLabel);

        //GUILayout.Label("Minimum Object Height: " + m_minHeight.ToString("0.00"));
        
        if (GUILayout.Button("Check Object Scale", GUILayout.Height(30)))
        {
            GameObject obj = Selection.activeGameObject;

      
            meshName = obj.name;
            m_Height = GetObjectHeight(obj);
            m_Width = GetObjectLength(obj);
            m_Length = GetObjectWidth(obj);
        }
        EditorGUILayout.LabelField("Measuring Size of = " + meshName + " ", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Height of this Object is = " + m_Height + " Meters", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Width of this Object is = " + m_Width + " Meters", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Length of this Object is = " + m_Length + " Meters", EditorStyles.boldLabel);



    }


    float GetObjectHeight(GameObject obj)
    {
        Renderer renderer = obj.GetComponent<Renderer>();

        if (renderer != null)
        {
            return renderer.bounds.size.y;
        }
        else
        {
            return 0f;
        }
    }

    float GetObjectLength(GameObject obj)
    {
        Renderer renderer = obj.GetComponent<Renderer>();

        if (renderer != null)
        {
            return renderer.bounds.size.x;
        }
        else
        {
            return 0f;
        }
    }

    float GetObjectWidth(GameObject obj)
    {
        Renderer renderer = obj.GetComponent<Renderer>();

        if (renderer != null)
        {
            return renderer.bounds.size.z;
        }
        else
        {
            return 0f;
        }
    }
}
