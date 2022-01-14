using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Teste4
    {
        private Text logText;

        public Teste4(Text logText)
        {
            this.logText = logText;
        }

        public void CallTest4()
        {
            var msg = "Teste4->CallTeste4()";
            Debug.unityLogger.Log(msg);
            logText.text = msg;
        }
    }
}