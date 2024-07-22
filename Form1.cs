using static System.Formats.Asn1.AsnWriter;

namespace Game_KEOBUABAO
{
    public partial class Form1 : Form
    {

        int Round = 1;
        int Score = 0;
        String AIchoise = "";
        String NguoiChoise = "";

        public Form1()
        {
            InitializeComponent();
        }

        /*Hàm tạo ra 3 số ngẫu nhiên, ròi chia vào chuỗi*/
        private void RandomNum()
        {
            Random random = new Random();
            int num = random.Next(1, 4);

            switch (num)
            {
                case 1:
                    AIchoise = "Kéo";
                    break;
                case 2:
                    AIchoise = "Búa";
                    break;
                case 3:
                    AIchoise = "Bao";
                    break;
            }
        }


        /*3 hàm thắng, thua, hòa*/
        private void Thang()
        {
            Score++;
            KetQuaTxt.Text = ("Bạn Thắng rồi");
            ScoreBtn.Text = "Score: " + Score;
        }

        private void Thua()
        {
            KetQuaTxt.Text = ("Bạn thua rồi!!!");
        }

        private void Hoa()
        {
            KetQuaTxt.Text = ("Hòa nhé.");
        }



        private void KeoBtn_Click(object sender, EventArgs e)
        {
            KeoBtn.BackColor = Color.White;
            BuaBtn.BackColor = Color.White;
            BaoBtn.BackColor = Color.White;
            NguoiChoise = "Kéo";
            RandomNum();

            if (NguoiChoise == AIchoise)
            {
                Hoa();
                KeoBtn.BackColor = Color.MediumVioletRed;
            }
            if (AIchoise == "Búa")
            {
                Thua();
                BuaBtn.BackColor = Color.Red;
            }
            if (AIchoise == "Bao")
            {
                Thang();
                BaoBtn.BackColor = Color.Yellow;
            }
            Round++;
            RoundLbl.Text = ("Round: " + Round).ToString();

        }



        private void BuaBtn_Click(object sender, EventArgs e)
        {
            KeoBtn.BackColor = Color.White;
            BuaBtn.BackColor = Color.White;
            BaoBtn.BackColor = Color.White;
            NguoiChoise = "Búa";
            RandomNum();

            if (NguoiChoise == AIchoise)
            {
                Hoa();
                BuaBtn.BackColor = Color.MediumVioletRed;
            }
            if (AIchoise == "Bao")
            {
                Thua();
                BaoBtn.BackColor = Color.Red;
            }
            if (AIchoise == "Kéo")
            {
                Thang();
                KeoBtn.BackColor = Color.Yellow;
            }
            Round++;
            RoundLbl.Text = ("Round: " + Round).ToString();
        }

        private void BaoBtn_Click(object sender, EventArgs e)
        {
            KeoBtn.BackColor = Color.White;
            BuaBtn.BackColor = Color.White;
            BaoBtn.BackColor = Color.White;
            NguoiChoise = "Bao";
            RandomNum();

            if (NguoiChoise == AIchoise)
            {
                Hoa();
                BaoBtn.BackColor = Color.MediumVioletRed;
            }
            if (AIchoise == "Kéo")
            {
                Thua();
                KeoBtn.BackColor = Color.Red;
            }
            if (AIchoise == "Búa")
            {
                Thang();
                BuaBtn.BackColor = Color.Yellow;
            }
            Round++;
            RoundLbl.Text = ("Round: " + Round).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
