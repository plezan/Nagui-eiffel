using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Question
    {
        #region Fields
        /// <summary>
        /// Question identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Question to ask
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Possible answers
        /// </summary>
        public IEnumerable<AnswerMonoBehaviour> Answers { get; set; }
        /// <summary>
        /// Good answer to the question
        /// </summary>
        public AnswerMonoBehaviour GoodAnswer { get; set; }
        /// <summary>
        /// Identifier of the good answer
        /// </summary>
        public int GoodAnswerId { get; set; }
        #endregion
    }
}
