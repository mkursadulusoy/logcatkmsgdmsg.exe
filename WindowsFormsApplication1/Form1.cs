using System.IO;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test işleminiz bitince logcat yazılımı durdurmak için ctrl+c tuşuna basın.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var logcat = Process.Start("CMD.exe", "/c adb logcat > logcat.txt");
            logcat.WaitForExit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cihazınızı FastBoot moduna alıp( Power tuşu + Ses kısma tuşu) Tamam' a basınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var recotwrp = Process.Start("CMD.exe", "/c fastboot flash recovery TWRP_286_Elite.img");
            recotwrp.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cihazınızı FastBoot moduna alıp( Power tuşu + Ses kısma tuşu) Tamam' a basınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var recostock = Process.Start("CMD.exe", "/c fastboot flash recovery Elite-Recovery.img");
            recostock.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu seçenek sonucunda oluşan kmesg.txt dosyası telefonunuzun sdcard kısmında olacaktır.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var kmsg = Process.Start("CMD.exe", "/c adb shell cat /proc/kmsg > /sdcard/kmsg.txt");
            kmsg.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu seçenek sonucu oluşan dmesg.txt dosyası telefonunuzun sdcard kısmında olacaktır.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var dmesg = Process.Start("CMD.exe", "/c adb shell dmesg > /sdcard/dmesg.txt");
            dmesg.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu seçenek sadece TWRP recovery yüklü ise çalışır. Yükleme sonucunda sdcardınızda oluşan UPDATE-SuperSU-v2.46.zip dosyasını TWRP recovery instal seçeneği ile flashlayınız. .", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var root = Process.Start("CMD.exe", "/c adb push UPDATE-SuperSU-v2.46.zip /sdcard/");
            root.WaitForExit();
        }
    }
}
