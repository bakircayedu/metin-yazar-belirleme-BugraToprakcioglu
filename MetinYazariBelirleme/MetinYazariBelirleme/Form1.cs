namespace MetinYazariBelirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Bir Dosya Seçiniz";
            openFileDialog1.FileName = "Dosya Seç";
            openFileDialog1.InitialDirectory = @"C:\Users\Bugra\Desktop\";            //ilk açýlacak dizini belirtiyoruz openfilediolog açýlýnca
            openFileDialog1.Filter = "Metin dosyalarý (.txt)|*.txt|Tüm dosyalar (.)|.";
        }

        private void btnUploadText_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                txtMetinYolu.Text = openFileDialog1.FileName;
                Metin+=System.IO.File.ReadAllText(openFileDialog1.FileName);

                //MessageBox.Show(Metin);

            }
        }
        string Metin = " ";
        Stack KelimeYigiti=new Stack();
        Stack CumleYigiti = new Stack();
        Stack BenzersizKelimeYigiti = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            btnHeap.Enabled = true;
            string cumle = "";
            int cumledekiKelimeSayisi = 0;
            foreach (var harf in Metin)
            {
                if (harf.ToString() == "\n")
                {
                    CumleYigiti.Push(cumle,cumledekiKelimeSayisi);
                    cumledekiKelimeSayisi = 0;

                    cumle = "";


                }
                else
                {
                    if (harf.ToString() == " ")
                    {
                        cumle += harf.ToString();
                        cumledekiKelimeSayisi++;
                    }
                    else
                    {
                        cumle += harf.ToString();
                    }

                }


            }
            CumleYigiti.Push(cumle, cumledekiKelimeSayisi);
            txtCumle.Text = CumleYigiti.cumleYazdir();

            string[] kelime_dizi = Metin.Split(' ');
            foreach (var kelime in kelime_dizi)
            {
                BenzersizKelimeYigiti.Push(kelime.ToLower(), cumledekiKelimeSayisi,true);
                KelimeYigiti.Push(kelime.ToLower(),cumledekiKelimeSayisi);
            }
            txtKelime.Text =KelimeYigiti.KelimeYazdir();
            txtFrekans.Text=KelimeYigiti.frekansYazdir();
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            Heap KelimeHeapTree = new Heap(KelimeYigiti.Size());

            for (int i= 0; i < KelimeYigiti.Size(); i++)
            {
                //KelimeHeapTree.Insert(KelimeYigiti.Pop());
            }
            btnYigitAktar.Visible = false;
            btnHash.Visible = true;
        }
    }
}