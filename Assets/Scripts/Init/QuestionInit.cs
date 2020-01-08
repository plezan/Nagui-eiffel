using Assets.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Init
{
    public static class QuestionInit
    {
        /// <summary>
        /// Already used question
        /// </summary>
        private static List<Question> usedQuestions = new List<Question>();
        /// <summary>
        /// Questions
        /// </summary>
        public static List<Question> questions;

        /// <summary>
        /// Init the questions
        /// </summary>
        static QuestionInit()
        {
            #region Question 1
            AnswerMonoBehaviour q1a1 = new AnswerMonoBehaviour() { Value = "yo voy" };
            AnswerMonoBehaviour q1a2 = new AnswerMonoBehaviour() { Value = "es bueno" };
            AnswerMonoBehaviour q1a3 = new AnswerMonoBehaviour() { Value = "es hoy" };
            AnswerMonoBehaviour q1a4 = new AnswerMonoBehaviour() { Value = "es magnífico" };
            Question q1 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q1a1, q1a2, q1a3, q1a4
                },
                GoodAnswer = q1a1,
                GoodAnswerId = q1a1.Id,
                MediaTitle = "Despacito",
                Value = "Muéstrame el camino que ..."
            };
            #endregion

            #region Question 2
            AnswerMonoBehaviour q2a1 = new AnswerMonoBehaviour() { Value = "perfección" };
            AnswerMonoBehaviour q2a2 = new AnswerMonoBehaviour() { Value = "vuelta" };
            AnswerMonoBehaviour q2a3 = new AnswerMonoBehaviour() { Value = "predicción" };
            AnswerMonoBehaviour q2a4 = new AnswerMonoBehaviour() { Value = "pregunta D" };
            Question q2 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q2a1, q2a2, q2a3, q2a4
                },
                GoodAnswer = q2a1,
                GoodAnswerId = q2a1.Id,
                MediaTitle = "Que Calor",
                Value = "Pero se aprendió la canción a la..."
            };
            #endregion

            #region Question 3
            AnswerMonoBehaviour q3a1 = new AnswerMonoBehaviour() { Value = "vea" };
            AnswerMonoBehaviour q3a2 = new AnswerMonoBehaviour() { Value = "la levante" };
            AnswerMonoBehaviour q3a3 = new AnswerMonoBehaviour() { Value = "se levante" };
            AnswerMonoBehaviour q3a4 = new AnswerMonoBehaviour() { Value = "se vuelva" };
            Question q3 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q3a1, q3a2, q3a3, q3a4
                },
                GoodAnswer = q3a1,
                GoodAnswerId = q3a1.Id,
                MediaTitle = "Con Calma",
                Value = "Es un asesina, cuando baila quiere que to' el mundo la ..."
            };
            #endregion

            #region Question 4
            AnswerMonoBehaviour q4a1 = new AnswerMonoBehaviour() { Value = "cabeza" };
            AnswerMonoBehaviour q4a2 = new AnswerMonoBehaviour() { Value = "pierna" };
            AnswerMonoBehaviour q4a3 = new AnswerMonoBehaviour() { Value = "cintura" };
            AnswerMonoBehaviour q4a4 = new AnswerMonoBehaviour() { Value = "pregunta D" };
            Question q4 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q4a1, q4a2, q4a3, q4a4
                },
                GoodAnswer = q4a1,
                GoodAnswerId = q4a1.Id,
                MediaTitle = "Bomba",
                Value = "Una mano en la ..."
            };
            #endregion

            #region Question 5
            AnswerMonoBehaviour q5a1 = new AnswerMonoBehaviour() { Value = "fuera de lugar" };
            AnswerMonoBehaviour q5a2 = new AnswerMonoBehaviour() { Value = "popular" };
            AnswerMonoBehaviour q5a3 = new AnswerMonoBehaviour() { Value = "pregunta D" };
            AnswerMonoBehaviour q5a4 = new AnswerMonoBehaviour() { Value = "fuera de preguntar" };
            Question q5 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q5a1, q5a2, q5a3, q5a4
                },
                GoodAnswer = q5a1,
                GoodAnswerId = q5a1.Id,
                MediaTitle = "Loco Contigo",
                Value = "Ram - pa - pa - pam - pam con un booty..."
            };
            #endregion

            #region Question 6
            AnswerMonoBehaviour q6a1 = new AnswerMonoBehaviour() { Value = "mentira" };
            AnswerMonoBehaviour q6a2 = new AnswerMonoBehaviour() { Value = "palabra" };
            AnswerMonoBehaviour q6a3 = new AnswerMonoBehaviour() { Value = "promesa" };
            AnswerMonoBehaviour q6a4 = new AnswerMonoBehaviour() { Value = "cuerpo" };
            Question q6 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q6a1, q6a2, q6a3, q6a4
                },
                GoodAnswer = q6a1,
                GoodAnswerId = q6a1.Id,
                MediaTitle = "La Camisa Negra",
                Value = "Y fue pura todita tu..."
            };
            #endregion

            #region Question 7
            AnswerMonoBehaviour q7a1 = new AnswerMonoBehaviour() { Value = "pasado" };
            AnswerMonoBehaviour q7a2 = new AnswerMonoBehaviour() { Value = "pescado" };
            AnswerMonoBehaviour q7a3 = new AnswerMonoBehaviour() { Value = "humbre" };
            AnswerMonoBehaviour q7a4 = new AnswerMonoBehaviour() { Value = "hombro" };
            Question q7 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q7a1, q7a2, q7a3, q7a4
                },
                GoodAnswer = q7a1,
                GoodAnswerId = q7a1.Id,
                MediaTitle = "Bamboleo",
                Value = "Amor de en el..."
            };
            #endregion

            #region Question 8
            AnswerMonoBehaviour q8a1 = new AnswerMonoBehaviour() { Value = "pregunta D" };
            AnswerMonoBehaviour q8a2 = new AnswerMonoBehaviour() { Value = "a ir" };
            AnswerMonoBehaviour q8a3 = new AnswerMonoBehaviour() { Value = "a ir solo" };
            AnswerMonoBehaviour q8a4 = new AnswerMonoBehaviour() { Value = "a ir allí" };
            Question q8 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q8a1, q8a2, q8a3, q8a4
                },
                GoodAnswer = q8a1,
                GoodAnswerId = q8a1.Id,
                MediaTitle = "Porque Te Vas",
                Value = "Porque te vas..."
            };
            #endregion

            #region Question 9
            AnswerMonoBehaviour q9a1 = new AnswerMonoBehaviour() { Value = "gracia" };
            AnswerMonoBehaviour q9a2 = new AnswerMonoBehaviour() { Value = "hiela" };
            AnswerMonoBehaviour q9a3 = new AnswerMonoBehaviour() { Value = "paciencia" };
            AnswerMonoBehaviour q9a4 = new AnswerMonoBehaviour() { Value = "flexibilidad" };
            Question q9 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q9a1, q9a2, q9a3, q9a4
                },
                GoodAnswer = q9a1,
                GoodAnswerId = q9a1.Id,
                MediaTitle = "baila Bamba",
                Value = "Para bailar la bamba se necesita una poca de..."
            };
            #endregion

            #region Question 10
            AnswerMonoBehaviour q10a1 = new AnswerMonoBehaviour() { Value = "carnal" };
            AnswerMonoBehaviour q10a2 = new AnswerMonoBehaviour() { Value = "encantador" };
            AnswerMonoBehaviour q10a3 = new AnswerMonoBehaviour() { Value = "especial" };
            AnswerMonoBehaviour q10a4 = new AnswerMonoBehaviour() { Value = "halal" };
            Question q10 = new Question()
            {
                Answers = new List<AnswerMonoBehaviour>()
                {
                    q10a1, q10a2, q10a3, q10a4
                },
                GoodAnswer = q10a1,
                GoodAnswerId = q10a1.Id,
                MediaTitle = "Letras",
                Value = "Ella es un laberinto ..."
            };
            #endregion

            questions = new List<Question>()
            {
                q1, q2, q3, q4, q5, q6, q7, q8, q9, q10
            };
        }


        /// <summary>
        /// Get a random question
        /// </summary>
        /// <returns></returns>
        public static Question GetRandomQuestion()
        {
            Question result = null;
            Random random = new Random();
            bool alreadyUsed = false;

            do
            {
                result = questions.ElementAt(random.Next(0, questions.Count()));
                alreadyUsed = usedQuestions.Any(x => x.Id == result.Id);
            } while (alreadyUsed);

            return result;
        }
    }
}
