using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace DrillSplit.Lib
{
    public class Model
    {
        /// <summary>
        /// Определения
        /// </summary>
        private string progTextString = "";
        List<string> outProg = null;
        private int splitNumber = 10;
        private string codeToIncert = "G80|G00 Z200.|M09|M05|M1|S|M08|Zsf";

        /// <summary>
        /// коды NC программы
        /// </summary>
        private string x = "";
        private string y = "";
        private string z = "";
        private string r = "";
        private string q = "";
        private string f = "";

        private string s = "";
        private string zsafe = "";
        private string n = "";
        private int progressMax = 0;

        private const char CODE_INSERT_SEARATOR = '|';
        /// <summary>
        /// Установить количество блоков для разделения
        /// </summary>
        /// <returns></returns>
        public void setSplitNumber(int value)
        {
            int temp = (codeToIncert.Split(new Char[] { '|' })).Length;
            if (value > temp && value > 2)
            {
                splitNumber = value;
            }
            else
            {
                if (temp <= 2) { splitNumber = 3; number(3); }
                else { splitNumber = temp + 1; number(temp + 1); }
            }
        }
        /// <summary>
        /// Установить NC блок кода для вставки при разделении
        /// </summary>
        /// <returns></returns>
        public void setCodeToIncert(string value) { codeToIncert = value; }
        public string getCodeToIncert() { return codeToIncert; }
        /// <summary>
        /// Список с содержимым разделенного файла
        /// </summary>
        /// <returns></returns>
        public List<string> getOutProg() { return outProg; }
        public void setOutProgToNull() { outProg = null; }
        /// <summary>
        /// Строка исходного файла
        /// </summary>
        /// <returns></returns>
        public void setProgTextString(string progTextString) { this.progTextString = progTextString; }
        /// <summary>
        /// Максимальное значение прогдесса выполнения
        /// </summary>
        /// <returns></returns>
        public int getProgressMax() { return progressMax; }
        /// <summary>
        /// Результат разделенного файла в виде строки
        /// </summary>
        /// <returns></returns>
        public string getOutProgAsString()
        {
            StringBuilder temp = new StringBuilder();
            foreach (string s in outProg)
            {
                temp.Append(s);
                if (!s.Contains('\n')) temp.Append("\n");
            }
            return temp.ToString();
        }

        /// <summary>
        /// Разделить программу
        /// </summary>
        /// <returns></returns>
        public bool splitProgram()
        {
            try
            {

                if (progTextString != "")
                {
                    outProg = new List<string>();
                    string[] lines = progTextString.Split(new Char[] { '\n' });
                    if (lines.Length > 0) progressMax = lines.Length - 1;

                    for (int i = 0; i < lines.Length - 1; i++)
                    {

                        if (contanesGCode("S", lines[i]))
                        {
                            s = getElemByCode("S", lines[i]);
                        }
                        if (contanesGCode("H", lines[i]))
                        {
                            zsafe = getElemByCode("Z", lines[i]);
                        }
                        if (contanesGCode("G81", lines[i]))
                        {
                            codeNullValue();
                            int j = 0;
                            while (!contanesGCode("G80", lines[i]))
                            {

                                traceCode(lines[i], i);

                                outProg.Add(lines[i]);

                                if (j < splitNumber - 1)
                                {
                                    j++;
                                }
                                else
                                {
                                    i++;
                                    traceCode(lines[i], i);
                                    splitInsertString(CODE_INSERT_SEARATOR, codeToIncert);
                                    outProg.Add(n + " " + "G98 G81 " + x + " "
                                        + y + " " + z + " " + r + " " + f + "\r");
                                    j = 0;
                                }

                                i++;
                            }
                        }
                        if (contanesGCode("G83", lines[i]))
                        {
                            codeNullValue();
                            int j = 0;
                            while (!contanesGCode("G80", lines[i]))
                            {

                                traceCode(lines[i], i);

                                outProg.Add(lines[i]);

                                if (j < splitNumber - 1)
                                {
                                    j++;
                                }
                                else
                                {
                                    i++;
                                    traceCode(lines[i], i);
                                    splitInsertString(CODE_INSERT_SEARATOR, codeToIncert);
                                    outProg.Add(n + " " + "G98 G83 " + x + " "
                                        + y + " " + z + " " + r + " " + q + " " + f + "\r");
                                    j = 0;
                                }

                                i++;
                            }
                        }
                        outProg.Add(lines[i]);

                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Трассировка значений x y z и тд.
        /// </summary>
        /// <param name="prLine">строка для трассировки</param>
        /// <returns></returns>
        private bool traceCode(string prLine, int i)
        {

            x = getElemByCode("X", prLine);
            y = getElemByCode("Y", prLine);
            z = getElemByCode("Z", prLine);
            q = getElemByCode("Q", prLine);
            f = getElemByCode("F", prLine);
            r = getElemByCode("R", prLine);
            n = getElemByCode("N", prLine);
            progress(x, y, z, r, q, f, i);

            return true;
        }

        /// <summary>
        /// Получить подстроку по коду (например x=X-15.145)
        /// </summary>
        /// <param name="CodeSimbol">что искать (например "X")</param>
        /// <param name="TraceLine">строка  поиска (например N152 X-15.145 Y0.0 Z-20.5)</param>
        /// <param name="Elem">куда сохранить значение (например ref x)</param>
        private string getElemByCode(string CodeSimbol, string TraceLine)
        {
            if (TraceLine.Contains(CodeSimbol))
            {
                int start = TraceLine.IndexOf(CodeSimbol);
                int rowend = TraceLine.IndexOf('\r');
                int end = TraceLine.IndexOfAny(new Char[] { ' ', '\r' }, start, rowend - start + 1);
                return TraceLine.Substring(start, end - start);
            }
            //??????????????
            return "";

        }
        /// <summary>
        /// проверяет наличие G-кода в строке
        /// </summary>
        /// <param name="GCode">G-код (например "G81")</param>
        /// <param name="prLine">строка</param>
        /// <returns>найден - да/ не найден - нет</returns>
        private bool contanesGCode(string GCode, string prLine)
        {
            if (prLine.Contains(GCode))
            {
                return true;
            }
            else
            { return false; }
        }
        /// <summary>
        /// обнуляет значения кодов программы x=""...z=""
        /// </summary>
        private void codeNullValue()
        {
            x = "";
            y = "";
            z = "";
            r = "";
            q = "";
            f = "";
            n = "";
        }
        /// <summary>
        /// разбивает строку вставляемого блока
        /// и добавляет элементы в массив
        /// </summary>
        /// <param name="Separator">разделитель строк (например '|')</param>
        /// <param name="Line">строка</param>
        /// <returns>количество часте</returns>
        private int splitInsertString(char Separator, string Line)
        {
            int i = 0;
            if (outProg != null)
            {
                // Line = Line.ToUpper();
                if (Line != "" && Line.Contains("G80"))
                {
                    string[] SplittedLine = Line.Split(Separator);
                    foreach (string str in SplittedLine)
                    {
                        if (str.Contains('S'))
                        {
                            outProg.Add(s + " M03\r");
                        }
                        else
                        {

                            if (str.Contains("Zsf"))
                            {
                                outProg.Add(zsafe + "\r");
                            }
                            else
                            {
                                outProg.Add(str + "\r");
                            }
                        }
                        i++;
                    }
                }
                else
                {
                    outProg.Add("G80\r");
                    outProg.Add("G00 Z100. M1.\r");
                    i = 2;
                }
            }
            return i;
        }

        public delegate void SplitNumberHandler(int minSplitNumber);
        public event SplitNumberHandler number;

        public delegate void ModelHandler(string x, string y, string z, string r, string q, string f, int i);
        public event ModelHandler progress;
    }
}
