using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(CelulaReference))]
public class CelulaReferenceDrawer : PropertyDrawer
{
    private GUIStyle popupStyle;

    private readonly string[] popupOptions =
            { "Usar referencia da planilha", "Usar versão de teste" };

    //Seta a altura da propriedade
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        SerializedProperty propertyDrawerAux = property.FindPropertyRelative("propertyDrawerAux");
        return propertyDrawerAux.floatValue;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        float propertyHeight = 0f;
        
        if (popupStyle == null)
        {
            popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
            popupStyle.imagePosition = ImagePosition.ImageOnly;
        }

        // Get properties
        SerializedProperty modoReferencia = property.FindPropertyRelative("modoReferencia");

        SerializedProperty valor = property.FindPropertyRelative("valor");
        SerializedProperty linha = property.FindPropertyRelative("linha");
        SerializedProperty coluna = property.FindPropertyRelative("coluna");
        SerializedProperty planilha = property.FindPropertyRelative("planilha");
        SerializedProperty propertyDrawerAux = property.FindPropertyRelative("propertyDrawerAux");

        EditorGUI.BeginChangeCheck();
        PlanilhaDoGoogle planilhaObj = planilha.objectReferenceValue as PlanilhaDoGoogle;
        EditorGUI.BeginProperty(position, label, property);

        position.height = EditorGUIUtility.singleLineHeight;

        
        string foldoutLabel = property.displayName;
        if (modoReferencia.boolValue)
        {
            property.isExpanded = EditorGUI.Foldout(position, property.isExpanded, foldoutLabel, true);

            if (planilhaObj != null)
                valor.stringValue = planilhaObj.GetDataAt(linha.intValue, coluna.intValue);
            else
                valor.stringValue = "null reference";
        }
        else
        {
            EditorGUI.LabelField(position, foldoutLabel);
            property.isExpanded = false;
        }

        EditorGUI.indentLevel++;
        // draw next PropertyField, and so on
        if (property.isExpanded)
        {
            propertyHeight += position.height + EditorGUIUtility.standardVerticalSpacing;
            position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
            //Propriedade da planilha
            Rect planilhaRect = new Rect(position.x, position.y, position.width, position.height);
            EditorGUI.PropertyField(planilhaRect, planilha);
            propertyHeight += position.height + EditorGUIUtility.standardVerticalSpacing;
            if (planilhaObj != null)
            {
                //Linha
                propertyHeight += position.height + EditorGUIUtility.standardVerticalSpacing;
                position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
                EditorGUI.LabelField(position, "Linha: ");

                Rect linhaRect = new Rect(EditorGUIUtility.labelWidth - ((EditorGUI.indentLevel - 1) * 15) + 5, position.y, position.width - (EditorGUIUtility.labelWidth - ((EditorGUI.indentLevel - 1) * 15 + 13)), position.height);
                linha.intValue = EditorGUI.IntSlider(linhaRect, linha.intValue, 0, planilhaObj.quantidadeDeLinhas-1);

                //Coluna
                propertyHeight += position.height + EditorGUIUtility.standardVerticalSpacing;
                position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
                EditorGUI.LabelField(position, "Coluna: ");

                Rect colunaRect = new Rect(EditorGUIUtility.labelWidth - ((EditorGUI.indentLevel - 1) * 15) + 5, position.y, position.width -(EditorGUIUtility.labelWidth - ((EditorGUI.indentLevel - 1) * 15 + 13)), position.height);
                coluna.intValue = EditorGUI.IntSlider(colunaRect, coluna.intValue, 0, planilhaObj.quantidadeDeColunas-1);
                
                //Label Valor
                position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
                propertyHeight += position.height + EditorGUIUtility.standardVerticalSpacing;
                EditorGUI.LabelField(position, "Valor: ");

                //TextAreaValor
                float positionX = EditorGUIUtility.labelWidth - ((EditorGUI.indentLevel - 1) * 15) + 5;

                float alturaDoValor = position.height * quantidadeDeLinhasEm(valor.stringValue);
                propertyHeight += alturaDoValor + EditorGUIUtility.standardVerticalSpacing;

                Rect valorRect = new Rect(positionX, position.y, position.width - positionX + 18, alturaDoValor);

                EditorGUI.BeginDisabledGroup(modoReferencia.boolValue);
                valor.stringValue = EditorGUI.TextArea(valorRect, valor.stringValue);
                EditorGUI.EndDisabledGroup();
            }
        }
        else
        {
            float alturaDoValor = position.height * quantidadeDeLinhasEm(valor.stringValue);
            propertyHeight += alturaDoValor + EditorGUIUtility.standardVerticalSpacing;
            if (planilhaObj != null || !modoReferencia.boolValue)
            {
                float positionX = EditorGUIUtility.labelWidth - ((EditorGUI.indentLevel - 1) * 15) + 5;

                Rect valorRect = new Rect(positionX, position.y, position.width - positionX + 18, alturaDoValor);

                EditorGUI.BeginDisabledGroup(modoReferencia.boolValue);
                valor.stringValue = EditorGUI.TextArea(valorRect, valor.stringValue);
                EditorGUI.EndDisabledGroup();
            }
        }
        //Popup
        Rect popUpRect = new Rect(EditorGUIUtility.labelWidth - ((EditorGUI.indentLevel - 1) * 15) - 15, position.y, EditorGUIUtility.singleLineHeight * 3 + 10, position.height);

        int result = EditorGUI.Popup(popUpRect, "", modoReferencia.boolValue ? 0 : 1, popupOptions, popupStyle);
        if (result == 0)
            modoReferencia.boolValue = true;
        else
            modoReferencia.boolValue = false;


        propertyDrawerAux.floatValue = propertyHeight;
        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.EndProperty();
    }


    private int quantidadeDeLinhasEm(string celula)
    {
        int quant = 1;
        foreach (char c in celula.ToCharArray())
        {
            if (c == '\n')
                quant++;
        }
        return quant;
    }
}
