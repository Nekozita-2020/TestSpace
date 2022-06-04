namespace Nekozita
{
    using UnityEditor;
    using UnityEngine.UI;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;


    /// <summary>
    /// ボタン拡張
    /// </summary>
    public class ButtonExtention : Button , IPointerDownHandler, IPointerUpHandler
    {



        /// <summary>
        /// Buttonが押下された時
        /// </summary>
        /// <param name="eventData"></param>
        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);

            Debug.Log("OnPointerDown");
        }

        /// <summary>
        /// Buttonが押下から解除された時
        /// </summary>
        /// <param name="eventData"></param>
        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);

            Debug.Log("OnPointerUp");
        }

        /// <summary>
        /// Buttonがクリックされた時
        /// </summary>
        /// <param name="eventData"></param>
        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);

            Debug.Log("OnPointerClick");
        }

        /// <summary>
        /// サブミットボタン（リターンキーやスペースキー）が押されたとき
        /// </summary>
        /// <param name="eventData"></param>
        public override void OnSubmit(BaseEventData eventData)
        {
            base.OnSubmit(eventData);

            Debug.Log("OnSubmit");
        }
    }
}