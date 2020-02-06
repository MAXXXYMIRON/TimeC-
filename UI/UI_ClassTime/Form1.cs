using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ClassTime
{
    public partial class WinTime : Form
    {
        public WinTime()
        {
            InitializeComponent();
        }

        Time.Time t1, t2;
        private bool MakeVarsTime()
        {
            if (h1.Text == "" || h2.Text == "" || s1.Text == "" || s2.Text == "" || m1.Text == "" ||
                m2.Text == "")
            {
                MessageBox.Show("Некорректные значения");
                return false;
            }
            try
            {
                if (t1 is null || t2 is null)
                {
                    t1 = new Time.Time(Convert.ToSByte(h1.Text), Convert.ToSByte(m1.Text), Convert.ToSByte(s1.Text));
                    t2 = new Time.Time(Convert.ToSByte(h2.Text), Convert.ToSByte(m2.Text), Convert.ToSByte(s2.Text));
                }

                if (h1.Text != t1.Hour.ToString()) t1.Hour = Convert.ToSByte(h1.Text);
                if (m1.Text != t1.Minute.ToString()) t1.Minute = Convert.ToSByte(m1.Text);
                if (s1.Text != t1.Second.ToString()) t1.Second = Convert.ToSByte(s1.Text);

                if (h2.Text != t2.Hour.ToString()) t2.Hour = Convert.ToSByte(h2.Text);
                if (m2.Text != t2.Minute.ToString()) t2.Minute = Convert.ToSByte(m2.Text);
                if (s2.Text != t2.Second.ToString()) t2.Second = Convert.ToSByte(s2.Text);

                h1.Text = t1.Hour.ToString();
                h2.Text = t2.Hour.ToString();
                m2.Text = t2.Minute.ToString();
                m1.Text = t1.Minute.ToString();
                s1.Text = t1.Second.ToString();
                s2.Text = t2.Second.ToString();
            }
            catch 
            {
                MessageBox.Show("Некорректные значения");
                return false;
            }
            return true;
        }
        private bool MakeVarTime()
        {
            if (h1.Text == "" || s1.Text == "" || m1.Text == "")
            {
                MessageBox.Show("Некорректные значения");
                return false;
            }
            try
            {
                if (t1 is null)
                    t1 = new Time.Time(Convert.ToSByte(h1.Text), Convert.ToSByte(m1.Text), Convert.ToSByte(s1.Text));

                if (h1.Text != t1.Hour.ToString()) t1.Hour = Convert.ToSByte(h1.Text);
                if (m1.Text != t1.Minute.ToString()) t1.Minute = Convert.ToSByte(m1.Text);
                if (s1.Text != t1.Second.ToString()) t1.Second = Convert.ToSByte(s1.Text);

                h1.Text = t1.Hour.ToString();
                m1.Text = t1.Minute.ToString();
                s1.Text = t1.Second.ToString();
            }
            catch
            {
                MessageBox.Show("Некорректные значения");
                return false;
            }
            return true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if(MakeVarsTime())
            Res.Text = (t1 == t2) ? "YES!!" : "NO!";
        }

        private void Small_Click(object sender, EventArgs e)
        {
            if (MakeVarsTime())
                Res.Text = (t1 < t2) ? t1.ToString() : t2.ToString();
        }

        private void Large_Click(object sender, EventArgs e)
        {
            if (MakeVarsTime())
                Res.Text = (t1 > t2) ? t1.ToString() : t2.ToString();
        }

        private void MiS_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                t1.Sub_S(1);
            Res.Text = t1.ToString();
        }

        private void MiM_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                t1.Sub_M(1);
            Res.Text = t1.ToString();
        }

        private void MiH_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                t1.Sub_H(1);
            Res.Text = t1.ToString();
        }

        private void PlS_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                t1.Add_S(1);
            Res.Text = t1.ToString();
        }

        private void PlM_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                t1.Add_M(1);
            Res.Text = t1.ToString();
        }

        private void PlH_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                t1.Add_H(1);
            Res.Text = t1.ToString();
        }

        private void ToS_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                Res.Text = t1.ToSecond().ToString();
        }

        private void ToM_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                Res.Text = t1.ToMinute().ToString();
        }

        private void ToH_Click(object sender, EventArgs e)
        {
            if (MakeVarTime())
                Res.Text = t1.ToHour().ToString();
        }

        private void Minuse_Click(object sender, EventArgs e)
        {
            if (MakeVarsTime())
                Res.Text = (t1 + t2).ToString();
        }

        private void Pluse_Click(object sender, EventArgs e)
        {
            if (MakeVarsTime())
                Res.Text = (t1 + t2).ToString();
        }
    }
}
