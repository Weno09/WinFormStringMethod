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
            //ถ้าตัด Space หน้าสุดและหลังสุดออก
            fullname = txtFullname.Text.Trim();
            //ตรวจสอบว่ามีคำนำหน้าที่ต้องการหรือไม่ "นางสาว", "นาง", "นาย"
            if (fullname.StartsWith("นางสาว"))
            {
                x = 6;       //ตำแหน่งที่ต้องการแยก
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("นาง")|| fullname.StartsWith("นาย"))
            {
                x = 3;       //ตำแหน่งที่ต้องการแยก
                title = fullname.Substring(0, x);
            }
            fullname = fullname.Substring(x).Trim();
            //MessageBox.Show(title + "\n" + fullname);


            //หาตำแหน่งช่องว่างระหว่างชื่อและสกุล
            x = fullname.IndexOf(' ');
            //ตัดตั้งแต่ตัวที่ 0 จนถึงตำแหน่งช่องว่างจะได้ชื่อ
            firstname = fullname.Substring(0, x).Trim();
            //ตัดตั้งแต่ตำแหน่งช่องว่าง ไปจนหมดข้อความจะได้นามสกุล
            lastname = fullname.Substring(x).Trim();

            //แสดงผลใน Textbox
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }
    }
}
