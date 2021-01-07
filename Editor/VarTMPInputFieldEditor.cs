using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEditor.UI;
using TMPro.EditorUtilities;

namespace Toorah.VariableUI.Editor
{
    [CustomEditor(typeof(VarTMPInputField), true)]
    public class VarTMPInputFieldEditor : VariableUIEditor<TMP_InputFieldEditor>{    }
}