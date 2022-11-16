/*Lesson 3. Task 6. �������� ���������, ������� �� ��������� ����
���������� ���� ������. ��������� �������� � ��������� ���� (���������� ��-������).*/

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
        //���������� ������� enter �� ���� �����
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKClick(buttonOK, e);
            }
        }
    } //end of: public partial class Form1 : Form
}