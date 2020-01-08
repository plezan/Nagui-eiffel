using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class DoorMonoBehaviour : MonoBehaviour
    {
        #region Fields
        /// <summary>
        /// Answer
        /// </summary>
        public AnswerMonoBehaviour Answer { get; set; }
        /// <summary>
        /// Know if one of the doors is opened
        /// </summary>
        public bool IsOpened { get; set; } = false;
        #endregion
    }
}
