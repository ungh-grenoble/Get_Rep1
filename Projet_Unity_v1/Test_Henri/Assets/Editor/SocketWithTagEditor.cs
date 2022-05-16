using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.XR.Interaction.Toolkit;
using UnityEditor;

[CustomEditor(typeof(SocketWithTagCheck))]
public class SocketWithTagEditor : XRSocketInteractorEditor
{
    // Start is called before the first frame update

    private SerializedProperty targetTag = null;

    protected override void OnEnable()
    {
        base.OnEnable();
        targetTag = serializedObject.FindProperty("targetTag");

    }

    protected override void DrawProperties()
    {
        base.DrawProperties();
        EditorGUILayout.PropertyField(targetTag);
    }
    
}
