﻿using UnityEngine;

namespace Pear.InteractionEngine.Controllers.Behaviors
{
    /// <summary>
    /// Drag to rotate the controller's active object
    /// </summary>
    public class DragToZoom : DragBehavior
    {

        /// <summary>
        /// Zoom in/out based on the drag factor
        /// </summary>
        /// <param name="actionFactor">relative position * MaxSpeed</param>
        protected override void PerformAction(Vector3 actionFactor)
        {
            Controller.ActiveObject.AnchorElement.transform.localScale += Vector3.one * Vector3.Distance(Vector3.zero, actionFactor / 100);
        }
    }
}