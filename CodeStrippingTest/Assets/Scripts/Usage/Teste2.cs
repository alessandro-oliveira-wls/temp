using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Teste2
    {
        private Text logText;

        public Teste2(Text logText)
        {
            this.logText = logText;
        }

        public void CallTest2()
        {
            var msg = "Teste2->CallTeste2()";
            Debug.unityLogger.Log(msg);
            logText.text = msg;
        }
    }
}