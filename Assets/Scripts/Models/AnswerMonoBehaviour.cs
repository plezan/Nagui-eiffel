using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class AnswerMonoBehaviour : MonoBehaviour
    {
        #region Fields
        /// <summary>
        /// Answer identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Answer to display
        /// </summary>
        public string Value { get; set; }
        #endregion

    }
}
