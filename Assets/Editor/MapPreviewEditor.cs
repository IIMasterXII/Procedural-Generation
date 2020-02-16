using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapPreview))]
public class MapPreviewEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapPreview mapPrev = (MapPreview)target;

        if (DrawDefaultInspector())
        {
            if (mapPrev.autoUpdate)
            {
                mapPrev.DrawMapInEditor();
            }
        }

        if (GUILayout.Button("Generate"))
        {
            mapPrev.DrawMapInEditor();
        }
    }
}
