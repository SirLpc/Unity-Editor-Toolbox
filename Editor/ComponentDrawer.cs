﻿using UnityEngine;
using UnityEditor;

namespace Toolbox.Editor
{
    //[CustomPropertyDrawer(typeof(Attribute))]
    public class ComponentDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);
        }
    }
}