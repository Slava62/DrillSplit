using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DrillSplit.Lib;


namespace DrillSplit.Source
{
    public partial class DRSMain : Form
    {
        #region FormControls functions area*****************************

        /// <summary>
        /// Определения
        /// </summary>
        private Model model;

        /// <summary>
        /// Константы
        /// </summary>
        private const string FORM_CAPTIONBASE = "DrillSplitter : ";
        private const string APP_MESSAGECAPTION = "DrillSplitter";
        private const int FILE_DIALOG_PARAMS_COUNT = 3;

        /// <summary>
        /// Конструктор
        /// </summary>
        public DRSMain()
        {
            InitializeComponent();
            model = new Model();
            this.Text = FORM_CAPTIONBASE;
            txtCodeInsert.Text = model.getCodeToIncert();
            model.progress += this.statusRefresh;
            model.number += this.setMinSplitNumber;
        }
        /// <summary>
        /// Кнопка открыть файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string progTextString = "";
            Dictionary<byte, string> temp = Dialog.openNCFileM(APP_MESSAGECAPTION);
            if (temp.Count == FILE_DIALOG_PARAMS_COUNT)
            {
                this.Text = FORM_CAPTIONBASE + temp[0];
                progTextString = temp[1];
                txtProgText.Text = progTextString;
                model.setProgTextString(progTextString);
                tlStlblINFO.Text = temp[2];
                //***********************
                model.setOutProgToNull();
                //***********************

            }
        }
        /// <summary>
        /// копка разделить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplit_Click(object sender, EventArgs e)
        {
            progressTace.Maximum = 0;
            progressTace.Value = 0;
            try
            {
                if (model.splitProgram())
                {
                    if (cbxShowNC.Checked) txtProgText.Text = model.getOutProgAsString();
                    MessageBox.Show("Завершено", APP_MESSAGECAPTION,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, APP_MESSAGECAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// кнопка очистить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            formClear();
        }
        /// <summary>
        /// кнопка выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// кнопка сохраненния результатов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<byte, string> temp = Dialog.saveNCFileM(APP_MESSAGECAPTION, model.getOutProg());
            if (temp.Count == FILE_DIALOG_PARAMS_COUNT && cbxShowNC.Checked)
            {
                // показать результат если нужно
                this.Text = FORM_CAPTIONBASE + temp[0];
                txtProgText.Text = temp[1];
                tlStlblINFO.Text = temp[2];

            }
        }
        /// <summary>
        /// поле ввода кода вставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodeInsert_TextChanged(object sender, EventArgs e)
        {
            model.setCodeToIncert(txtCodeInsert.Text);
        }
        /// <summary>
        /// размер текста в окне
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void udpZum_ValueChanged(object sender, EventArgs e)
        {
            txtProgText.ZoomFactor = (float)udpZum.Value;
            txtProgText.Refresh();
        }
        /// <summary>
        /// количество кадров для резки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void udpSplit_NUM_ValueChanged(object sender, EventArgs e)
        {
            model.setSplitNumber((int)udpSplit_NUM.Value);
        }
        #endregion

        #region User functions area*****************************

        /// <summary>
        /// Очищаем форму
        /// </summary>
        private void formClear()
        {

            //  _ProgTextString = "";
            this.Text = FORM_CAPTIONBASE;
            txtProgText.Text = "";
            tlX.Text = "x";
            tlY.Text = "y";
            tlZ.Text = "z";
            tlR.Text = "r";
            tlQ.Text = "q";
            tlF.Text = "f";
            tlStlblINFO.Text = "parameters";
            progressTace.Value = 0;
            statusStrip1.Refresh();

        }
        /// <summary>
        /// Обновляем строку состояния в процессе разбиения
        /// </summary>
        private void statusRefresh(string x, string y, string z, string r, string q, string f, int i)
        {
            tlX.Text = x;
            tlY.Text = y;
            tlZ.Text = z;
            tlR.Text = r;
            tlQ.Text = q;
            tlF.Text = f;
            progressTace.Maximum = model.getProgressMax();
            progressTace.Value = i;
            statusStrip1.Refresh();
        }
        /// <summary>
        /// Изменяем значение количества блоков для разбиения на минимальное 
        /// </summary>
        private void setMinSplitNumber(int number)
        {
            udpSplit_NUM.Value = number;
        }

        #endregion









    }
}
