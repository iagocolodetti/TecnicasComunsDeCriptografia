using System;

namespace Técnicas_Comuns_de_Criptografia
{
    class Criptografia
    {
        private bool IsBinary(string text)
        {
            foreach (char c in text) if (c != '0' && c != '1') return false;
            return true;
        }

        private bool IsInvalidChar(char c, int min, int max)
        {
            return (c < min || c > max);
        }

        private bool InvalidCharsInString(string text, out string invalidchars, int min, int max)
        {
            invalidchars = string.Empty;
            foreach (char c in text) if (IsInvalidChar(c, min, max)) invalidchars += c + " (" + (int)c + ")   ";
            return (!string.IsNullOrEmpty(invalidchars));
        }

        /// <summary>
        /// Método de ciframento baseado na substituição de caracteres, no qual cada caractere é convertido para binário de acordo com a tabela ASCII e somado a uma chave binária.
        /// Este método também decifra em caso de ser um(a) texto/palavra cifrado por ele.
        /// Técnica conhecida como 'Cifra Aditiva'.
        /// </summary>
        /// <param name="text">Texto/Palavra a ser cifrado(a).</param>
        /// <param name="key">Chave binária.</param>
        public string Cifrar(string text, string key)
        {
            if (string.IsNullOrEmpty(text)) throw new Exception("Digite algum(a) texto/palavra para ser cifrado(a).");
            if (string.IsNullOrEmpty(key)) throw new Exception("Digite uma chave (em binário).");
            if (!IsBinary(key)) throw new Exception("A chave deve ser em binário (0 ou 1).");
            if (key.Length > 8) throw new Exception("A chave deve ter no máximo 8 dígitos.");
            if (InvalidCharsInString(text, out string invalidchars, 0, 255)) throw new Exception("Existe(m) caractere(s) inválido(s) no(a) texto/palavra.\nCaracteres inválidos: " + invalidchars);

            string textCifrado = string.Empty;
            key = key.PadLeft(8, '0');
            foreach (char c in text)
            {
                string charBinary = Convert.ToString(c, 2).PadLeft(8, '0');
                string charCifrado = string.Empty;
                for (int i = 0; i < 8; i++) charCifrado = charCifrado.Insert(i, ((Equals(charBinary[i], key[i]) ? "0" : "1")));
                textCifrado += (char)Convert.ToInt32(charCifrado, 2);
            }
            return textCifrado;
        }

        /// <summary>
        /// Método de ciframento baseado na substituição, no qual cada caractere é deslocado de acordo com um inteiro (k) usado para deslocamento. Técnica conhecida como 'Cifra de César'.
        /// </summary>
        /// <param name="text">Texto/Palavra a ser cifrado(a).</param>
        /// <param name="deslocamento">Número inteiro (k) que será usado como base para efetuar o deslocamento do(s) caractere(s).</param>
        /// <param name="min">Caractere mínimo permitido.</param>
        /// <param name="max">Caractere máximo permitido.</param>
        public string Cifrar(string text, int deslocamento, int min = 32, int max = 255)
        {
            int MAX_DESLOCAMENTO = ((max + 1) - min);
            if (string.IsNullOrEmpty(text)) throw new Exception("Digite algum(a) texto/palavra para ser cifrado(a).");
            if (deslocamento < 0 || deslocamento > MAX_DESLOCAMENTO) throw new Exception("O deslocamento não pode ser menor que 0 e não pode ser maior que " + MAX_DESLOCAMENTO);
            if (InvalidCharsInString(text, out string invalidchars, min, max)) throw new Exception("Existe(m) caractere(s) inválido(s) no(a) texto/palavra.\nCaracteres inválidos: " + invalidchars);

            string textCifrado = string.Empty;
            foreach (char c in text)
            {
                if ((c - deslocamento) < min) textCifrado += (char)((max + 1) - (min - (c - deslocamento)));
                else textCifrado += (char)(c - deslocamento);
            }
            return textCifrado;
        }

        /// <summary>
        /// Método de deciframento para decifrar palavras cifradas com a técnica 'Cifra de César'.
        /// </summary>
        /// <param name="text">Texto/Palavra a ser decifrado(a).</param>
        /// <param name="deslocamento">Número inteiro (k) que será usado como base para efetuar o deslocamento do(s) caractere(s).</param>
        /// <param name="min">Caractere mínimo permitido.</param>
        /// <param name="max">Caractere máximo permitido.</param>
        public string Decifrar(string text, int deslocamento, int min = 32, int max = 255)
        {
            int MAX_DESLOCAMENTO = ((max + 1) - min);
            if (string.IsNullOrEmpty(text)) throw new Exception("Digite algum(a) texto/palavra para ser decifrado(a).");
            if (deslocamento < 0 || deslocamento > MAX_DESLOCAMENTO) throw new Exception("O deslocamento não pode ser menor que 0 e não pode ser maior que " + MAX_DESLOCAMENTO);
            if (InvalidCharsInString(text, out string invalidchars, min, max)) throw new Exception("Existe(m) caractere(s) inválido(s) no(a) texto/palavra.\nCaracteres inválidos: " + invalidchars);

            string textDecifrado = string.Empty;
            foreach (char c in text)
            {
                if ((c + deslocamento) > max) textDecifrado += (char)((c + deslocamento) - MAX_DESLOCAMENTO);
                else textDecifrado += (char)(c + deslocamento);
            }
            return textDecifrado;
        }

