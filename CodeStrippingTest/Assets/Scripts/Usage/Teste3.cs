using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Teste3
    {
        private Text logText;

        public Teste3(Text logText)
        {
            this.logText = logText;
        }

        public void CallTest3()
        {
            var msg = "Teste3->CallTeste3()";
            Debug.unityLogger.Log(msg);
            logText.text = msg;
        }
    }
}