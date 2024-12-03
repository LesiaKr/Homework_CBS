using System;

namespace Dictionary
{
    class Dictionary
    {
        private string[] ukrKey = new string[5];
        private string[] englishValue = new string[5];
        private string[] polishValue = new string[5];

        public Dictionary()
        {
            ukrKey[0] = "книга"; englishValue[0] = "book"; polishValue[0] = "książka";
            ukrKey[1] = "ручка"; englishValue[1] = "pen"; polishValue[1] = "długopis";
            ukrKey[2] = "сонце"; englishValue[2] = "sun"; polishValue[2] = "słońce";
            ukrKey[3] = "яблуко"; englishValue[3] = "apple"; polishValue[3] = "jabłko";
            ukrKey[4] = "стіл"; englishValue[4] = "table"; polishValue[4] = "stół";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < ukrKey.Length; i++)
                    if (ukrKey[i] == index || englishValue[i] == index || polishValue[i] == index)
                        return ukrKey[i] + " - " + englishValue[i] + " - " + polishValue[i];

                return string.Format("{0} - немає перекладу для цього слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < ukrKey.Length)
                    return ukrKey[index] + " - " + englishValue[index] + " - " + polishValue[index];
                else
                    return "Спроба звернення за межі масиву.";
            }
        }
    }
}