        /// <summary>
        /// Método de ciframento baseado na transposição, no qual cada caracteres são embaralhados. Técnica conhecida como 'Cifra Rail Fence (Zig Zag)'.
        /// </summary>
        /// <param name="text">Texto/Palavra a ser cifrado(a).</param>
        public string Cifrar(string text)
        {
            if (string.IsNullOrEmpty(text)) throw new Exception("Digite algum(a) texto/palavra para ser cifrado(a).");

            string linha1 = string.Empty;
            string linha2 = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || (i % 2) == 0) linha1 += text[i];
                else linha2 += text[i];
            }
            return (linha1 + linha2);
        }

        /// <summary>
        /// Método de deciframento para decifrar palavras cifradas com a técnica 'Cifra Rail Fence (Zig Zag)'.
        /// </summary>
        /// <param name="text">Texto/Palavra a ser decifrado(a).</param>
        public string Decifrar(string text)
        {
            if (string.IsNullOrEmpty(text)) throw new Exception("Digite algum(a) texto/palavra para ser decifrado(a).");

            string textDecifrado = string.Empty;
            string linha1 = string.Empty;
            string linha2 = string.Empty;
            if ((text.Length % 2) == 0)
            {
                linha1 = text.Substring(0, (text.Length / 2));
                linha2 = text.Substring((text.Length / 2));
            }
            else
            {
                linha1 = text.Substring(0, ((text.Length / 2) + 1));
                linha2 = text.Substring(((text.Length / 2) + 1));
            }
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || (i % 2) == 0) textDecifrado += linha1[index];
                else
                {
                    textDecifrado += linha2[index];
                    index++;
                }
            }
            return textDecifrado;
        }

        /// <summary>
        /// Método de ciframento usando matemática. A partir da chave um valor é gerado e é somado ao valor em decimal de cada caractere na tabela ASCII.
        /// </summary>
        /// <param name="text">Texto/Palavra a ser cifrado(a).</param>
        /// <param name="key">Chave.</param>
        public string CifrarM(string text, string key)
        {
            if (string.IsNullOrEmpty(text)) throw new Exception("Digite algum(a) texto/palavra para ser cifrado(a).");
            if (string.IsNullOrEmpty(key)) throw new Exception("Digite uma chave.");
            if (key.Length > 8) throw new Exception("A chave deve ter no máximo 8 dígitos.");
            if (InvalidCharsInString(text, out string invalidchars, 32, 255)) throw new Exception("Existe(m) caractere(s) inválido(s) no(a) texto/palavra.\nCaracteres inválidos: " + invalidchars);
            if (InvalidCharsInString(key, out invalidchars, 33, 255)) throw new Exception("Existe(m) caractere(s) inválido(s) na chave.\nCaracteres inválidos: " + invalidchars);
            
            int valorDaChave = 0;
            for (int i = 0; i < key.Length; i++) valorDaChave += (key[i] * (key.Length - i));
            int MAX_BLOCK_LENGTH = Convert.ToString((255 + valorDaChave), 16).Length;
            string textCifrado = MAX_BLOCK_LENGTH.ToString();
            foreach (char c in text) textCifrado += Convert.ToString((c + valorDaChave), 16).PadLeft(MAX_BLOCK_LENGTH, '0');
            return textCifrado.ToUpper();
        }
        
        /// <summary>
        /// Método de deciframento usando matemática. Usando a mesma chave no qual um(a) determinado(a) texto/palavra foi cifrado(a) é possível decifrá-lo(a) usando este método.
        /// </summary>
        /// <param name="text">Texto/Palavra a ser decifrado(a).</param>
        /// <param name="key">Chave.</param>
        public string DecifrarM(string text, string key)
        {
            if (string.IsNullOrEmpty(text)) throw new Exception("Digite algum(a) texto/palavra para ser cifrado(a).");
            if (string.IsNullOrEmpty(key)) throw new Exception("Digite uma chave.");
            if (key.Length > 8) throw new Exception("A chave deve ter no máximo 8 dígitos.");
            if (InvalidCharsInString(text, out string invalidchars, 32, 255)) throw new Exception("Existe(m) caractere(s) inválido(s) no(a) texto/palavra.\nCaracteres inválidos: " + invalidchars);
            if (InvalidCharsInString(key, out invalidchars, 33, 255)) throw new Exception("Existe(m) caractere(s) inválido(s) na chave.\nCaracteres inválidos: " + invalidchars);
            if (!int.TryParse(text[0].ToString(), out int MAX_BLOCK_LENGTH)) throw new Exception("Não foi possível decifrar, texto cifrado adulterado.");

            int valorDaChave = 0;
            for (int i = 0; i < key.Length; i++) valorDaChave += (key[i] * (key.Length - i));
            string textDecifrado = string.Empty;
            for (int i = 1; i < text.Length; i += MAX_BLOCK_LENGTH) textDecifrado += (char)(Convert.ToInt32(text.Substring(i, MAX_BLOCK_LENGTH), 16) - valorDaChave);
            return textDecifrado;
        }
    }
}
