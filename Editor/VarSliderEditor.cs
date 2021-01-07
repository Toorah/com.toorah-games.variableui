using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEditor.UI;

namespace Toorah.VariableUI.Editor
{
    [CustomEditor(typeof(VarSlider), true)]
    public class VarSliderEditor : VariableUIEditor<SliderEditor>
    {
    }
}
