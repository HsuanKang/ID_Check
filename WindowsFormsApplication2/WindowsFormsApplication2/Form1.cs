using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int check_no;
        string noHead = "";

        string strict = "";
        int st_num = 0;
        string gender = "";
        int st_check = 0;
        string foreiGenNo = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //身分證產生
        private void button4_Click(object sender, EventArgs e)
        {
            no_text.Clear();

            CheckNo(district_cb.SelectedIndex.ToString());

            if (district_cb.SelectedIndex == -1)             //隨機產生第一碼
            {
                int[] disArray = new int[1];
                Random disNo = new Random();
                for (int i = 0; i < disArray.Length; i++)
                {
                    disArray[i] = disNo.Next(0, 26);
                    string dis = disArray[i].ToString();
                    CheckNo(dis);
                }
            }

            string random_No = "";

            int[] randomArray = new int[7];
            Random no = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = no.Next(1, 9);
                random_No += randomArray[i].ToString();
            }

            if (rb_1.Checked)
            {
                gender = "1";

            }
            else if (rb_2.Checked)
            {
                gender = "2";
            }
            else
            {
                int[] genderArray = new int[1];                //隨機產生第二碼
                Random genderNo = new Random();
                for (int i = 0; i < genderArray.Length; i++)
                {
                    genderArray[i] = genderNo.Next(1, 3);
                    gender = genderArray[i].ToString();
                }
            }


            check_no = (st_check + Convert.ToInt32(gender) * 8 +
                                   randomArray[0] * 7 +
                                   randomArray[1] * 6 +
                                   randomArray[2] * 5 +
                                   randomArray[3] * 4 +
                                   randomArray[4] * 3 +
                                   randomArray[5] * 2 +
                                   randomArray[6] * 1) % 10;

            if (check_no == 0)
            {
                check_no = 0;
            }
            else
            {
                check_no = 10 - check_no;
            }

            string checkNoString = Convert.ToString(check_no);
            no_text.Text += strict + gender + random_No + checkNoString;
        }

        //身分證驗證
        private void insert_but_Click(object sender, EventArgs e)
        {
            if (no_text.Text == "")
            {
                MessageBox.Show("請先產生號碼");
            }
            else
            {
                char[] arr;
                arr = no_text.Text.ToCharArray(1, 9);
                int[] arr1 = new int[9];

                for (int i = 0; i < arr.Length; i++)
                {
                    int s = 0;
                    s = (int)Char.GetNumericValue(arr[i]);
                    arr1[i] = s;
                }

                noHead = no_text.Text.Substring(0, 1);
                CheckNo(noHead);

                check_no = (st_check + arr1[0] * 8 +
                                       arr1[1] * 7 +
                                       arr1[2] * 6 +
                                       arr1[3] * 5 +
                                       arr1[4] * 4 +
                                       arr1[5] * 3 +
                                       arr1[6] * 2 +
                                       arr1[7] * 1) % 10;
                if (check_no == 0)
                {
                    check_no = 0;
                }
                else
                {
                    check_no = 10 - check_no;
                }

                if (arr1[8] == check_no)
                {
                    MessageBox.Show("驗證正確");
                }
                else
                {
                    MessageBox.Show("檢查碼錯誤");
                }
                if (arr1[0] != 1 && arr1[0] != 2)
                {
                    MessageBox.Show("第二碼錯誤");
                }
            }

        }

        //統一編號驗證
        private void check_btn_Click(object sender, EventArgs e)
        {
            if (show_text.Text == "")
            {
                MessageBox.Show("請先產生編號");
            }
            else
            {
                string code = show_text.Text;
                char[] arr;
                arr = code.ToCharArray(0, 8);
                int[] arrNum = new int[8];
                int x = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int s = 0;
                    s = (int)Char.GetNumericValue(arr[i]);
                    arrNum[i] = s;
                }

                if (arrNum[6] == 7)
                {
                    GetEx(arrNum);
                }
                else
                {
                    int ten = GetTen(arrNum);
                    int digits = GetDigits(arrNum);

                    x = (ten + digits + arrNum[7]) % 10;
                }

                if (x == 0)
                {
                    MessageBox.Show("符合驗證");
                }
                else
                {
                    MessageBox.Show("不符驗證");
                }

                show_text.Clear();
            }

        }

        //統一編號產生
        private void new_btn_Click(object sender, EventArgs e)
        {
            string randomNo = "";
            int[] randomArray = new int[7];
            Random no = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = no.Next(1, 9);
                randomNo += randomArray[i].ToString();
            }

            int noLast = 0;

            if (randomArray[6] == 7)
            {
                int w = GetExRandom(randomArray) % 10;
                if (w == 0)
                {
                    noLast = 0;
                }
                else
                {
                    noLast = 10 - w;                        //檢查碼處理
                }
            }
            else
            {
                int ten = GetTen(randomArray);
                int digit = GetDigits(randomArray);
                int s = (ten + digit) % 10;
                if (s == 0)
                {
                    noLast = 0;
                }
                else
                {
                    noLast = 10 - s;                        //檢查碼處理
                }
            }

            show_text.Text = randomNo + noLast.ToString();
        }


        //統一證號產生
        private void sub_C_Click(object sender, EventArgs e)
        {
            string foreiStriNo = "";
            string foreiNo = "";
            int secondNo = 0;
            int x = 0;

            if (district_cb.SelectedIndex == -1)
            {
                int[] firstNoArray = new int[1];
                Random StartNo = new Random();
                for (int i = 0; i < firstNoArray.Length; i++)
                {
                    firstNoArray[i] = StartNo.Next(0, 26);
                    foreiStriNo = firstNoArray[i].ToString();
                    CheckNo(foreiStriNo);
                }

            }
            else
            {
                CheckNo(district_cb.SelectedIndex.ToString());
            }


            if (rb_1.Checked && rb_3.Checked)                     //統一證號第二碼
            {
                foreiGenNo = "A";
                secondNo = 0;
            }
            else if (rb_1.Checked && rb_4.Checked)
            {
                foreiGenNo = "C";
                secondNo = 2;
            }
            else if (rb_2.Checked && rb_3.Checked)
            {
                foreiGenNo = "B";
                secondNo = 1;
            }
            else if (rb_2.Checked && rb_4.Checked)
            {
                foreiGenNo = "D";
                secondNo = 3;
            }
            else
            {
                int[] firstNoArray = new int[1];
                Random startNo = new Random();
                for (int i = 0; i < firstNoArray.Length; i++)
                {
                    firstNoArray[i] = startNo.Next(65, 69);
                    char z = (char)firstNoArray[i];
                    foreiGenNo = z.ToString();
                    x = SecondNo(foreiGenNo);
                }
            }

            int[] randomNoArray = new int[7];
            Random foreiRandom = new Random();
            for (int i = 0; i < randomNoArray.Length; i++)
            {
                randomNoArray[i] = foreiRandom.Next(0, 9);
                foreiNo += randomNoArray[i].ToString();
            }

            int m = 0;
            m = st_num / 10;
            int k = 0;
            k = (st_num % 10) * 9;
            int n = 0;
            n = k % 10;

            int foreiCheckNo = (m + n +
                                    (x * 8) % 10 +
                                    (randomNoArray[0] * 7) % 10 +
                                    (randomNoArray[1] * 6) % 10 +
                                    (randomNoArray[2] * 5) % 10 +
                                    (randomNoArray[3] * 4) % 10 +
                                    (randomNoArray[4] * 3) % 10 +
                                    (randomNoArray[5] * 2) % 10 +
                                    (randomNoArray[6] * 1) % 10) % 10;
            if (foreiCheckNo == 0)
            {
                foreiCheckNo = 0;
            }
            else
            {
                foreiCheckNo = 10 - foreiCheckNo;
            }
            string foreignerNo = strict + foreiGenNo + foreiNo + foreiCheckNo.ToString();
            forei_text.Text = foreignerNo;
        }


        // 統一證號驗證
        private void insert_forei_Click(object sender, EventArgs e)
        {
            if (forei_text.Text == "")
            {
                MessageBox.Show("請先產生證號");
            }
            else
            {
                string code = forei_text.Text;
                char[] arr;
                arr = code.ToCharArray(0, 10);
                int[] arrNum = new int[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    int s = 0;
                    s = (int)Char.GetNumericValue(arr[i]);
                    arrNum[i] = s;
                }

                CheckNo(arr[0].ToString());
                int w = SecondNo(arr[1].ToString());

                int m = 0;
                m = st_num / 10;
                int k = 0;
                k = (st_num % 10) * 9;
                int n = 0;
                n = k % 10;
                int check = (m + n +
                                    (w * 8) % 10 +
                                    (arrNum[2] * 7) % 10 +
                                    (arrNum[3] * 6) % 10 +
                                    (arrNum[4] * 5) % 10 +
                                    (arrNum[5] * 4) % 10 +
                                    (arrNum[6] * 3) % 10 +
                                    (arrNum[7] * 2) % 10 +
                                    (arrNum[8] * 1) % 10) % 10;
                int checkNo = 0;
                if (check == 0)
                {
                    checkNo = 0;
                }
                else
                {
                    checkNo = 10 - check;
                }

                if (arrNum[9] == checkNo)
                {
                    MessageBox.Show("符合驗證");
                }
                else
                {
                    MessageBox.Show("不符驗證");
                }

            }
        }



        //身分證選單
        public int CheckNo(string x)
        {
            if (x == "0" || x == "A")
            {
                strict = "A";
                st_num = 10;
                st_check = (0 * 9 + 1) % 10;
            }
            else if (x == "1" || x == "B")
            {
                strict = "B";
                st_num = 11;
                st_check = (1 * 9 + 1) % 10;
            }
            else if (x == "2" || x == "C")
            {
                strict = "C";
                st_num = 12;
                st_check = (2 * 9 + 1) % 10;
            }
            else if (x == "3" || x == "D")
            {
                strict = "D";
                st_num = 13;
                st_check = (3 * 9 + 1) % 10;
            }
            else if (x == "4" || x == "E")
            {
                strict = "E";
                st_num = 14;
                st_check = (4 * 9 + 1) % 10;
            }
            else if (x == "5" || x == "F")
            {
                strict = "F";
                st_num = 15;
                st_check = (5 * 9 + 1) % 10;
            }
            else if (x == "6" || x == "G")
            {
                strict = "G";
                st_num = 16;
                st_check = (6 * 9 + 1) % 10;
            }
            else if (x == "7" || x == "H")
            {
                strict = "H";
                st_num = 17;
                st_check = (7 * 9 + 1) % 10;
            }
            else if (x == "8" || x == "I")
            {
                strict = "I";
                st_num = 34;
                st_check = (4 * 9 + 3) % 10;
            }
            else if (x == "9" || x == "J")
            {
                strict = "J";
                st_num = 18;
                st_check = (8 * 9 + 1) % 10;
            }
            else if (x == "10" || x == "K")
            {
                strict = "K";
                st_num = 19;
                st_check = (9 * 9 + 1) % 10;
            }
            else if (x == "11" || x == "M")
            {
                strict = "M";
                st_num = 21;
                st_check = (1 * 9 + 2) % 10;
            }
            else if (x == "12" || x == "N")
            {
                strict = "N";
                st_num = 22;
                st_check = (2 * 9 + 2) % 10;
            }
            else if (x == "13" || x == "O")
            {
                strict = "O";
                st_num = 35;
                st_check = (5 * 9 + 3) % 10;
            }
            else if (x == "14" || x == "P")
            {
                strict = "P";
                st_num = 23;
                st_check = (3 * 9 + 2) % 10;
            }
            else if (x == "15" || x == "Q")
            {
                strict = "Q";
                st_num = 24;
                st_check = (4 * 9 + 2) % 10;
            }
            else if (x == "16" || x == "T")
            {
                strict = "T";
                st_num = 27;
                st_check = (7 * 9 + 2) % 10;
            }
            else if (x == "17" || x == "U")
            {
                strict = "U";
                st_num = 28;
                st_check = (8 * 9 + 2) % 10;
            }
            else if (x == "18" || x == "V")
            {
                strict = "V";
                st_num = 29;
                st_check = (9 * 9 + 2) % 10;
            }
            else if (x == "19" || x == "W")
            {
                strict = "W";
                st_num = 32;
                st_check = (2 * 9 + 3) % 10;
            }
            else if (x == "20" || x == "X")
            {
                strict = "X";
                st_num = 30;
                st_check = (0 * 9 + 3) % 10;
            }
            else if (x == "21" || x == "Z")
            {
                strict = "Z";
                st_num = 33;
                st_check = (3 * 9 + 3) % 10;
            }
            else if (x == "22" || x == "L")
            {
                strict = "L";
                st_num = 20;
                st_check = (0 * 9 + 2) % 10;
            }
            else if (x == "23" || x == "R")
            {
                strict = "R";
                st_num = 25;
                st_check = (5 * 9 + 2) % 10;
            }
            else if (x == "24" || x == "S")
            {
                strict = "S";
                st_num = 26;
                st_check = (6 * 9 + 2) % 10;
            }
            else if (x == "25" || x == "Y")
            {
                strict = "Y";
                st_num = 31;
                st_check = (1 * 9 + 3) % 10;
            }

            return st_num;
        }

        //隨機產生取得七碼十位相加
        public int GetTen(int[] array)
        {
            int result1 = (array[0] * 1) / 10 +
                           (array[1] * 2) / 10 +
                           (array[2] * 1) / 10 +
                           (array[3] * 2) / 10 +
                           (array[4] * 1) / 10 +
                           (array[5] * 2) / 10 +
                           (array[6] * 4) / 10;

            return result1;
        }

        //隨機產生取得七碼個位相加
        public int GetDigits(int[] array)
        {
            int result2 = (array[0] * 1) % 10 +
                            (array[1] * 2) % 10 +
                            (array[2] * 1) % 10 +
                            (array[3] * 2) % 10 +
                            (array[4] * 1) % 10 +
                            (array[5] * 2) % 10 +
                            (array[6] * 4) % 10;

            return result2;
        }

        //隨機產生第七碼例外處理
        public int GetExRandom(int[] arr)
        {
            int m = (arr[6] * 4 / 10);
            int k = (arr[6] * 4 % 10);
            int a = (m + k) / 10;
            int b = (m + k) % 10;

            int result1 = (arr[0] * 1) / 10 +
                          (arr[1] * 2) / 10 +
                          (arr[2] * 1) / 10 +
                          (arr[3] * 2) / 10 +
                          (arr[4] * 1) / 10 +
                          (arr[5] * 2) / 10 +
                          a;

            int result2 = (arr[0] * 1) % 10 +
                          (arr[1] * 2) % 10 +
                          (arr[2] * 1) % 10 +
                          (arr[3] * 2) % 10 +
                          (arr[4] * 1) % 10 +
                          (arr[5] * 2) % 10 +
                          b;

            int x = (result1 + result2) % 10;

            return x;
        }

        //第七碼例外處理
        public int GetEx(int[] arr)
        {
            int m = (arr[6] * 4 / 10);
            int k = (arr[6] * 4 % 10);
            int a = (m + k) / 10;
            int b = (m + k) % 10;

            int result1 = (arr[0] * 1) / 10 +
                          (arr[1] * 2) / 10 +
                          (arr[2] * 1) / 10 +
                          (arr[3] * 2) / 10 +
                          (arr[4] * 1) / 10 +
                          (arr[5] * 2) / 10 +
                          a +
                          (arr[7] * 1) / 10;

            int result2 = (arr[0] * 1) % 10 +
                          (arr[1] * 2) % 10 +
                          (arr[2] * 1) % 10 +
                          (arr[3] * 2) % 10 +
                          (arr[4] * 1) % 10 +
                          (arr[5] * 2) % 10 +
                          b +
                          (arr[7] * 1) % 10;

            int x = (result1 + result2) % 10;

            return x;
        }

        //統一證號性別碼
        public int SecondNo(string z)
        {
            int sNo = 0;

            if (z == "A")
            {
                sNo = 0;
            }
            else if (z == "B")
            {
                sNo = 1;
            }
            else if (z == "C")
            {
                sNo = 2;
            }
            else if (z == "D")
            {
                sNo = 3;
            }

            return sNo;
        }
    }
}
