/*Lesson 3. Task 6. �������� ���������, ������� �� ��������� ����
���������� ���� ������. ��������� �������� � ��������� ���� (���������� ��-������).*/

namespace WeekdayByDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //inputTextBox.Enter += TextBoxEnter;
            //inputTextBox.Enter += TextBoxEnter;

            buttonOK.Click += OKClick;
            buttonClear.Click += ClearClick;
        }

        //���������� ������� enter �� ����� ����� ??????
        private void TextBoxEnter(object sender, EventArgs e)
        {
            inputTextBox.BackColor = Color.White;
        }

        //���������� ������ OK
        private void OKClick(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "") //���� � ���� ������ �� �������
            {
                resultTextBox.Text = //������. ����-� dateTimePicker � ������ ��� ������
                    dateTimePicker.Value.Date.ToString("dddd").ToUpper();
                //� htpekmnfn ������� ��������� � ������ ���� � �������� ������� (dd.mm.yyyy):
                inputTextBox.Text = dateTimePicker.Value.ToShortDateString();
            }
            else
            {
                try
                {
                    DateTime day = new DateTime();
                    //����������� �������� ����� �� ����� � ������� DateTime:
                    day = DateTime.Parse(inputTextBox.Text);
                    //� ��������� ������� �������������� ���� � ������� ��� ������:
                    resultTextBox.Text = day.ToString("dddd").ToUpper();
                    //���������� ����� �� ��������� ����:
                    dateTimePicker.Value = day;
                }
                catch(Exception)
                {                    
                    MessageBox.Show("�������� ������ ����!", "������",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    inputTextBox.BackColor = Color.LightCoral;
                }
            } //end of: else
        } //end of: private void OKClick()
        
        //���������� ������ CLEAR 
        private void ClearClick(object sender, EventArgs e)
        {
            inputTextBox.Clear(); //������� ���� �����
            resultTextBox.Clear(); //������� ���� ������
            inputTextBox.BackColor = Color.White; //��� ���� ����� ������� ����� �����
            dateTimePicker.Value = DateTime.Now; //����� ���� ���������� �� treobq ����
        }

    } //end of: public partial class Form1 : Form
}