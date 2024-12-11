namespace WinFormStringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullname="", firstname="", lastname="", title="";
            int x = 0;
            //��ҵѴ Space ˹���ش�����ѧ�ش�͡
            fullname = txtFullname.Text.Trim();
            //��Ǩ�ͺ����դӹ�˹�ҷ���ͧ���������� "�ҧ���", "�ҧ", "���"
            if (fullname.StartsWith("�ҧ���"))
            {
                x = 6;       //���˹觷���ͧ����¡
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�ҧ")|| fullname.StartsWith("���"))
            {
                x = 3;       //���˹觷���ͧ����¡
                title = fullname.Substring(0, x);
            }
            fullname = fullname.Substring(x).Trim();
            //MessageBox.Show(title + "\n" + fullname);


            //�ҵ��˹觪�ͧ��ҧ�����ҧ�������ʡ��
            x = fullname.IndexOf(' ');
            //�Ѵ������Ƿ�� 0 ���֧���˹觪�ͧ��ҧ�������
            firstname = fullname.Substring(0, x).Trim();
            //�Ѵ�������˹觪�ͧ��ҧ 仨������ͤ���������ʡ��
            lastname = fullname.Substring(x).Trim();

            //�ʴ���� Textbox
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }
    }
}
