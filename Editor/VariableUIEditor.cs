using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEditor.UI;

namespace Toorah.VariableUI.Editor
{
    public abstract class VariableUIEditor<T> : UnityEditor.Editor where T : UnityEditor.Editor
    {
        protected SerializedProperty m_variable;
        protected UnityEditor.Editor m_editor;

        protected virtual string VarPropertyName => nameof(m_variable);

        protected virtual void OnEnable()
        {
            m_variable = serializedObject.FindProperty(VarPropertyName);
            if (m_editor == null)
            {
                m_editor = CreateEditor(target, typeof(T));
            }
        }
        private void OnDisable()
        {
            if(m_editor != null)
            {
                DestroyImmediate(m_editor);
            }
        }
        public override void OnInspectorGUI()
        {

            serializedObject.Update();
            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox))
            {
                GUILayout.Space(5);
                EditorGUILayout.PropertyField(m_variable);
                GUILayout.Space(5);
            }
            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox))
            {
                m_editor.OnInspectorGUI();
            }
            serializedObject.ApplyModifiedProperties();
        }

    }
}
