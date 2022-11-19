using System;
using System.Drawing;
using System.Windows.Forms;
using DataGridView1.Gender1;
using DataGridView1.Property;


namespace DataGridView1
{
    public partial class Abiturienttinfo_form : Form
    {
        private readonly Abiturient abiturient;
        public Abiturienttinfo_form()
        {
            InitializeComponent();
            FillGender();
            FillFormaObychenia();

            abiturient = new Abiturient();
            {
                Abiturient.Birthday = DateTime.Now.AddYears(-16);
                Abiturient.Gender = Gender.Female;
                Abiturient.FormaObychenia = FormaObychenia.Ochnoe;
            }
            cbGender.SelectedItem = abiturient.Gender;
            dateTimePicker1.Value = abiturient.Birthday;
            cbFormaObychenia.SelectedItem = abiturient.FormaObychenia;
        }
        public Abiturienttinfo_form(Abiturient sourse) : this()
        {
            abiturient = sourse;
            tbName.Text = sourse.FullName;
            cbGender.SelectedItem = sourse.Gender;
            dateTimePicker1.Value = sourse.Birthday;
            cbFormaObychenia.SelectedItem = sourse.FormaObychenia;
            NUDMatem.Value = sourse.Matem;
            NUDRus.Value = sourse.Rus;
            NUDInf.Value = sourse.Inf;
        }
        public Abiturient Abiturient => abiturient;
        public void FillGender()
        {
            foreach (Gender item in Enum.GetValues(typeof(Gender)))
            {
                cbGender.Items.Add(item);
            }
        }
        public void FillFormaObychenia()
        {
            foreach (FormaObychenia item in Enum.GetValues(typeof(FormaObychenia)))
            {
                cbFormaObychenia.Items.Add(item);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            abiturient.Birthday = dateTimePicker1.Value;
        }
        private void NUDMatem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private void cbFormaObychenia_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is FormaObychenia formaobychenia)
                    {
                        string text = "";
                        switch (formaobychenia)
                        {
                            case (FormaObychenia.Ochnoe):
                                text = "Очное";
                                break;
                            case (FormaObychenia.Ocno_zaochnoe):
                                text = "Очно-заочное";
                                break;
                            case (FormaObychenia.Zaochnoe):
                                text = "Заочное";
                                break;
                        }
                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }
        private void cbGender_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Gender gender)
                    {
                        var text = gender == Gender.Male
                            ? "Мужской"
                            : "Женский";

                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex >= 0)
            {
                abiturient.Gender = (Gender)cbGender.SelectedItem;
            }
        }
        private void cbFormaObychenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaObychenia.SelectedIndex >= 0)
            {
                abiturient.FormaObychenia = (FormaObychenia)cbFormaObychenia.SelectedItem;
            }
        }

        private void NUDRus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void NUDInf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                btReady.Enabled = true;
            }
            else
            {
                btReady.Enabled = false;
            }
            abiturient.FullName = tbName.Text;
        }

        private void NUDMatem_ValueChanged(object sender, EventArgs e)
        {
            abiturient.Matem = NUDMatem.Value;
        }

        private void NUDRus_ValueChanged(object sender, EventArgs e)
        {
            abiturient.Rus = NUDRus.Value;
        }

        private void NUDInf_ValueChanged(object sender, EventArgs e)
        {
            abiturient.Inf = NUDInf.Value;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
