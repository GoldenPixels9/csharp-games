using System;

namespace Unit04.Game.Casting
{
    public class Artifact : Actor
    {
        int artifact_value;
        string artifact_text;
        private int value;
        public Artifact()
        {
        }

        public int GetValue()
        {
            return value;
        }

        public void SetMessage(int value)
        {
            this.value = value;
        }

        public string physicalIdentity(int num){
            if (num == 1){
                artifact_text = "*";
            }
            else if (num == 0){
                artifact_text = "O";
            }
            return artifact_text;
        }

        public int scoreValue(int num){
             if (num == 1){
                artifact_value = 1;
            }
            else if (num == 0){
                artifact_value = -1;
            }
            return artifact_value;
        }

    } 
}
    // TODO: Implement the Artifact class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Actor class.

        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>


    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
       

    // 3) Create the GetMessage() method. Use the following method comment.
        
        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        

    // 4) Create the SetMessage(string message) method. Use the following method comment.
        
        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>