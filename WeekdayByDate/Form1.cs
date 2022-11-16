/*Lesson 3. Task 6. Написать программу, которая по введенной дате
определяет день недели. Результат выводить в текстовое поле (желательно по-русски).*/

namespace WeekdayByDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonOK.Click += OKClick;
            buttonClear.Click += ClearClick;
           //inputTextBox.KeyDown += new KeyEventHandler(inputTextBox_KeyDown);
            inputTextBox.KeyDown += inputTextBox_KeyDown;
        }        

        //обработчик кнопки OK
        private void OKClick(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "") //если в бокс ничего не введено
            {
                resultTextBox.Text = //преобр. знач-я dateTimePicker к полнму дню недели
                    dateTimePicker.Value.Date.ToString("dddd").ToUpper();
                //в htpekmnfn вывести выбранную в пикере дату в коротком формате (dd.mm.yyyy):
                inputTextBox.Text = dateTimePicker.Value.ToShortDateString();
            }
            else
            {
                try
                {
                    DateTime day = new DateTime();
                    //попробовать спарсить текст из бокса к объекту DateTime:
                    day = DateTime.Parse(inputTextBox.Text);
                    //в результат вывести преобразование даты к полному дню недели:
                    resultTextBox.Text = day.ToString("dddd").ToUpper();
                    //установить пикер на введенной дате:
                    dateTimePicker.Value = day;
                }
                catch(Exception)
                {                    
                    MessageBox.Show("Неверный формат даты!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    inputTextBox.BackColor = Color.LightCoral;
                }
            } //end of: else
        } //end of: private void OKClick()
        
        //обработчик кнопки CLEAR 
        private void ClearClick(object sender, EventArgs e)
        {
            inputTextBox.Clear(); //очистка поля ввода
            resultTextBox.Clear(); //очистка поля вывода
            inputTextBox.BackColor = Color.White; //фон поля ввода сделать снова белым
            dateTimePicker.Value = DateTime.Now; //пикер даты установить на treobq день
        }
        //обработчик нажатия enter на поле ввода
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKClick(buttonOK, e);
            }
        }
    } //end of: public partial class Form1 : Form
}