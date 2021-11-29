using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrillSplit.Source
{
    static class Dialog
    {

        /// <summary>
        /// вызывает окно диалога сохранения файла программы
        /// </summary>
        /// <param name="dialogCaption"> заголовок окна диалога</param>
        /// <returns>мапу с именем файла, содержимым и статус готово</returns>
        public static Dictionary<byte,string>  openNCFileM(string dialogCaption)
        {
            Dictionary<byte, string> result = new Dictionary<byte, string>();
            OpenFileDialog oDlg = new OpenFileDialog();
            oDlg.Title = dialogCaption + " : Выбор файла программы";
            oDlg.Filter = "Файлы NC |*.nc";
            oDlg.Multiselect = false;

            if (oDlg.ShowDialog() == DialogResult.OK)
            {
               string fileSelected = oDlg.FileName;
                try
                {

                    StreamReader fReader = new StreamReader(new FileStream(fileSelected, FileMode.Open));
                    string temp = fReader.ReadToEnd();
                    fReader.Close();
                    result.Add(0, fileSelected);
                    result.Add(1, temp);
                    result.Add(2, "Opened");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, dialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
            }
            else
            {
                MessageBox.Show("Укажите NC файл", dialogCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            return result;

        }

        /// <summary>
        /// вызывает окно диалога сохранения файла программы
        /// </summary>
        /// <param name="dialogCaption"> заголовок окна диалога</param>
        /// <param name="outProg"> список с порезанной программой</param>
        /// <returns>мапу с именем файла, содержимым и статус готово</returns>
        public static Dictionary<byte, string> saveNCFileM(string dialogCaption, List<string> outProg)
        {
            Dictionary<byte, string> result = new Dictionary<byte, string>();
            string fileSelected = "";
            if (outProg != null)
            {

                SaveFileDialog sDlg = new SaveFileDialog();
                sDlg.Title = dialogCaption + " : Сохранение файла программы";
                sDlg.Filter = "Файлы NC |*.nc";

                if (sDlg.ShowDialog() == DialogResult.OK)
                {
                    fileSelected = sDlg.FileName;
                    try
                    {
                        StreamWriter fWriter = new StreamWriter(new FileStream(fileSelected, FileMode.Create));
                        StringBuilder temp = new StringBuilder();
                        foreach (string s in outProg)
                        {
                            fWriter.Write(s);
                            temp.Append(s);
                            if (!s.Contains('\n'))
                            {
                                fWriter.Write("\n"); temp.Append("\n");
                            }
                        }
                        fWriter.Close();
                        result.Add(0, fileSelected);
                        result.Add(1, temp.ToString());
                        result.Add(2, "Ready");
                        MessageBox.Show("Файл успешно сохранен!", dialogCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, dialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Не выбран файл для сохранения!!", dialogCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return result;
        }

    }
}

